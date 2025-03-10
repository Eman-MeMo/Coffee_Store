namespace Presentation_Layer
{
	partial class RegisterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			loginPanel = new Panel();
			registPanel = new Panel();
			PhoneTxt = new TextBox();
			label10 = new Label();
			label6 = new Label();
			loginLinkBtn = new Button();
			RegisterBtn = new Button();
			AgeTxt = new TextBox();
			AddressTxt = new TextBox();
			EmailTxt = new TextBox();
			PassTxt = new TextBox();
			usernameTxt = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			registerLinkBtn = new Button();
			LoginBtn = new Button();
			label1 = new Label();
			passTextBox = new TextBox();
			emailTextBox = new TextBox();
			label3 = new Label();
			label2 = new Label();
			loginPanel.SuspendLayout();
			registPanel.SuspendLayout();
			SuspendLayout();
			// 
			// loginPanel
			// 
			loginPanel.BackgroundImage = (Image)resources.GetObject("loginPanel.BackgroundImage");
			loginPanel.BackgroundImageLayout = ImageLayout.Stretch;
			loginPanel.Controls.Add(registPanel);
			loginPanel.Controls.Add(registerLinkBtn);
			loginPanel.Controls.Add(LoginBtn);
			loginPanel.Controls.Add(label1);
			loginPanel.Controls.Add(passTextBox);
			loginPanel.Controls.Add(emailTextBox);
			loginPanel.Controls.Add(label3);
			loginPanel.Controls.Add(label2);
			loginPanel.Dock = DockStyle.Fill;
			loginPanel.Location = new Point(0, 0);
			loginPanel.Name = "loginPanel";
			loginPanel.Size = new Size(1107, 718);
			loginPanel.TabIndex = 0;
			// 
			// registPanel
			// 
			registPanel.BackgroundImage = (Image)resources.GetObject("registPanel.BackgroundImage");
			registPanel.BackgroundImageLayout = ImageLayout.Stretch;
			registPanel.Controls.Add(PhoneTxt);
			registPanel.Controls.Add(label10);
			registPanel.Controls.Add(label6);
			registPanel.Controls.Add(loginLinkBtn);
			registPanel.Controls.Add(RegisterBtn);
			registPanel.Controls.Add(AgeTxt);
			registPanel.Controls.Add(AddressTxt);
			registPanel.Controls.Add(EmailTxt);
			registPanel.Controls.Add(PassTxt);
			registPanel.Controls.Add(usernameTxt);
			registPanel.Controls.Add(label5);
			registPanel.Controls.Add(label4);
			registPanel.Controls.Add(label7);
			registPanel.Controls.Add(label8);
			registPanel.Controls.Add(label9);
			registPanel.Dock = DockStyle.Fill;
			registPanel.Location = new Point(0, 0);
			registPanel.Name = "registPanel";
			registPanel.Size = new Size(1107, 718);
			registPanel.TabIndex = 57;
			registPanel.Visible = false;
			registPanel.Paint += registPanel_Paint;
			// 
			// PhoneTxt
			// 
			PhoneTxt.BackColor = Color.MistyRose;
			PhoneTxt.ForeColor = Color.Black;
			PhoneTxt.Location = new Point(333, 460);
			PhoneTxt.Name = "PhoneTxt";
			PhoneTxt.Size = new Size(223, 27);
			PhoneTxt.TabIndex = 54;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.MistyRose;
			label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label10.ForeColor = Color.Sienna;
			label10.Location = new Point(120, 460);
			label10.Name = "label10";
			label10.Size = new Size(71, 28);
			label10.TabIndex = 53;
			label10.Text = "Phone";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Sitka Banner", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(94, 28);
			label6.Name = "label6";
			label6.Size = new Size(535, 62);
			label6.TabIndex = 52;
			label6.Text = "Welcome To Our Coffee Store";
			// 
			// loginLinkBtn
			// 
			loginLinkBtn.BackColor = Color.MistyRose;
			loginLinkBtn.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			loginLinkBtn.ForeColor = Color.Sienna;
			loginLinkBtn.Location = new Point(136, 624);
			loginLinkBtn.Name = "loginLinkBtn";
			loginLinkBtn.Size = new Size(316, 48);
			loginLinkBtn.TabIndex = 26;
			loginLinkBtn.Text = "Already Have Account?   Login";
			loginLinkBtn.UseVisualStyleBackColor = false;
			loginLinkBtn.Click += loginLinkBtn_Click;
			// 
			// RegisterBtn
			// 
			RegisterBtn.BackColor = Color.MistyRose;
			RegisterBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			RegisterBtn.ForeColor = Color.Sienna;
			RegisterBtn.Location = new Point(193, 532);
			RegisterBtn.Name = "RegisterBtn";
			RegisterBtn.Size = new Size(195, 48);
			RegisterBtn.TabIndex = 25;
			RegisterBtn.Text = "Register";
			RegisterBtn.UseVisualStyleBackColor = false;
			RegisterBtn.Click += RegisterBtn_Click;
			// 
			// AgeTxt
			// 
			AgeTxt.BackColor = Color.MistyRose;
			AgeTxt.ForeColor = Color.Black;
			AgeTxt.Location = new Point(333, 398);
			AgeTxt.Name = "AgeTxt";
			AgeTxt.Size = new Size(223, 27);
			AgeTxt.TabIndex = 24;
			// 
			// AddressTxt
			// 
			AddressTxt.BackColor = Color.MistyRose;
			AddressTxt.ForeColor = Color.Black;
			AddressTxt.Location = new Point(333, 344);
			AddressTxt.Name = "AddressTxt";
			AddressTxt.Size = new Size(223, 27);
			AddressTxt.TabIndex = 23;
			// 
			// EmailTxt
			// 
			EmailTxt.BackColor = Color.MistyRose;
			EmailTxt.ForeColor = Color.Black;
			EmailTxt.Location = new Point(333, 222);
			EmailTxt.Name = "EmailTxt";
			EmailTxt.Size = new Size(223, 27);
			EmailTxt.TabIndex = 22;
			// 
			// PassTxt
			// 
			PassTxt.BackColor = Color.MistyRose;
			PassTxt.ForeColor = Color.Black;
			PassTxt.Location = new Point(333, 280);
			PassTxt.Name = "PassTxt";
			PassTxt.Size = new Size(223, 27);
			PassTxt.TabIndex = 21;
			// 
			// usernameTxt
			// 
			usernameTxt.BackColor = Color.MistyRose;
			usernameTxt.ForeColor = Color.Black;
			usernameTxt.Location = new Point(333, 169);
			usernameTxt.Name = "usernameTxt";
			usernameTxt.Size = new Size(223, 27);
			usernameTxt.TabIndex = 20;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.MistyRose;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.ForeColor = Color.Sienna;
			label5.Location = new Point(120, 398);
			label5.Name = "label5";
			label5.Size = new Size(49, 28);
			label5.TabIndex = 18;
			label5.Text = "Age";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.MistyRose;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.ForeColor = Color.Sienna;
			label4.Location = new Point(120, 344);
			label4.Name = "label4";
			label4.Size = new Size(87, 28);
			label4.TabIndex = 17;
			label4.Text = "Address";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.MistyRose;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label7.ForeColor = Color.Sienna;
			label7.Location = new Point(120, 287);
			label7.Name = "label7";
			label7.Size = new Size(101, 28);
			label7.TabIndex = 16;
			label7.Text = "Password";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.MistyRose;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label8.ForeColor = Color.Sienna;
			label8.Location = new Point(120, 229);
			label8.Name = "label8";
			label8.Size = new Size(64, 28);
			label8.TabIndex = 15;
			label8.Text = "Email";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.MistyRose;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label9.ForeColor = Color.Sienna;
			label9.Location = new Point(120, 169);
			label9.Name = "label9";
			label9.Size = new Size(106, 28);
			label9.TabIndex = 14;
			label9.Text = "Username";
			// 
			// registerLinkBtn
			// 
			registerLinkBtn.BackColor = Color.MistyRose;
			registerLinkBtn.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			registerLinkBtn.ForeColor = Color.Sienna;
			registerLinkBtn.Location = new Point(423, 513);
			registerLinkBtn.Name = "registerLinkBtn";
			registerLinkBtn.Size = new Size(263, 45);
			registerLinkBtn.TabIndex = 56;
			registerLinkBtn.Text = "New Account?   Register";
			registerLinkBtn.UseVisualStyleBackColor = false;
			registerLinkBtn.Click += registerLinkBtn_Click;
			// 
			// LoginBtn
			// 
			LoginBtn.BackColor = Color.MistyRose;
			LoginBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LoginBtn.ForeColor = Color.Sienna;
			LoginBtn.Location = new Point(461, 355);
			LoginBtn.Name = "LoginBtn";
			LoginBtn.Size = new Size(170, 40);
			LoginBtn.TabIndex = 54;
			LoginBtn.Text = "Login";
			LoginBtn.UseVisualStyleBackColor = false;
			LoginBtn.Click += LoginBtn_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Sitka Banner", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(297, 59);
			label1.Name = "label1";
			label1.Size = new Size(535, 62);
			label1.TabIndex = 51;
			label1.Text = "Welcome To Our Coffee Store";
			// 
			// passTextBox
			// 
			passTextBox.BackColor = Color.MistyRose;
			passTextBox.Location = new Point(559, 260);
			passTextBox.Name = "passTextBox";
			passTextBox.Size = new Size(170, 27);
			passTextBox.TabIndex = 50;
			// 
			// emailTextBox
			// 
			emailTextBox.BackColor = Color.MistyRose;
			emailTextBox.Location = new Point(559, 197);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(170, 27);
			emailTextBox.TabIndex = 49;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.MistyRose;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.ForeColor = Color.Sienna;
			label3.Location = new Point(376, 197);
			label3.Name = "label3";
			label3.Size = new Size(64, 28);
			label3.TabIndex = 48;
			label3.Text = "Email";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.MistyRose;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = Color.Sienna;
			label2.Location = new Point(376, 260);
			label2.Name = "label2";
			label2.Size = new Size(101, 28);
			label2.TabIndex = 47;
			label2.Text = "Password";
			// 
			// RegisterForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1107, 718);
			Controls.Add(loginPanel);
			Name = "RegisterForm";
			Text = "RegisterForm";
			loginPanel.ResumeLayout(false);
			loginPanel.PerformLayout();
			registPanel.ResumeLayout(false);
			registPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel loginPanel;
		private Button LoginBtn;
		private Label label1;
		private TextBox passTextBox;
		private TextBox emailTextBox;
		private Label label3;
		private Label label2;
		private Panel registPanel;
		private Button registerLinkBtn;
		private TextBox AgeTxt;
		private TextBox AddressTxt;
		private TextBox EmailTxt;
		private TextBox PassTxt;
		private TextBox usernameTxt;
		private Label label5;
		private Label label4;
		private Label label7;
		private Label label8;
		private Label label9;
		private Button loginLinkBtn;
		private Button RegisterBtn;
		private Label label6;
		private TextBox PhoneTxt;
		private Label label10;
	}
}