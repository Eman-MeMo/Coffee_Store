using DataBisnessLayer.Entities;
using DataBisnessLayer.EntityManagers;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation_Layer
{
	public partial class RegisterForm : Form
	{
		private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		public RegisterForm()
		{
			InitializeComponent();
			loginPanel.Parent = this;
			registPanel.Parent = this;
			loginPanel.Visible = true;
			registPanel.Visible = false;
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

		private void loginLinkBtn_Click(object sender, EventArgs e)
		{
			if (loginPanel == null || registPanel == null) return;

			registPanel.Visible = false;
			loginPanel.Visible = true;
			loginPanel.BringToFront();
			this.Refresh();
		}

		private void registerLinkBtn_Click(object sender, EventArgs e)
		{
			if (loginPanel == null || registPanel == null) return;

			registPanel.Visible = true;
			registPanel.BringToFront();
			loginPanel.Visible = false;
			this.Refresh();
		}
		private void RegisterBtn_Click(object sender, EventArgs e)
		{
			try
			{
				User user = new User()
				{
					Username = usernameTxt.Text,
					Email = EmailTxt.Text,
					Password = PassTxt.Text,
					Address = AddressTxt.Text,
					Phone = PhoneTxt.Text,
					Age = int.Parse(AgeTxt.Text),
					roleID = 2
				};
				UserManager.Add(user);
				SessionManager.Instance.SetUser(user.Id);
				OpenUserForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			var user = UserManager.GetByEmail(emailTextBox.Text);
			if (user != null)
			{
				if (user.Password == passTextBox.Text)
				{
					SessionManager.Instance.SetUser(user.Id);
					if (user.roleID == 2)
					{
						OpenUserForm();
						return;
					}
					else if (user.roleID == 1)
					{
						this.Hide();
						using (AdminForm adminForm = new AdminForm())
						{
							adminForm.ShowDialog();
						}
						this.Close();
						return;
					}
				}
			}
			MessageBox.Show("Invalid Email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void OpenUserForm()
		{
			this.Hide();
			using (UserForm userForm = new UserForm())
			{
				userForm.ShowDialog();
			}
			this.Close();
		}

		private void registPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
