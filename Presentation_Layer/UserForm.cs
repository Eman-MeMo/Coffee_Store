using DataBisnessLayer.Entities;
using DataBisnessLayer.EntityLists;
using DataBisnessLayer.EntityManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
	public partial class UserForm : Form
	{
		private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
		public UserForm()
		{
			InitializeComponent();
			EnableDarkTitleBar();
		}
		private void EnableDarkTitleBar()
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 10)
			{
				int useDarkMode = 1;
				DwmSetWindowAttribute(this.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, sizeof(int));
			}
		}
		private void AddProduct(Product product, string imagePath)
		{

			Panel productPanel = new Panel();
			productPanel.Size = new Size(220, 250);
			productPanel.BorderStyle = BorderStyle.None;
			productPanel.BackColor = Color.FromArgb(235, 215, 185);

			PictureBox productImage = new PictureBox();
			productImage.Size = new Size(180, 120);
			productImage.Location = new Point(20, 10);
			productImage.SizeMode = PictureBoxSizeMode.StretchImage;
			LoadProductImage(productImage, imagePath);

			Label nameLabel = new Label();
			nameLabel.Text = product.Name;
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
			nameLabel.ForeColor = Color.FromArgb(100, 50, 0);
			nameLabel.Location = new Point(20, 140);

			Button favoriteButton = new Button();
			favoriteButton.Text = "❤️ Add to Favorite";
			favoriteButton.Size = new Size(180, 40);
			favoriteButton.Location = new Point(20, 180);
			favoriteButton.BackColor = Color.FromArgb(120, 80, 40);
			favoriteButton.ForeColor = Color.White;
			favoriteButton.FlatStyle = FlatStyle.Flat;
			favoriteButton.Font = new Font("Arial", 10, FontStyle.Bold);

			int loggedInUserId = SessionManager.Instance.UserID;
			var favoriteProducts = UserFavouriteManager.GetByUserId(loggedInUserId);
			var favProduct = UserFavouriteManager.GetSpecificUserFavourite(loggedInUserId, product.Id);

			favoriteButton.Click += (sender, e) =>
			{
				if (!favoriteProducts.Contains(favProduct))
				{
					UserFavouriteManager.Add(new UserFavourite
					{
						UserId = loggedInUserId,
						ProductId = product.Id
					});
					MessageBox.Show($"{product.Name} added to favorites!");
				}
				else
				{
					MessageBox.Show($"{product.Name} is already in favorites.");
				}
			};

			productPanel.Controls.Add(productImage);
			productPanel.Controls.Add(nameLabel);
			productPanel.Controls.Add(favoriteButton);

			PrdFP.Controls.Add(productPanel);
		}
		private void ShowFavorites()
		{
			PrdFP.Controls.Clear();
			PrdFP.BackgroundImage = null;

			var favoriteProducts = UserFavouriteManager.GetByUserId(SessionManager.Instance.UserID);

			if (favoriteProducts.Count == 0)
			{
				PrdFP.BackgroundImage = Image.FromFile("Images/empty.jpg");
				PrdFP.BackgroundImageLayout = ImageLayout.Stretch;
				MessageBox.Show("No favorite products found!");
				return;
			}

			foreach (UserFavourite item in favoriteProducts)
			{
				var product = ProductManager.GetByID(item.ProductId);
				if (product != null)
				{
					AddFavoriteProduct(product, product.image);
				}
			}
		}

		private void AddFavoriteProduct(Product product, string imageName)
		{
			Panel productPanel = new Panel();
			productPanel.Size = new Size(220, 250);
			productPanel.BorderStyle = BorderStyle.None;
			productPanel.BackColor = Color.FromArgb(235, 215, 185);

			PictureBox productImage = new PictureBox();
			productImage.Size = new Size(180, 120);
			productImage.Location = new Point(20, 10);
			productImage.SizeMode = PictureBoxSizeMode.StretchImage;
			string imagePath = Path.Combine(Application.StartupPath, "images", imageName);
			try
			{
				productImage.Image = Image.FromFile(imagePath);
			}
			catch
			{
				productImage.Image = Image.FromFile("Images/default.jpg");
			}

			Label nameLabel = new Label();
			nameLabel.Text = product.Name;
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
			nameLabel.ForeColor = Color.FromArgb(100, 50, 0);
			nameLabel.Location = new Point(20, 140);

			Button removeButton = new Button();
			removeButton.Text = "❌ Remove";
			removeButton.Size = new Size(180, 40);
			removeButton.Location = new Point(20, 180);
			removeButton.BackColor = Color.FromArgb(180, 60, 60);
			removeButton.ForeColor = Color.White;
			removeButton.FlatStyle = FlatStyle.Flat;
			removeButton.Font = new Font("Arial", 10, FontStyle.Bold);

			removeButton.Click += (sender, e) =>
			{
				int loggedInUserId = SessionManager.Instance.UserID;
				UserFavouriteManager.Delete(loggedInUserId, product.Id);
				MessageBox.Show($"{product.Name} removed from favorites!");
				ShowFavorites();
			};

			productPanel.Controls.Add(productImage);
			productPanel.Controls.Add(nameLabel);
			productPanel.Controls.Add(removeButton);

			PrdFP.Controls.Add(productPanel);
		}
		private void LoadProductImage(PictureBox prdImg, string imageName)
		{
			string imagePath = Path.Combine(Application.StartupPath, "images", imageName);

			if (File.Exists(imagePath))
			{
				prdImg.Image = Image.FromFile(imagePath);
			}
			else
			{
				prdImg.Image = Image.FromFile(Path.Combine(Application.StartupPath, "images", "default.jpg"));
			}
		}

		private void UserForm_Load(object sender, EventArgs e)
		{
			ShowProducts();
		}

		private void FavBtn_Click(object sender, EventArgs e)
		{
			profilePanel.Visible = false;
			PrdFP.Visible = true;
			ShowFavorites();
		}

		private void profileBtn_Click(object sender, EventArgs e)
		{
			PrdFP.Visible = false;
			profilePanel.Visible = true;
			var user = UserManager.GetByID(SessionManager.Instance.UserID);
			if (user != null)
			{
				usernameTxt.Text = user.Username;
				EmailTxt.Text = user.Email;
				PassTxt.Text = user.Password;
				AddressTxt.Text = user.Address;
				PhoneTxt.Text = user.Phone;
				AgeTxt.Text = user.Age.ToString();
			}
		}

		private void ProductBtn_Click(object sender, EventArgs e)
		{
			profilePanel.Visible = false;
			PrdFP.Visible = true;
			ShowProducts();
		}
		private void ShowProducts()
		{
			PrdFP.Controls.Clear();
			PrdFP.BackgroundImage = null;
			ProductList products = ProductManager.GetAll();
			foreach (Product product in products)
			{
				AddProduct(product, product.image);
			}
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			var user = UserManager.GetByEmail(EmailTxt.Text);
			if (user != null)
			{
				user.Username = usernameTxt.Text;
				user.Password = PassTxt.Text;
				user.Address = AddressTxt.Text;
				user.Phone = PhoneTxt.Text;
				user.Age = int.Parse(AgeTxt.Text);
				UserManager.Update(user);
				MessageBox.Show("Profile updated successfully!");
				usernameTxt.Text = EmailTxt.Text = PassTxt.Text = AddressTxt.Text = PhoneTxt.Text = AgeTxt.Text = "";
			}

		}
		private void LogoutBtn_Click(object sender, EventArgs e)
		{
			SessionManager.Instance.ClearSession();
			this.Hide();
			using (RegisterForm registerForm = new RegisterForm())
			{
				registerForm.ShowDialog();
			}
			this.Close();
		}
	}
}
