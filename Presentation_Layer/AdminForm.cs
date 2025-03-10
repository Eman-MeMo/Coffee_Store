using DataBisnessLayer.Entities;
using DataBisnessLayer.EntityManagers;
using System.Runtime.InteropServices;

namespace Presentation_Layer
{
	public partial class AdminForm : Form
	{
		private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
		public AdminForm()
		{
			InitializeComponent();
			mgUserPanel.Visible = false;
			categoryPanel.Visible = false;
			mgPrdPanel.Visible = false;
			Home.Visible = true;
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
		private void AdminForm_Load(object sender, EventArgs e)
		{

		}
		void ProductLoad()
		{
			ProductdataGridView.DataSource = ProductManager.GetAll();

			DataGridViewComboBoxColumn categoryColumn = new DataGridViewComboBoxColumn();
			categoryColumn.HeaderText = "Category";
			categoryColumn.Name = "CategoryID";
			categoryColumn.DataPropertyName = "CategoryID";
			categoryColumn.DisplayMember = "Name";
			categoryColumn.ValueMember = "Id";

			categoryColumn.DataSource = CategoryManager.GetAll();

			ProductdataGridView.Columns.Add(categoryColumn);
			ProductdataGridView.Columns.Remove("CategoryID");

			prdCategoryComboBox.DataSource = CategoryManager.GetAll();
			prdCategoryComboBox.DisplayMember = "Name";
			prdCategoryComboBox.ValueMember = "Id";
		}
		void UserLoad()
		{
			userdataGridView.DataSource = UserManager.GetAll();

			DataGridViewComboBoxColumn roleColumn = new DataGridViewComboBoxColumn();
			roleColumn.HeaderText = "Role";
			roleColumn.Name = "roleID";
			roleColumn.DataPropertyName = "roleID";
			roleColumn.DisplayMember = "Name";
			roleColumn.ValueMember = "Id";

			roleColumn.DataSource = RoleManager.GetAll();
			userdataGridView.Columns.Add(roleColumn);
			userdataGridView.Columns.Remove("roleID");

			RoleComboBox.DataSource = RoleManager.GetAll();
			RoleComboBox.DisplayMember = "Name";
			RoleComboBox.ValueMember = "Id";
		}
		private void ManagUserBtn_Click(object sender, EventArgs e)
		{
			Home.Visible = false;
			categoryPanel.Visible = false;
			mgPrdPanel.Visible = false;
			mgUserPanel.Visible = true;
			UserLoad();
		}


		private void ManagProductBtn_Click(object sender, EventArgs e)
		{
			Home.Visible = false;
			categoryPanel.Visible = false;
			mgUserPanel.Visible = false;
			mgPrdPanel.Visible = true;
			ProductLoad();
		}

		private void ManagCategoryBtn_Click(object sender, EventArgs e)
		{
			Home.Visible = false;
			mgUserPanel.Visible = false;
			mgPrdPanel.Visible = false;
			categoryPanel.Visible = true;
			categorydataGridView.DataSource = CategoryManager.GetAll();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AddProductBtn_Click(object sender, EventArgs e)
		{
			ProductManager.Add(new Product
			{
				Name = prdNameTextBox.Text,
				Price = Convert.ToDecimal(prdPriceTextBox.Text),
				image = prdImg.Text,
				CategoryId = Convert.ToInt32(prdCategoryComboBox.SelectedValue)
			});
			ProductLoad();
			prdImg.Image = null;
			prdNameTextBox.Text = prdPriceTextBox.Text = ProductIdTextBox.Text = "";
			prdCategoryComboBox.SelectedValue = 0;
		}

		private void EditProductBtn_Click(object sender, EventArgs e)
		{
			var product = ProductManager.GetByID(Convert.ToInt32(ProductIdTextBox.Text));
			if (product == null)
			{
				MessageBox.Show("Product Not Found");
				return;
			}
			product.Name = prdNameTextBox.Text;
			product.Price = Convert.ToDecimal(prdPriceTextBox.Text);
			product.image = prdImg.Text;
			product.CategoryId = Convert.ToInt32(prdCategoryComboBox.SelectedValue);
			ProductManager.Update(product);

			ProductLoad();
			prdImg.Image = null;
			prdNameTextBox.Text = prdPriceTextBox.Text = ProductIdTextBox.Text = "";
			prdCategoryComboBox.SelectedValue = 0;
		}

		private void DeleteProductBtn_Click(object sender, EventArgs e)
		{
			var product = ProductManager.GetByID(Convert.ToInt32(ProductIdTextBox.Text));
			if (product == null)
			{
				MessageBox.Show("Product Not Found");
				return;
			}
			ProductManager.Delete(product.Id);
			ProductLoad();
			prdImg.Image = null;
			prdNameTextBox.Text = prdPriceTextBox.Text = ProductIdTextBox.Text = "";
			prdCategoryComboBox.SelectedValue = 0;
		}

		private void SearchProductBtn_Click(object sender, EventArgs e)
		{
			var product = ProductManager.GetByID(Convert.ToInt32(ProductIdTextBox.Text));
			if (product == null)
			{
				MessageBox.Show("Product Not Found");
				return;
			}
			prdNameTextBox.Text = product.Name;
			prdPriceTextBox.Text = product.Price.ToString();
			prdCategoryComboBox.SelectedValue = product.CategoryId;
			LoadProductImage(product.image);
		}

		private void AddCategoryBtn_Click(object sender, EventArgs e)
		{
			CategoryManager.Add(new Category
			{
				Name = CategoryNameTextBox.Text
			});
			categorydataGridView.DataSource = CategoryManager.GetAll();
			CategoryNameTextBox.Text = "";
		}

		private void EditCategoryBtn_Click(object sender, EventArgs e)
		{
			var Category = CategoryManager.GetByID(Convert.ToInt32(CatogoryIdTextBox.Text));
			if (Category == null)
			{
				MessageBox.Show("Category Not Found");
				return;
			}
			Category.Name = CategoryNameTextBox.Text;
			CategoryManager.Update(Category);
			categorydataGridView.DataSource = CategoryManager.GetAll();
		}

		private void SearchCategoryBtn_Click(object sender, EventArgs e)
		{
			var Category = CategoryManager.GetByID(Convert.ToInt32(CatogoryIdTextBox.Text));
			if (Category == null)
			{
				MessageBox.Show("Category Not Found");
				return;
			}
			CategoryNameTextBox.Text = Category.Name;

		}

		private void addUserBtn_Click(object sender, EventArgs e)
		{
			UserManager.Add(new User
			{
				Username = usernameTextBox.Text,
				Email = emailTextBox.Text,
				Password = passTextBox.Text,
				Phone = phobeTxtBox.Text,
				Address = addressTextBox.Text,
				Age = Convert.ToInt32(ageTextBox.Text),
				roleID = Convert.ToInt32(RoleComboBox.SelectedValue)
			});
			UserLoad();
			usernameTextBox.Text = emailTextBox.Text = passTextBox.Text = phobeTxtBox.Text = addressTextBox.Text = ageTextBox.Text = userIDTextBpx.Text = "";
		}

		private void EditUserBtn_Click(object sender, EventArgs e)
		{
			var user = UserManager.GetByID(Convert.ToInt32(userIDTextBpx.Text));
			if (user == null)
			{
				MessageBox.Show("User Not Found");
				return;
			}
			user.Username = usernameTextBox.Text;
			user.Email = emailTextBox.Text;
			user.Password = passTextBox.Text;
			user.Phone = phobeTxtBox.Text;
			user.Address = addressTextBox.Text;
			user.Age = Convert.ToInt32(ageTextBox.Text);
			user.roleID = Convert.ToInt32(RoleComboBox.SelectedValue);
			UserManager.Update(user);
			UserLoad();
			usernameTextBox.Text = emailTextBox.Text = passTextBox.Text = phobeTxtBox.Text = addressTextBox.Text = ageTextBox.Text = userIDTextBpx.Text = "";
		}

		private void deleteUserBtn_Click(object sender, EventArgs e)
		{
			var user = UserManager.GetByID(Convert.ToInt32(userIDTextBpx.Text));
			if (user == null)
			{
				MessageBox.Show("User Not Found");
				return;
			}
			UserManager.Delete(user.Id);
			UserLoad();
			usernameTextBox.Text = emailTextBox.Text = passTextBox.Text = phobeTxtBox.Text = addressTextBox.Text = ageTextBox.Text = userIDTextBpx.Text = "";
		}

		private void searchUserBtn_Click(object sender, EventArgs e)
		{
			var user = UserManager.GetByID(Convert.ToInt32(userIDTextBpx.Text));
			if (user == null)
			{
				MessageBox.Show("User Not Found");
				return;
			}
			usernameTextBox.Text = user.Username;
			emailTextBox.Text = user.Email;
			passTextBox.Text = user.Password;
			phobeTxtBox.Text = user.Phone;
			addressTextBox.Text = user.Address;
			ageTextBox.Text = user.Age.ToString();
			RoleComboBox.SelectedValue = user.roleID;
		}

		private void DeleteCategoryBtn_Click(object sender, EventArgs e)
		{
			var Category = CategoryManager.GetByID(Convert.ToInt32(CatogoryIdTextBox.Text));
			if (Category == null)
			{
				MessageBox.Show("Category Not Found");
				return;
			}
			CategoryManager.Delete(Category.Id);
			categorydataGridView.DataSource = CategoryManager.GetAll();
		}
		private void LoadProductImage(string imageName)
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

		private void LogoutAdminBtn_Click(object sender, EventArgs e)
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
