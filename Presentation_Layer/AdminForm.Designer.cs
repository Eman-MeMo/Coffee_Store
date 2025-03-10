namespace Presentation_Layer
{
	partial class AdminForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
			nav = new Panel();
			LogoutAdminBtn = new Button();
			ManagProductBtn = new Button();
			ManagCategoryBtn = new Button();
			ManagUserBtn = new Button();
			mgPrdPanel = new Panel();
			label18 = new Label();
			ProductIdTextBox = new TextBox();
			prdImg = new PictureBox();
			prdCategoryComboBox = new ComboBox();
			prdPriceTextBox = new TextBox();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			prdNameTextBox = new TextBox();
			label15 = new Label();
			label16 = new Label();
			SearchProductBtn = new Button();
			DeleteProductBtn = new Button();
			EditProductBtn = new Button();
			ProductdataGridView = new DataGridView();
			AddProductBtn = new Button();
			categoryPanel = new Panel();
			label17 = new Label();
			CatogoryIdTextBox = new TextBox();
			label10 = new Label();
			CategoryNameTextBox = new TextBox();
			label11 = new Label();
			SearchCategoryBtn = new Button();
			DeleteCategoryBtn = new Button();
			EditCategoryBtn = new Button();
			categorydataGridView = new DataGridView();
			AddCategoryBtn = new Button();
			Home = new Panel();
			label1 = new Label();
			mgUserPanel = new Panel();
			phobeTxtBox = new TextBox();
			label19 = new Label();
			label7 = new Label();
			userIDTextBpx = new TextBox();
			label8 = new Label();
			label6 = new Label();
			ageTextBox = new TextBox();
			RoleComboBox = new ComboBox();
			passTextBox = new TextBox();
			emailTextBox = new TextBox();
			addressTextBox = new TextBox();
			usernameTextBox = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label9 = new Label();
			searchUserBtn = new Button();
			deleteUserBtn = new Button();
			EditUserBtn = new Button();
			userdataGridView = new DataGridView();
			addUserBtn = new Button();
			nav.SuspendLayout();
			mgPrdPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)prdImg).BeginInit();
			((System.ComponentModel.ISupportInitialize)ProductdataGridView).BeginInit();
			categoryPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)categorydataGridView).BeginInit();
			Home.SuspendLayout();
			mgUserPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)userdataGridView).BeginInit();
			SuspendLayout();
			// 
			// nav
			// 
			nav.BackColor = Color.FromArgb(41, 39, 40);
			nav.Controls.Add(LogoutAdminBtn);
			nav.Controls.Add(ManagProductBtn);
			nav.Controls.Add(ManagCategoryBtn);
			nav.Controls.Add(ManagUserBtn);
			nav.Dock = DockStyle.Left;
			nav.Location = new Point(0, 0);
			nav.Name = "nav";
			nav.Size = new Size(205, 734);
			nav.TabIndex = 0;
			// 
			// LogoutAdminBtn
			// 
			LogoutAdminBtn.FlatAppearance.BorderSize = 0;
			LogoutAdminBtn.FlatStyle = FlatStyle.Flat;
			LogoutAdminBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LogoutAdminBtn.ForeColor = Color.White;
			LogoutAdminBtn.Location = new Point(3, 556);
			LogoutAdminBtn.Name = "LogoutAdminBtn";
			LogoutAdminBtn.Size = new Size(198, 54);
			LogoutAdminBtn.TabIndex = 4;
			LogoutAdminBtn.Text = "Log Out";
			LogoutAdminBtn.UseVisualStyleBackColor = true;
			LogoutAdminBtn.Click += LogoutAdminBtn_Click;
			// 
			// ManagProductBtn
			// 
			ManagProductBtn.FlatAppearance.BorderSize = 0;
			ManagProductBtn.FlatStyle = FlatStyle.Flat;
			ManagProductBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ManagProductBtn.ForeColor = Color.White;
			ManagProductBtn.Location = new Point(3, 313);
			ManagProductBtn.Name = "ManagProductBtn";
			ManagProductBtn.Size = new Size(198, 54);
			ManagProductBtn.TabIndex = 3;
			ManagProductBtn.Text = "Manage Products";
			ManagProductBtn.UseVisualStyleBackColor = true;
			ManagProductBtn.Click += ManagProductBtn_Click;
			// 
			// ManagCategoryBtn
			// 
			ManagCategoryBtn.FlatAppearance.BorderSize = 0;
			ManagCategoryBtn.FlatStyle = FlatStyle.Flat;
			ManagCategoryBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ManagCategoryBtn.ForeColor = Color.White;
			ManagCategoryBtn.Location = new Point(3, 434);
			ManagCategoryBtn.Name = "ManagCategoryBtn";
			ManagCategoryBtn.Size = new Size(198, 54);
			ManagCategoryBtn.TabIndex = 2;
			ManagCategoryBtn.Text = "Manage Categories";
			ManagCategoryBtn.UseVisualStyleBackColor = true;
			ManagCategoryBtn.Click += ManagCategoryBtn_Click;
			// 
			// ManagUserBtn
			// 
			ManagUserBtn.FlatAppearance.BorderSize = 0;
			ManagUserBtn.FlatStyle = FlatStyle.Flat;
			ManagUserBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ManagUserBtn.ForeColor = Color.White;
			ManagUserBtn.Location = new Point(3, 189);
			ManagUserBtn.Name = "ManagUserBtn";
			ManagUserBtn.Size = new Size(202, 54);
			ManagUserBtn.TabIndex = 1;
			ManagUserBtn.Text = "Manage Users";
			ManagUserBtn.UseVisualStyleBackColor = true;
			ManagUserBtn.Click += ManagUserBtn_Click;
			// 
			// mgPrdPanel
			// 
			mgPrdPanel.BackgroundImage = (Image)resources.GetObject("mgPrdPanel.BackgroundImage");
			mgPrdPanel.BackgroundImageLayout = ImageLayout.Stretch;
			mgPrdPanel.Controls.Add(label18);
			mgPrdPanel.Controls.Add(ProductIdTextBox);
			mgPrdPanel.Controls.Add(prdImg);
			mgPrdPanel.Controls.Add(prdCategoryComboBox);
			mgPrdPanel.Controls.Add(prdPriceTextBox);
			mgPrdPanel.Controls.Add(label12);
			mgPrdPanel.Controls.Add(label13);
			mgPrdPanel.Controls.Add(label14);
			mgPrdPanel.Controls.Add(prdNameTextBox);
			mgPrdPanel.Controls.Add(label15);
			mgPrdPanel.Controls.Add(label16);
			mgPrdPanel.Controls.Add(SearchProductBtn);
			mgPrdPanel.Controls.Add(DeleteProductBtn);
			mgPrdPanel.Controls.Add(EditProductBtn);
			mgPrdPanel.Controls.Add(ProductdataGridView);
			mgPrdPanel.Controls.Add(AddProductBtn);
			mgPrdPanel.Location = new Point(203, 0);
			mgPrdPanel.Name = "mgPrdPanel";
			mgPrdPanel.Size = new Size(1076, 734);
			mgPrdPanel.TabIndex = 1;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.BackColor = Color.MistyRose;
			label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label18.ForeColor = Color.Sienna;
			label18.Location = new Point(97, 172);
			label18.Name = "label18";
			label18.Size = new Size(33, 28);
			label18.TabIndex = 47;
			label18.Text = "ID";
			// 
			// ProductIdTextBox
			// 
			ProductIdTextBox.BackColor = Color.MistyRose;
			ProductIdTextBox.Location = new Point(189, 176);
			ProductIdTextBox.Name = "ProductIdTextBox";
			ProductIdTextBox.Size = new Size(170, 27);
			ProductIdTextBox.TabIndex = 46;
			// 
			// prdImg
			// 
			prdImg.BackColor = Color.MistyRose;
			prdImg.Location = new Point(831, 363);
			prdImg.Name = "prdImg";
			prdImg.Size = new Size(230, 183);
			prdImg.SizeMode = PictureBoxSizeMode.StretchImage;
			prdImg.TabIndex = 62;
			prdImg.TabStop = false;
			// 
			// prdCategoryComboBox
			// 
			prdCategoryComboBox.BackColor = Color.MistyRose;
			prdCategoryComboBox.ForeColor = Color.Black;
			prdCategoryComboBox.FormattingEnabled = true;
			prdCategoryComboBox.Location = new Point(603, 488);
			prdCategoryComboBox.Name = "prdCategoryComboBox";
			prdCategoryComboBox.Size = new Size(187, 28);
			prdCategoryComboBox.TabIndex = 61;
			// 
			// prdPriceTextBox
			// 
			prdPriceTextBox.BackColor = Color.MistyRose;
			prdPriceTextBox.Location = new Point(603, 418);
			prdPriceTextBox.Name = "prdPriceTextBox";
			prdPriceTextBox.Size = new Size(187, 27);
			prdPriceTextBox.TabIndex = 60;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.MistyRose;
			label12.Font = new Font("Sitka Banner", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label12.ForeColor = Color.Sienna;
			label12.Location = new Point(434, 121);
			label12.Name = "label12";
			label12.Size = new Size(197, 68);
			label12.TabIndex = 59;
			label12.Text = "Products";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.BackColor = Color.MistyRose;
			label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label13.ForeColor = Color.Sienna;
			label13.Location = new Point(878, 313);
			label13.Name = "label13";
			label13.Size = new Size(70, 28);
			label13.TabIndex = 58;
			label13.Text = "Image";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.BackColor = Color.MistyRose;
			label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label14.ForeColor = Color.Sienna;
			label14.Location = new Point(469, 484);
			label14.Name = "label14";
			label14.Size = new Size(98, 28);
			label14.TabIndex = 57;
			label14.Text = "Category";
			// 
			// prdNameTextBox
			// 
			prdNameTextBox.BackColor = Color.MistyRose;
			prdNameTextBox.Location = new Point(603, 358);
			prdNameTextBox.Name = "prdNameTextBox";
			prdNameTextBox.Size = new Size(187, 27);
			prdNameTextBox.TabIndex = 56;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.BackColor = Color.MistyRose;
			label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label15.ForeColor = Color.Sienna;
			label15.Location = new Point(469, 418);
			label15.Name = "label15";
			label15.Size = new Size(59, 28);
			label15.TabIndex = 55;
			label15.Text = "Price";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.BackColor = Color.MistyRose;
			label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label16.ForeColor = Color.Sienna;
			label16.Location = new Point(469, 358);
			label16.Name = "label16";
			label16.Size = new Size(68, 28);
			label16.TabIndex = 54;
			label16.Text = "Name";
			// 
			// SearchProductBtn
			// 
			SearchProductBtn.BackColor = Color.MistyRose;
			SearchProductBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			SearchProductBtn.ForeColor = Color.Sienna;
			SearchProductBtn.Location = new Point(922, 603);
			SearchProductBtn.Name = "SearchProductBtn";
			SearchProductBtn.Size = new Size(113, 42);
			SearchProductBtn.TabIndex = 53;
			SearchProductBtn.Text = "Search";
			SearchProductBtn.UseVisualStyleBackColor = false;
			SearchProductBtn.Click += SearchProductBtn_Click;
			// 
			// DeleteProductBtn
			// 
			DeleteProductBtn.BackColor = Color.MistyRose;
			DeleteProductBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			DeleteProductBtn.ForeColor = Color.Sienna;
			DeleteProductBtn.Location = new Point(770, 603);
			DeleteProductBtn.Name = "DeleteProductBtn";
			DeleteProductBtn.Size = new Size(113, 42);
			DeleteProductBtn.TabIndex = 52;
			DeleteProductBtn.Text = "Delete";
			DeleteProductBtn.UseVisualStyleBackColor = false;
			DeleteProductBtn.Click += DeleteProductBtn_Click;
			// 
			// EditProductBtn
			// 
			EditProductBtn.BackColor = Color.MistyRose;
			EditProductBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			EditProductBtn.ForeColor = Color.Sienna;
			EditProductBtn.Location = new Point(619, 603);
			EditProductBtn.Name = "EditProductBtn";
			EditProductBtn.Size = new Size(112, 42);
			EditProductBtn.TabIndex = 51;
			EditProductBtn.Text = "Edit";
			EditProductBtn.UseVisualStyleBackColor = false;
			EditProductBtn.Click += EditProductBtn_Click;
			// 
			// ProductdataGridView
			// 
			ProductdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ProductdataGridView.Location = new Point(18, 238);
			ProductdataGridView.Name = "ProductdataGridView";
			ProductdataGridView.RowHeadersWidth = 51;
			ProductdataGridView.Size = new Size(430, 456);
			ProductdataGridView.TabIndex = 50;
			// 
			// AddProductBtn
			// 
			AddProductBtn.BackColor = Color.MistyRose;
			AddProductBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			AddProductBtn.ForeColor = Color.Sienna;
			AddProductBtn.Location = new Point(471, 603);
			AddProductBtn.Name = "AddProductBtn";
			AddProductBtn.Size = new Size(107, 42);
			AddProductBtn.TabIndex = 49;
			AddProductBtn.Text = "Add";
			AddProductBtn.UseVisualStyleBackColor = false;
			AddProductBtn.Click += AddProductBtn_Click;
			// 
			// categoryPanel
			// 
			categoryPanel.BackgroundImage = (Image)resources.GetObject("categoryPanel.BackgroundImage");
			categoryPanel.BackgroundImageLayout = ImageLayout.Stretch;
			categoryPanel.Controls.Add(label17);
			categoryPanel.Controls.Add(CatogoryIdTextBox);
			categoryPanel.Controls.Add(label10);
			categoryPanel.Controls.Add(CategoryNameTextBox);
			categoryPanel.Controls.Add(label11);
			categoryPanel.Controls.Add(SearchCategoryBtn);
			categoryPanel.Controls.Add(DeleteCategoryBtn);
			categoryPanel.Controls.Add(EditCategoryBtn);
			categoryPanel.Controls.Add(categorydataGridView);
			categoryPanel.Controls.Add(AddCategoryBtn);
			categoryPanel.Location = new Point(203, 0);
			categoryPanel.Name = "categoryPanel";
			categoryPanel.Size = new Size(1079, 734);
			categoryPanel.TabIndex = 44;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.BackColor = Color.MistyRose;
			label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label17.ForeColor = Color.Sienna;
			label17.Location = new Point(148, 189);
			label17.Name = "label17";
			label17.Size = new Size(33, 28);
			label17.TabIndex = 47;
			label17.Text = "ID";
			// 
			// CatogoryIdTextBox
			// 
			CatogoryIdTextBox.BackColor = Color.MistyRose;
			CatogoryIdTextBox.Location = new Point(240, 193);
			CatogoryIdTextBox.Name = "CatogoryIdTextBox";
			CatogoryIdTextBox.Size = new Size(170, 27);
			CatogoryIdTextBox.TabIndex = 46;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.MistyRose;
			label10.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.Sienna;
			label10.Location = new Point(431, 108);
			label10.Name = "label10";
			label10.Size = new Size(196, 58);
			label10.TabIndex = 67;
			label10.Text = "Categories";
			// 
			// CategoryNameTextBox
			// 
			CategoryNameTextBox.BackColor = Color.MistyRose;
			CategoryNameTextBox.Location = new Point(755, 367);
			CategoryNameTextBox.Name = "CategoryNameTextBox";
			CategoryNameTextBox.Size = new Size(135, 27);
			CategoryNameTextBox.TabIndex = 66;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = Color.MistyRose;
			label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.Sienna;
			label11.Location = new Point(569, 367);
			label11.Name = "label11";
			label11.Size = new Size(68, 28);
			label11.TabIndex = 65;
			label11.Text = "Name";
			// 
			// SearchCategoryBtn
			// 
			SearchCategoryBtn.BackColor = Color.MistyRose;
			SearchCategoryBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			SearchCategoryBtn.ForeColor = Color.Sienna;
			SearchCategoryBtn.Location = new Point(918, 474);
			SearchCategoryBtn.Name = "SearchCategoryBtn";
			SearchCategoryBtn.Size = new Size(94, 42);
			SearchCategoryBtn.TabIndex = 64;
			SearchCategoryBtn.Text = "Search";
			SearchCategoryBtn.UseVisualStyleBackColor = false;
			SearchCategoryBtn.Click += SearchCategoryBtn_Click;
			// 
			// DeleteCategoryBtn
			// 
			DeleteCategoryBtn.BackColor = Color.MistyRose;
			DeleteCategoryBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			DeleteCategoryBtn.ForeColor = Color.Sienna;
			DeleteCategoryBtn.Location = new Point(786, 474);
			DeleteCategoryBtn.Name = "DeleteCategoryBtn";
			DeleteCategoryBtn.Size = new Size(104, 42);
			DeleteCategoryBtn.TabIndex = 63;
			DeleteCategoryBtn.Text = "Delete";
			DeleteCategoryBtn.UseVisualStyleBackColor = false;
			DeleteCategoryBtn.Click += DeleteCategoryBtn_Click;
			// 
			// EditCategoryBtn
			// 
			EditCategoryBtn.BackColor = Color.MistyRose;
			EditCategoryBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			EditCategoryBtn.ForeColor = Color.Sienna;
			EditCategoryBtn.Location = new Point(660, 474);
			EditCategoryBtn.Name = "EditCategoryBtn";
			EditCategoryBtn.Size = new Size(92, 42);
			EditCategoryBtn.TabIndex = 62;
			EditCategoryBtn.Text = "Edit";
			EditCategoryBtn.UseVisualStyleBackColor = false;
			EditCategoryBtn.Click += EditCategoryBtn_Click;
			// 
			// categorydataGridView
			// 
			categorydataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			categorydataGridView.Location = new Point(39, 249);
			categorydataGridView.Name = "categorydataGridView";
			categorydataGridView.RowHeadersWidth = 51;
			categorydataGridView.Size = new Size(467, 325);
			categorydataGridView.TabIndex = 61;
			// 
			// AddCategoryBtn
			// 
			AddCategoryBtn.BackColor = Color.MistyRose;
			AddCategoryBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			AddCategoryBtn.ForeColor = Color.Sienna;
			AddCategoryBtn.Location = new Point(541, 474);
			AddCategoryBtn.Name = "AddCategoryBtn";
			AddCategoryBtn.Size = new Size(96, 42);
			AddCategoryBtn.TabIndex = 60;
			AddCategoryBtn.Text = "Add";
			AddCategoryBtn.UseVisualStyleBackColor = false;
			AddCategoryBtn.Click += AddCategoryBtn_Click;
			// 
			// Home
			// 
			Home.BackgroundImage = (Image)resources.GetObject("Home.BackgroundImage");
			Home.BackgroundImageLayout = ImageLayout.Stretch;
			Home.Controls.Add(label1);
			Home.Location = new Point(203, 0);
			Home.Name = "Home";
			Home.Size = new Size(1076, 734);
			Home.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Sitka Banner", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(350, 18);
			label1.Name = "label1";
			label1.Size = new Size(345, 62);
			label1.TabIndex = 0;
			label1.Text = "Admin DashBoard";
			// 
			// mgUserPanel
			// 
			mgUserPanel.BackgroundImage = (Image)resources.GetObject("mgUserPanel.BackgroundImage");
			mgUserPanel.BackgroundImageLayout = ImageLayout.Stretch;
			mgUserPanel.Controls.Add(phobeTxtBox);
			mgUserPanel.Controls.Add(label19);
			mgUserPanel.Controls.Add(label7);
			mgUserPanel.Controls.Add(userIDTextBpx);
			mgUserPanel.Controls.Add(label8);
			mgUserPanel.Controls.Add(label6);
			mgUserPanel.Controls.Add(ageTextBox);
			mgUserPanel.Controls.Add(RoleComboBox);
			mgUserPanel.Controls.Add(passTextBox);
			mgUserPanel.Controls.Add(emailTextBox);
			mgUserPanel.Controls.Add(addressTextBox);
			mgUserPanel.Controls.Add(usernameTextBox);
			mgUserPanel.Controls.Add(label5);
			mgUserPanel.Controls.Add(label4);
			mgUserPanel.Controls.Add(label3);
			mgUserPanel.Controls.Add(label2);
			mgUserPanel.Controls.Add(label9);
			mgUserPanel.Controls.Add(searchUserBtn);
			mgUserPanel.Controls.Add(deleteUserBtn);
			mgUserPanel.Controls.Add(EditUserBtn);
			mgUserPanel.Controls.Add(userdataGridView);
			mgUserPanel.Controls.Add(addUserBtn);
			mgUserPanel.Location = new Point(200, 0);
			mgUserPanel.Name = "mgUserPanel";
			mgUserPanel.Size = new Size(1079, 734);
			mgUserPanel.TabIndex = 1;
			// 
			// phobeTxtBox
			// 
			phobeTxtBox.BackColor = Color.MistyRose;
			phobeTxtBox.Location = new Point(682, 502);
			phobeTxtBox.Name = "phobeTxtBox";
			phobeTxtBox.Size = new Size(170, 27);
			phobeTxtBox.TabIndex = 47;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.BackColor = Color.MistyRose;
			label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label19.ForeColor = Color.Sienna;
			label19.Location = new Point(506, 502);
			label19.Name = "label19";
			label19.Size = new Size(71, 28);
			label19.TabIndex = 46;
			label19.Text = "Phone";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.MistyRose;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label7.ForeColor = Color.Sienna;
			label7.Location = new Point(100, 167);
			label7.Name = "label7";
			label7.Size = new Size(33, 28);
			label7.TabIndex = 45;
			label7.Text = "ID";
			// 
			// userIDTextBpx
			// 
			userIDTextBpx.BackColor = Color.MistyRose;
			userIDTextBpx.Location = new Point(192, 171);
			userIDTextBpx.Name = "userIDTextBpx";
			userIDTextBpx.Size = new Size(170, 27);
			userIDTextBpx.TabIndex = 44;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.MistyRose;
			label8.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.Sienna;
			label8.Location = new Point(464, 106);
			label8.Name = "label8";
			label8.Size = new Size(116, 58);
			label8.TabIndex = 43;
			label8.Text = "Users";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.MistyRose;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label6.ForeColor = Color.Sienna;
			label6.Location = new Point(506, 556);
			label6.Name = "label6";
			label6.Size = new Size(54, 28);
			label6.TabIndex = 40;
			label6.Text = "Role";
			// 
			// ageTextBox
			// 
			ageTextBox.BackColor = Color.MistyRose;
			ageTextBox.Location = new Point(682, 446);
			ageTextBox.Name = "ageTextBox";
			ageTextBox.Size = new Size(170, 27);
			ageTextBox.TabIndex = 39;
			// 
			// RoleComboBox
			// 
			RoleComboBox.BackColor = Color.MistyRose;
			RoleComboBox.FormattingEnabled = true;
			RoleComboBox.Location = new Point(682, 560);
			RoleComboBox.Name = "RoleComboBox";
			RoleComboBox.Size = new Size(170, 28);
			RoleComboBox.TabIndex = 38;
			// 
			// passTextBox
			// 
			passTextBox.BackColor = Color.MistyRose;
			passTextBox.Location = new Point(682, 330);
			passTextBox.Name = "passTextBox";
			passTextBox.Size = new Size(170, 27);
			passTextBox.TabIndex = 37;
			// 
			// emailTextBox
			// 
			emailTextBox.BackColor = Color.MistyRose;
			emailTextBox.Location = new Point(684, 279);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(170, 27);
			emailTextBox.TabIndex = 35;
			// 
			// addressTextBox
			// 
			addressTextBox.BackColor = Color.MistyRose;
			addressTextBox.Location = new Point(684, 386);
			addressTextBox.Name = "addressTextBox";
			addressTextBox.Size = new Size(170, 27);
			addressTextBox.TabIndex = 36;
			// 
			// usernameTextBox
			// 
			usernameTextBox.BackColor = Color.MistyRose;
			usernameTextBox.Location = new Point(684, 227);
			usernameTextBox.Name = "usernameTextBox";
			usernameTextBox.Size = new Size(170, 27);
			usernameTextBox.TabIndex = 34;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.MistyRose;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.ForeColor = Color.Sienna;
			label5.Location = new Point(506, 445);
			label5.Name = "label5";
			label5.Size = new Size(49, 28);
			label5.TabIndex = 33;
			label5.Text = "Age";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.MistyRose;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.ForeColor = Color.Sienna;
			label4.Location = new Point(501, 386);
			label4.Name = "label4";
			label4.Size = new Size(87, 28);
			label4.TabIndex = 32;
			label4.Text = "Address";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.MistyRose;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.ForeColor = Color.Sienna;
			label3.Location = new Point(501, 279);
			label3.Name = "label3";
			label3.Size = new Size(64, 28);
			label3.TabIndex = 31;
			label3.Text = "Email";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.MistyRose;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = Color.Sienna;
			label2.Location = new Point(499, 330);
			label2.Name = "label2";
			label2.Size = new Size(101, 28);
			label2.TabIndex = 30;
			label2.Text = "Password";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.MistyRose;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label9.ForeColor = Color.Sienna;
			label9.Location = new Point(501, 227);
			label9.Name = "label9";
			label9.Size = new Size(106, 28);
			label9.TabIndex = 29;
			label9.Text = "Username";
			// 
			// searchUserBtn
			// 
			searchUserBtn.BackColor = Color.MistyRose;
			searchUserBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			searchUserBtn.ForeColor = Color.Sienna;
			searchUserBtn.Location = new Point(938, 632);
			searchUserBtn.Name = "searchUserBtn";
			searchUserBtn.Size = new Size(108, 48);
			searchUserBtn.TabIndex = 28;
			searchUserBtn.Text = "Search";
			searchUserBtn.UseVisualStyleBackColor = false;
			searchUserBtn.Click += searchUserBtn_Click;
			// 
			// deleteUserBtn
			// 
			deleteUserBtn.BackColor = Color.MistyRose;
			deleteUserBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			deleteUserBtn.ForeColor = Color.Sienna;
			deleteUserBtn.Location = new Point(797, 632);
			deleteUserBtn.Name = "deleteUserBtn";
			deleteUserBtn.Size = new Size(108, 48);
			deleteUserBtn.TabIndex = 27;
			deleteUserBtn.Text = "Delete";
			deleteUserBtn.UseVisualStyleBackColor = false;
			deleteUserBtn.Click += deleteUserBtn_Click;
			// 
			// EditUserBtn
			// 
			EditUserBtn.BackColor = Color.MistyRose;
			EditUserBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			EditUserBtn.ForeColor = Color.Sienna;
			EditUserBtn.Location = new Point(644, 632);
			EditUserBtn.Name = "EditUserBtn";
			EditUserBtn.Size = new Size(108, 48);
			EditUserBtn.TabIndex = 26;
			EditUserBtn.Text = "Edit";
			EditUserBtn.UseVisualStyleBackColor = false;
			EditUserBtn.Click += EditUserBtn_Click;
			// 
			// userdataGridView
			// 
			userdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			userdataGridView.Location = new Point(18, 227);
			userdataGridView.Name = "userdataGridView";
			userdataGridView.RowHeadersWidth = 51;
			userdataGridView.Size = new Size(414, 453);
			userdataGridView.TabIndex = 25;
			// 
			// addUserBtn
			// 
			addUserBtn.BackColor = Color.MistyRose;
			addUserBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
			addUserBtn.ForeColor = Color.Sienna;
			addUserBtn.Location = new Point(501, 632);
			addUserBtn.Name = "addUserBtn";
			addUserBtn.Size = new Size(108, 48);
			addUserBtn.TabIndex = 24;
			addUserBtn.Text = "Add";
			addUserBtn.UseVisualStyleBackColor = false;
			addUserBtn.Click += addUserBtn_Click;
			// 
			// AdminForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(41, 39, 40);
			ClientSize = new Size(1276, 734);
			Controls.Add(Home);
			Controls.Add(nav);
			Controls.Add(mgUserPanel);
			Controls.Add(categoryPanel);
			Controls.Add(mgPrdPanel);
			Name = "AdminForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Form1";
			Load += AdminForm_Load;
			nav.ResumeLayout(false);
			mgPrdPanel.ResumeLayout(false);
			mgPrdPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)prdImg).EndInit();
			((System.ComponentModel.ISupportInitialize)ProductdataGridView).EndInit();
			categoryPanel.ResumeLayout(false);
			categoryPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)categorydataGridView).EndInit();
			Home.ResumeLayout(false);
			Home.PerformLayout();
			mgUserPanel.ResumeLayout(false);
			mgUserPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)userdataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel nav;
		private Button ManagUserBtn;
		private Button LogoutAdminBtn;
		private Button ManagProductBtn;
		private Button ManagCategoryBtn;
		private Panel Home;
		private Label label1;
		private Panel mgUserPanel;
		private Label label8;
		private Label label6;
		private TextBox ageTextBox;
		private ComboBox RoleComboBox;
		private TextBox passTextBox;
		private TextBox emailTextBox;
		private TextBox addressTextBox;
		private TextBox usernameTextBox;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label9;
		private Button searchUserBtn;
		private Button deleteUserBtn;
		private Button EditUserBtn;
		private DataGridView userdataGridView;
		private Button addUserBtn;
		private Panel categoryPanel;
		private Label label10;
		private TextBox CategoryNameTextBox;
		private Label label11;
		private Button SearchCategoryBtn;
		private Button DeleteCategoryBtn;
		private Button EditCategoryBtn;
		private DataGridView categorydataGridView;
		private Button AddCategoryBtn;
		private Panel mgPrdPanel;
		private PictureBox prdImg;
		private ComboBox prdCategoryComboBox;
		private TextBox prdPriceTextBox;
		private Label label12;
		private Label label13;
		private Label label14;
		private TextBox prdNameTextBox;
		private Label label15;
		private Label label16;
		private Button SearchProductBtn;
		private Button DeleteProductBtn;
		private Button EditProductBtn;
		private DataGridView ProductdataGridView;
		private Button AddProductBtn;
		private Label label18;
		private TextBox ProductIdTextBox;
		private Label label17;
		private TextBox CatogoryIdTextBox;
		private Label label7;
		private TextBox userIDTextBpx;
		private TextBox phobeTxtBox;
		private Label label19;
	}
}
