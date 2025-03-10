namespace Presentation_Layer
{
	partial class UserForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
			panel1 = new Panel();
			nav = new Panel();
			panel2 = new Panel();
			LogoutBtn = new Button();
			FavBtn = new Button();
			profileBtn = new Button();
			ProductBtn = new Button();
			PrdFP = new FlowLayoutPanel();
			profilePanel = new Panel();
			PhoneTxt = new TextBox();
			label10 = new Label();
			saveBtn = new Button();
			AgeTxt = new TextBox();
			AddressTxt = new TextBox();
			EmailTxt = new TextBox();
			PassTxt = new TextBox();
			usernameTxt = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			Edit = new Label();
			panel1.SuspendLayout();
			nav.SuspendLayout();
			profilePanel.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(nav);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(203, 718);
			panel1.TabIndex = 1;
			// 
			// nav
			// 
			nav.BackColor = Color.FromArgb(41, 39, 40);
			nav.Controls.Add(panel2);
			nav.Controls.Add(LogoutBtn);
			nav.Controls.Add(FavBtn);
			nav.Controls.Add(profileBtn);
			nav.Controls.Add(ProductBtn);
			nav.Dock = DockStyle.Left;
			nav.Location = new Point(0, 0);
			nav.Name = "nav";
			nav.Size = new Size(205, 718);
			nav.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.Location = new Point(207, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(822, 702);
			panel2.TabIndex = 0;
			// 
			// LogoutBtn
			// 
			LogoutBtn.FlatAppearance.BorderSize = 0;
			LogoutBtn.FlatStyle = FlatStyle.Flat;
			LogoutBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LogoutBtn.ForeColor = Color.White;
			LogoutBtn.Location = new Point(3, 556);
			LogoutBtn.Name = "LogoutBtn";
			LogoutBtn.Size = new Size(198, 54);
			LogoutBtn.TabIndex = 4;
			LogoutBtn.Text = "Log Out";
			LogoutBtn.UseVisualStyleBackColor = true;
			LogoutBtn.Click += LogoutBtn_Click;
			// 
			// FavBtn
			// 
			FavBtn.FlatAppearance.BorderSize = 0;
			FavBtn.FlatStyle = FlatStyle.Flat;
			FavBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FavBtn.ForeColor = Color.White;
			FavBtn.Location = new Point(3, 313);
			FavBtn.Name = "FavBtn";
			FavBtn.Size = new Size(198, 54);
			FavBtn.TabIndex = 3;
			FavBtn.Text = "Show Favourite List";
			FavBtn.UseVisualStyleBackColor = true;
			FavBtn.Click += FavBtn_Click;
			// 
			// profileBtn
			// 
			profileBtn.FlatAppearance.BorderSize = 0;
			profileBtn.FlatStyle = FlatStyle.Flat;
			profileBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			profileBtn.ForeColor = Color.White;
			profileBtn.Location = new Point(3, 434);
			profileBtn.Name = "profileBtn";
			profileBtn.Size = new Size(198, 54);
			profileBtn.TabIndex = 2;
			profileBtn.Text = "Edit Profile";
			profileBtn.UseVisualStyleBackColor = true;
			profileBtn.Click += profileBtn_Click;
			// 
			// ProductBtn
			// 
			ProductBtn.FlatAppearance.BorderSize = 0;
			ProductBtn.FlatStyle = FlatStyle.Flat;
			ProductBtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ProductBtn.ForeColor = Color.White;
			ProductBtn.Location = new Point(3, 189);
			ProductBtn.Name = "ProductBtn";
			ProductBtn.Size = new Size(202, 54);
			ProductBtn.TabIndex = 1;
			ProductBtn.Text = "Show Products";
			ProductBtn.UseVisualStyleBackColor = true;
			ProductBtn.Click += ProductBtn_Click;
			// 
			// PrdFP
			// 
			PrdFP.AutoScroll = true;
			PrdFP.AutoSize = true;
			PrdFP.BackColor = Color.FromArgb(41, 39, 40);
			PrdFP.Dock = DockStyle.Fill;
			PrdFP.Location = new Point(203, 0);
			PrdFP.Name = "PrdFP";
			PrdFP.Size = new Size(904, 718);
			PrdFP.TabIndex = 2;
			// 
			// profilePanel
			// 
			profilePanel.BackgroundImage = (Image)resources.GetObject("profilePanel.BackgroundImage");
			profilePanel.BackgroundImageLayout = ImageLayout.Stretch;
			profilePanel.Controls.Add(PhoneTxt);
			profilePanel.Controls.Add(label10);
			profilePanel.Controls.Add(saveBtn);
			profilePanel.Controls.Add(AgeTxt);
			profilePanel.Controls.Add(AddressTxt);
			profilePanel.Controls.Add(EmailTxt);
			profilePanel.Controls.Add(PassTxt);
			profilePanel.Controls.Add(usernameTxt);
			profilePanel.Controls.Add(label5);
			profilePanel.Controls.Add(label4);
			profilePanel.Controls.Add(label3);
			profilePanel.Controls.Add(label2);
			profilePanel.Controls.Add(label1);
			profilePanel.Controls.Add(Edit);
			profilePanel.Location = new Point(203, 0);
			profilePanel.Name = "profilePanel";
			profilePanel.Size = new Size(904, 718);
			profilePanel.TabIndex = 0;
			// 
			// PhoneTxt
			// 
			PhoneTxt.BackColor = Color.MistyRose;
			PhoneTxt.ForeColor = Color.Black;
			PhoneTxt.Location = new Point(433, 469);
			PhoneTxt.Name = "PhoneTxt";
			PhoneTxt.Size = new Size(223, 27);
			PhoneTxt.TabIndex = 56;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.MistyRose;
			label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label10.ForeColor = Color.Sienna;
			label10.Location = new Point(220, 469);
			label10.Name = "label10";
			label10.Size = new Size(71, 28);
			label10.TabIndex = 55;
			label10.Text = "Phone";
			// 
			// saveBtn
			// 
			saveBtn.BackColor = Color.MistyRose;
			saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			saveBtn.ForeColor = Color.Sienna;
			saveBtn.Location = new Point(322, 562);
			saveBtn.Name = "saveBtn";
			saveBtn.Size = new Size(195, 48);
			saveBtn.TabIndex = 7;
			saveBtn.Text = "Save";
			saveBtn.UseVisualStyleBackColor = false;
			saveBtn.Click += saveBtn_Click;
			// 
			// AgeTxt
			// 
			AgeTxt.BackColor = Color.MistyRose;
			AgeTxt.ForeColor = Color.Black;
			AgeTxt.Location = new Point(433, 418);
			AgeTxt.Name = "AgeTxt";
			AgeTxt.Size = new Size(223, 27);
			AgeTxt.TabIndex = 12;
			// 
			// AddressTxt
			// 
			AddressTxt.BackColor = Color.MistyRose;
			AddressTxt.ForeColor = Color.Black;
			AddressTxt.Location = new Point(433, 364);
			AddressTxt.Name = "AddressTxt";
			AddressTxt.Size = new Size(223, 27);
			AddressTxt.TabIndex = 11;
			// 
			// EmailTxt
			// 
			EmailTxt.BackColor = Color.MistyRose;
			EmailTxt.ForeColor = Color.Black;
			EmailTxt.Location = new Point(433, 242);
			EmailTxt.Name = "EmailTxt";
			EmailTxt.Size = new Size(223, 27);
			EmailTxt.TabIndex = 10;
			// 
			// PassTxt
			// 
			PassTxt.BackColor = Color.MistyRose;
			PassTxt.ForeColor = Color.Black;
			PassTxt.Location = new Point(433, 300);
			PassTxt.Name = "PassTxt";
			PassTxt.Size = new Size(223, 27);
			PassTxt.TabIndex = 9;
			// 
			// usernameTxt
			// 
			usernameTxt.BackColor = Color.MistyRose;
			usernameTxt.ForeColor = Color.Black;
			usernameTxt.Location = new Point(433, 189);
			usernameTxt.Name = "usernameTxt";
			usernameTxt.Size = new Size(223, 27);
			usernameTxt.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.MistyRose;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.ForeColor = Color.Sienna;
			label5.Location = new Point(220, 418);
			label5.Name = "label5";
			label5.Size = new Size(49, 28);
			label5.TabIndex = 5;
			label5.Text = "Age";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.MistyRose;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.ForeColor = Color.Sienna;
			label4.Location = new Point(220, 364);
			label4.Name = "label4";
			label4.Size = new Size(87, 28);
			label4.TabIndex = 4;
			label4.Text = "Address";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.MistyRose;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.ForeColor = Color.Sienna;
			label3.Location = new Point(220, 307);
			label3.Name = "label3";
			label3.Size = new Size(101, 28);
			label3.TabIndex = 3;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.MistyRose;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = Color.Sienna;
			label2.Location = new Point(220, 249);
			label2.Name = "label2";
			label2.Size = new Size(64, 28);
			label2.TabIndex = 2;
			label2.Text = "Email";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.MistyRose;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = Color.Sienna;
			label1.Location = new Point(220, 189);
			label1.Name = "label1";
			label1.Size = new Size(106, 28);
			label1.TabIndex = 1;
			label1.Text = "Username";
			// 
			// Edit
			// 
			Edit.AutoSize = true;
			Edit.BackColor = Color.MistyRose;
			Edit.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Edit.ForeColor = Color.Sienna;
			Edit.Location = new Point(322, 72);
			Edit.Name = "Edit";
			Edit.Size = new Size(209, 58);
			Edit.TabIndex = 0;
			Edit.Text = "Edit Profile";
			// 
			// UserForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1107, 718);
			Controls.Add(PrdFP);
			Controls.Add(panel1);
			Controls.Add(profilePanel);
			Name = "UserForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "UserForm";
			Load += UserForm_Load;
			panel1.ResumeLayout(false);
			nav.ResumeLayout(false);
			profilePanel.ResumeLayout(false);
			profilePanel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel panel1;
		private Panel nav;
		private Button LogoutBtn;
		private Button FavBtn;
		private Button profileBtn;
		private Button ProductBtn;
		private Panel panel2;
		private FlowLayoutPanel PrdFP;
		private Panel profilePanel;
		private Label Edit;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox AgeTxt;
		private TextBox AddressTxt;
		private TextBox EmailTxt;
		private TextBox PassTxt;
		private TextBox usernameTxt;
		private Button saveBtn;
		private TextBox PhoneTxt;
		private Label label10;
	}
}