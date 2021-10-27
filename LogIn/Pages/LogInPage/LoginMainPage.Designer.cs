
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.button_login_showPassword = new System.Windows.Forms.Button();
            this.label_login_placeholderSuccessfullyLoggedIn = new System.Windows.Forms.Label();
            this.button_actuallogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogIn.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(323, 281);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(323, 349);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(432, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // bt_login_LogInButton
            // 
            this.bt_login_LogInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_login_LogInButton.Location = new System.Drawing.Point(464, 526);
            this.bt_login_LogInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_login_LogInButton.Name = "bt_login_LogInButton";
            this.bt_login_LogInButton.Size = new System.Drawing.Size(159, 62);
            this.bt_login_LogInButton.TabIndex = 7;
            this.bt_login_LogInButton.Text = "Log In";
            this.bt_login_LogInButton.UseVisualStyleBackColor = true;
            this.bt_login_LogInButton.Click += new System.EventHandler(this.bt_login_LogInButton_Click);
            // 
            // checkbox_login_rememberPassword
            // 
            this.checkbox_login_rememberPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkbox_login_rememberPassword.AutoSize = true;
            this.checkbox_login_rememberPassword.Location = new System.Drawing.Point(323, 389);
            this.checkbox_login_rememberPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkbox_login_rememberPassword.Name = "checkbox_login_rememberPassword";
            this.checkbox_login_rememberPassword.Size = new System.Drawing.Size(236, 29);
            this.checkbox_login_rememberPassword.TabIndex = 4;
            this.checkbox_login_rememberPassword.Text = "Remember my password";
            this.checkbox_login_rememberPassword.UseVisualStyleBackColor = true;
            this.checkbox_login_rememberPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkbox_login_rememberPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkbox_login_rememberPassword_KeyDown);
            // 
            // label_login_username
            // 
            this.label_login_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_username.AutoSize = true;
            this.label_login_username.Location = new System.Drawing.Point(323, 251);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(95, 25);
            this.label_login_username.TabIndex = 4;
            this.label_login_username.Text = "Username:";
            this.label_login_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_login_password
            // 
            this.label_login_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_password.AutoSize = true;
            this.label_login_password.Location = new System.Drawing.Point(328, 320);
            this.label_login_password.Name = "label_login_password";
            this.label_login_password.Size = new System.Drawing.Size(91, 25);
            this.label_login_password.TabIndex = 6;
            this.label_login_password.Text = "Password:";
            this.label_login_password.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_login_WelcomeBack
            // 
            this.label_login_WelcomeBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_WelcomeBack.AutoSize = true;
            this.label_login_WelcomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login_WelcomeBack.Location = new System.Drawing.Point(289, 56);
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
            this.label_login_WelcomeSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login_WelcomeSubtitle.Location = new System.Drawing.Point(126, 171);
            this.label_login_WelcomeSubtitle.Name = "label_login_WelcomeSubtitle";
            this.label_login_WelcomeSubtitle.Size = new System.Drawing.Size(746, 36);
            this.label_login_WelcomeSubtitle.TabIndex = 8;
            this.label_login_WelcomeSubtitle.Text = "Log in to access thousands of events around the world.";
            this.label_login_WelcomeSubtitle.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label_login_dontHaveAccount
            // 
            this.label_login_dontHaveAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_dontHaveAccount.AutoSize = true;
            this.label_login_dontHaveAccount.Location = new System.Drawing.Point(388, 471);
            this.label_login_dontHaveAccount.Name = "label_login_dontHaveAccount";
            this.label_login_dontHaveAccount.Size = new System.Drawing.Size(193, 25);
            this.label_login_dontHaveAccount.TabIndex = 9;
            this.label_login_dontHaveAccount.Text = "Dont have an account?";
            // 
            // label_login_invalidUsername
            // 
            this.label_login_invalidUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_invalidUsername.AutoSize = true;
            this.label_login_invalidUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login_invalidUsername.ForeColor = System.Drawing.Color.Red;
            this.label_login_invalidUsername.Location = new System.Drawing.Point(378, 428);
            this.label_login_invalidUsername.Name = "label_login_invalidUsername";
            this.label_login_invalidUsername.Size = new System.Drawing.Size(276, 25);
            this.label_login_invalidUsername.TabIndex = 12;
            this.label_login_invalidUsername.Text = "Invalid username or password.";
            this.label_login_invalidUsername.Visible = false;
            this.label_login_invalidUsername.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // linkLabel_signUp
            // 
            this.linkLabel_signUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_signUp.AutoSize = true;
            this.linkLabel_signUp.Location = new System.Drawing.Point(588, 471);
            this.linkLabel_signUp.Name = "linkLabel_signUp";
            this.linkLabel_signUp.Size = new System.Drawing.Size(79, 25);
            this.linkLabel_signUp.TabIndex = 6;
            this.linkLabel_signUp.TabStop = true;
            this.linkLabel_signUp.Text = "Sign Up.";
            // 
            // linkLabel_forgotPassword
            // 
            this.linkLabel_forgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_forgotPassword.AutoSize = true;
            this.linkLabel_forgotPassword.Location = new System.Drawing.Point(569, 390);
            this.linkLabel_forgotPassword.Name = "linkLabel_forgotPassword";
            this.linkLabel_forgotPassword.Size = new System.Drawing.Size(197, 25);
            this.linkLabel_forgotPassword.TabIndex = 5;
            this.linkLabel_forgotPassword.TabStop = true;
            this.linkLabel_forgotPassword.Text = "Forgot your password?";
            this.linkLabel_forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgotPassword_LinkClicked);
            // 
            // button_login_showPassword
            // 
            this.button_login_showPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login_showPassword.BackgroundImage = global::LogIn.Properties.Resources.showpasgrey;
            this.button_login_showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_login_showPassword.FlatAppearance.BorderSize = 0;
            this.button_login_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login_showPassword.Location = new System.Drawing.Point(761, 352);
            this.button_login_showPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_login_showPassword.Name = "button_login_showPassword";
            this.button_login_showPassword.Size = new System.Drawing.Size(36, 25);
            this.button_login_showPassword.TabIndex = 3;
            this.button_login_showPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_login_showPassword.UseVisualStyleBackColor = true;
            this.button_login_showPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_login_placeholderSuccessfullyLoggedIn
            // 
            this.label_login_placeholderSuccessfullyLoggedIn.AutoSize = true;
            this.label_login_placeholderSuccessfullyLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login_placeholderSuccessfullyLoggedIn.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_login_placeholderSuccessfullyLoggedIn.Location = new System.Drawing.Point(443, 430);
            this.label_login_placeholderSuccessfullyLoggedIn.Name = "label_login_placeholderSuccessfullyLoggedIn";
            this.label_login_placeholderSuccessfullyLoggedIn.Size = new System.Drawing.Size(162, 25);
            this.label_login_placeholderSuccessfullyLoggedIn.TabIndex = 16;
            this.label_login_placeholderSuccessfullyLoggedIn.Text = "Login successful.";
            this.label_login_placeholderSuccessfullyLoggedIn.Visible = false;
            this.label_login_placeholderSuccessfullyLoggedIn.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // button_actuallogin
            // 
            this.button_actuallogin.Location = new System.Drawing.Point(70, 490);
            this.button_actuallogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_actuallogin.Name = "button_actuallogin";
            this.button_actuallogin.Size = new System.Drawing.Size(236, 99);
            this.button_actuallogin.TabIndex = 17;
            this.button_actuallogin.Text = "actual login";
            this.button_actuallogin.UseVisualStyleBackColor = true;
            this.button_actuallogin.Click += new System.EventHandler(this.button_actuallogin_Click);
            // 
            // LoginMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 692);
            this.Controls.Add(this.button_actuallogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkbox_login_rememberPassword);
            this.Controls.Add(this.label_login_placeholderSuccessfullyLoggedIn);
            this.Controls.Add(this.button_login_showPassword);
            this.Controls.Add(this.linkLabel_forgotPassword);
            this.Controls.Add(this.linkLabel_signUp);
            this.Controls.Add(this.label_login_invalidUsername);
            this.Controls.Add(this.label_login_dontHaveAccount);
            this.Controls.Add(this.label_login_WelcomeSubtitle);
            this.Controls.Add(this.label_login_WelcomeBack);
            this.Controls.Add(this.label_login_password);
            this.Controls.Add(this.label_login_username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_login_LogInButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginMainPage";
            this.Text = "Event App - Log In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginMainPage_Load);
            this.Click += new System.EventHandler(this.LoginMainPage_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_login_LogInButton;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Button button_login_showPassword;
        private System.Windows.Forms.Label label_login_placeholderSuccessfullyLoggedIn;
        private Button button_actuallogin;
    }
}