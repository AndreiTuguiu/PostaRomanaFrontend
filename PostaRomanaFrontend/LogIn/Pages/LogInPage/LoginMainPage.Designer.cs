
using System.Windows.Forms;

namespace PostaRomana.LogIn
{
    partial class LoginMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMainPage));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_login_LogInButton = new System.Windows.Forms.Button();
            this.checkbox_login_rememberPassword = new System.Windows.Forms.CheckBox();
            this.label_login_username = new System.Windows.Forms.Label();
            this.label_login_password = new System.Windows.Forms.Label();
            this.label_login_WelcomeBack = new System.Windows.Forms.Label();
            this.label_login_WelcomeSubtitle = new System.Windows.Forms.Label();
            this.label_login_dontHaveAccount = new System.Windows.Forms.Label();
            this.label_login_invalidUsername = new System.Windows.Forms.Label();
            this.linkLabel_signUp = new System.Windows.Forms.LinkLabel();
            this.linkLabel_forgotPassword = new System.Windows.Forms.LinkLabel();
            this.label_login_placeholderSuccessfullyLoggedIn = new System.Windows.Forms.Label();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_login_showPassword = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.textBox1.Location = new System.Drawing.Point(699, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.textBox2.Location = new System.Drawing.Point(699, 527);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(389, 32);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // bt_login_LogInButton
            // 
            this.bt_login_LogInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_login_LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.bt_login_LogInButton.FlatAppearance.BorderSize = 3;
            this.bt_login_LogInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_login_LogInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_login_LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login_LogInButton.Font = new System.Drawing.Font("Impact", 14F);
            this.bt_login_LogInButton.Location = new System.Drawing.Point(811, 686);
            this.bt_login_LogInButton.Name = "bt_login_LogInButton";
            this.bt_login_LogInButton.Size = new System.Drawing.Size(164, 80);
            this.bt_login_LogInButton.TabIndex = 7;
            this.bt_login_LogInButton.Text = "Log In";
            this.bt_login_LogInButton.UseVisualStyleBackColor = true;
            this.bt_login_LogInButton.Click += new System.EventHandler(this.bt_login_LogInButton_Click);
            // 
            // checkbox_login_rememberPassword
            // 
            this.checkbox_login_rememberPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkbox_login_rememberPassword.AutoSize = true;
            this.checkbox_login_rememberPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_login_rememberPassword.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.checkbox_login_rememberPassword.Location = new System.Drawing.Point(701, 567);
            this.checkbox_login_rememberPassword.Name = "checkbox_login_rememberPassword";
            this.checkbox_login_rememberPassword.Size = new System.Drawing.Size(231, 26);
            this.checkbox_login_rememberPassword.TabIndex = 4;
            this.checkbox_login_rememberPassword.Text = "Remember my password";
            this.checkbox_login_rememberPassword.UseVisualStyleBackColor = false;
            this.checkbox_login_rememberPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkbox_login_rememberPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkbox_login_rememberPassword_KeyDown);
            // 
            // label_login_username
            // 
            this.label_login_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_username.AutoSize = true;
            this.label_login_username.BackColor = System.Drawing.Color.Transparent;
            this.label_login_username.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label_login_username.ForeColor = System.Drawing.Color.Indigo;
            this.label_login_username.Location = new System.Drawing.Point(699, 436);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(119, 26);
            this.label_login_username.TabIndex = 4;
            this.label_login_username.Text = "Username:";
            this.label_login_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_login_password
            // 
            this.label_login_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_password.AutoSize = true;
            this.label_login_password.BackColor = System.Drawing.Color.Transparent;
            this.label_login_password.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label_login_password.ForeColor = System.Drawing.Color.Indigo;
            this.label_login_password.Location = new System.Drawing.Point(704, 498);
            this.label_login_password.Name = "label_login_password";
            this.label_login_password.Size = new System.Drawing.Size(112, 26);
            this.label_login_password.TabIndex = 6;
            this.label_login_password.Text = "Password:";
            this.label_login_password.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_login_WelcomeBack
            // 
            this.label_login_WelcomeBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_WelcomeBack.AutoSize = true;
            this.label_login_WelcomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label_login_WelcomeBack.Location = new System.Drawing.Point(748, 309);
            this.label_login_WelcomeBack.Name = "label_login_WelcomeBack";
            this.label_login_WelcomeBack.Size = new System.Drawing.Size(439, 69);
            this.label_login_WelcomeBack.TabIndex = 7;
            this.label_login_WelcomeBack.Text = "Welcome back!";
            this.label_login_WelcomeBack.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_login_WelcomeSubtitle
            // 
            this.label_login_WelcomeSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_WelcomeSubtitle.AutoSize = true;
            this.label_login_WelcomeSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.label_login_WelcomeSubtitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold);
            this.label_login_WelcomeSubtitle.ForeColor = System.Drawing.Color.Indigo;
            this.label_login_WelcomeSubtitle.Location = new System.Drawing.Point(555, 381);
            this.label_login_WelcomeSubtitle.Name = "label_login_WelcomeSubtitle";
            this.label_login_WelcomeSubtitle.Size = new System.Drawing.Size(884, 41);
            this.label_login_WelcomeSubtitle.TabIndex = 8;
            this.label_login_WelcomeSubtitle.Text = "Log in to access thousands of events around the world";
            this.label_login_WelcomeSubtitle.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label_login_dontHaveAccount
            // 
            this.label_login_dontHaveAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_dontHaveAccount.AutoSize = true;
            this.label_login_dontHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_login_dontHaveAccount.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label_login_dontHaveAccount.Location = new System.Drawing.Point(758, 645);
            this.label_login_dontHaveAccount.Name = "label_login_dontHaveAccount";
            this.label_login_dontHaveAccount.Size = new System.Drawing.Size(191, 22);
            this.label_login_dontHaveAccount.TabIndex = 9;
            this.label_login_dontHaveAccount.Text = "Don\'t have an account?";
            // 
            // label_login_invalidUsername
            // 
            this.label_login_invalidUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_invalidUsername.AutoSize = true;
            this.label_login_invalidUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_login_invalidUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_login_invalidUsername.ForeColor = System.Drawing.Color.Red;
            this.label_login_invalidUsername.Location = new System.Drawing.Point(749, 600);
            this.label_login_invalidUsername.Name = "label_login_invalidUsername";
            this.label_login_invalidUsername.Size = new System.Drawing.Size(326, 26);
            this.label_login_invalidUsername.TabIndex = 12;
            this.label_login_invalidUsername.Text = "Invalid username or password.";
            this.label_login_invalidUsername.Visible = false;
            this.label_login_invalidUsername.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // linkLabel_signUp
            // 
            this.linkLabel_signUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_signUp.AutoSize = true;
            this.linkLabel_signUp.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_signUp.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel_signUp.Location = new System.Drawing.Point(979, 641);
            this.linkLabel_signUp.Name = "linkLabel_signUp";
            this.linkLabel_signUp.Size = new System.Drawing.Size(99, 27);
            this.linkLabel_signUp.TabIndex = 6;
            this.linkLabel_signUp.TabStop = true;
            this.linkLabel_signUp.Text = "Sign Up.";
            this.linkLabel_signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_signUp_LinkClicked);
            // 
            // linkLabel_forgotPassword
            // 
            this.linkLabel_forgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_forgotPassword.AutoSize = true;
            this.linkLabel_forgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_forgotPassword.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel_forgotPassword.Location = new System.Drawing.Point(953, 568);
            this.linkLabel_forgotPassword.Name = "linkLabel_forgotPassword";
            this.linkLabel_forgotPassword.Size = new System.Drawing.Size(257, 27);
            this.linkLabel_forgotPassword.TabIndex = 5;
            this.linkLabel_forgotPassword.TabStop = true;
            this.linkLabel_forgotPassword.Text = "Forgot your password?";
            this.linkLabel_forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgotPassword_LinkClicked);
            // 
            // label_login_placeholderSuccessfullyLoggedIn
            // 
            this.label_login_placeholderSuccessfullyLoggedIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_placeholderSuccessfullyLoggedIn.AutoSize = true;
            this.label_login_placeholderSuccessfullyLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.label_login_placeholderSuccessfullyLoggedIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_login_placeholderSuccessfullyLoggedIn.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_login_placeholderSuccessfullyLoggedIn.Location = new System.Drawing.Point(806, 601);
            this.label_login_placeholderSuccessfullyLoggedIn.Name = "label_login_placeholderSuccessfullyLoggedIn";
            this.label_login_placeholderSuccessfullyLoggedIn.Size = new System.Drawing.Size(184, 26);
            this.label_login_placeholderSuccessfullyLoggedIn.TabIndex = 16;
            this.label_login_placeholderSuccessfullyLoggedIn.Text = "Login successful.";
            this.label_login_placeholderSuccessfullyLoggedIn.Visible = false;
            this.label_login_placeholderSuccessfullyLoggedIn.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.label_login_WelcomeSubtitle);
            this.gradientPanel1.Controls.Add(this.textBox1);
            this.gradientPanel1.Controls.Add(this.bt_login_LogInButton);
            this.gradientPanel1.Controls.Add(this.textBox2);
            this.gradientPanel1.Controls.Add(this.label_login_username);
            this.gradientPanel1.Controls.Add(this.checkbox_login_rememberPassword);
            this.gradientPanel1.Controls.Add(this.label_login_password);
            this.gradientPanel1.Controls.Add(this.label_login_placeholderSuccessfullyLoggedIn);
            this.gradientPanel1.Controls.Add(this.label_login_dontHaveAccount);
            this.gradientPanel1.Controls.Add(this.button_login_showPassword);
            this.gradientPanel1.Controls.Add(this.label_login_invalidUsername);
            this.gradientPanel1.Controls.Add(this.linkLabel_forgotPassword);
            this.gradientPanel1.Controls.Add(this.linkLabel_signUp);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.gradientPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, -17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1923, 100);
            this.panel1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1814, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button_login_showPassword
            // 
            this.button_login_showPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login_showPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_login_showPassword.BackgroundImage")));
            this.button_login_showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_login_showPassword.FlatAppearance.BorderSize = 0;
            this.button_login_showPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_login_showPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_login_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login_showPassword.Location = new System.Drawing.Point(1093, 523);
            this.button_login_showPassword.Name = "button_login_showPassword";
            this.button_login_showPassword.Size = new System.Drawing.Size(43, 36);
            this.button_login_showPassword.TabIndex = 3;
            this.button_login_showPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_login_showPassword.UseVisualStyleBackColor = true;
            this.button_login_showPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.label_login_WelcomeBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginMainPage";
            this.Text = "Event App - Log In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginMainPage_Load);
            this.Click += new System.EventHandler(this.LoginMainPage_Click);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_login_LogInButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkbox_login_rememberPassword;
        private System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.Label label_login_password;
        
        private System.Windows.Forms.Label label_login_WelcomeBack;
        private System.Windows.Forms.Label label_login_WelcomeSubtitle;
        private System.Windows.Forms.Label label_login_dontHaveAccount;
        private System.Windows.Forms.Label label_login_invalidUsername;
        private System.Windows.Forms.LinkLabel linkLabel_signUp;
        private System.Windows.Forms.LinkLabel linkLabel_forgotPassword;
        private System.Windows.Forms.Label label_login_placeholderSuccessfullyLoggedIn;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private Button button_login_showPassword;
        private Panel panel1;
        private Button button1;
    }
}