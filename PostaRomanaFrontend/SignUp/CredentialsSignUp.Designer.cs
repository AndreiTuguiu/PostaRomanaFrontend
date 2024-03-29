﻿
namespace PostaRomana.SignUp
{
    partial class CredentialsSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialsSignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.bt_SignUp = new System.Windows.Forms.Button();
            this.cb_Agree = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_ShowPassword = new System.Windows.Forms.Button();
            this.lL_Terms = new System.Windows.Forms.LinkLabel();
            this.l_error_firstName = new System.Windows.Forms.Label();
            this.l_error_lastName = new System.Windows.Forms.Label();
            this.l_error_username = new System.Windows.Forms.Label();
            this.l_error_email = new System.Windows.Forms.Label();
            this.l_error_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up to get started";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_FirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_FirstName.Location = new System.Drawing.Point(191, 167);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(229, 26);
            this.tb_FirstName.TabIndex = 3;
            this.tb_FirstName.TextChanged += new System.EventHandler(this.tb_FirstName_TextChanged);
            // 
            // tb_LastName
            // 
            this.tb_LastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_LastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_LastName.Location = new System.Drawing.Point(463, 167);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(247, 26);
            this.tb_LastName.TabIndex = 4;
            this.tb_LastName.TextChanged += new System.EventHandler(this.tb_LastName_TextChanged);
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Username.Location = new System.Drawing.Point(743, 167);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(256, 26);
            this.tb_Username.TabIndex = 5;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Email.Location = new System.Drawing.Point(191, 270);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(262, 26);
            this.tb_Email.TabIndex = 6;
            this.tb_Email.TextChanged += new System.EventHandler(this.tb_Email_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Password.Location = new System.Drawing.Point(191, 364);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '•';
            this.tb_Password.Size = new System.Drawing.Size(262, 26);
            this.tb_Password.TabIndex = 7;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // bt_SignUp
            // 
            this.bt_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_SignUp.Enabled = false;
            this.bt_SignUp.Location = new System.Drawing.Point(463, 445);
            this.bt_SignUp.Name = "bt_SignUp";
            this.bt_SignUp.Size = new System.Drawing.Size(222, 80);
            this.bt_SignUp.TabIndex = 8;
            this.bt_SignUp.Text = "Sign up with email";
            this.bt_SignUp.UseVisualStyleBackColor = true;
            this.bt_SignUp.Click += new System.EventHandler(this.bt_SignUp_Click);
            // 
            // cb_Agree
            // 
            this.cb_Agree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Agree.AutoSize = true;
            this.cb_Agree.Location = new System.Drawing.Point(463, 557);
            this.cb_Agree.Name = "cb_Agree";
            this.cb_Agree.Size = new System.Drawing.Size(117, 24);
            this.cb_Agree.TabIndex = 9;
            this.cb_Agree.Text = "I agree with";
            this.cb_Agree.UseVisualStyleBackColor = true;
            this.cb_Agree.CheckedChanged += new System.EventHandler(this.cb_Agree_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // bt_ShowPassword
            // 
            this.bt_ShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_ShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ShowPassword.BackgroundImage")));
            this.bt_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ShowPassword.FlatAppearance.BorderSize = 0;
            this.bt_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ShowPassword.Location = new System.Drawing.Point(462, 359);
            this.bt_ShowPassword.Name = "bt_ShowPassword";
            this.bt_ShowPassword.Size = new System.Drawing.Size(46, 40);
            this.bt_ShowPassword.TabIndex = 15;
            this.bt_ShowPassword.UseVisualStyleBackColor = true;
            this.bt_ShowPassword.Click += new System.EventHandler(this.bt_ShowPassword_Click);
            // 
            // lL_Terms
            // 
            this.lL_Terms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lL_Terms.AutoSize = true;
            this.lL_Terms.Location = new System.Drawing.Point(574, 557);
            this.lL_Terms.Name = "lL_Terms";
            this.lL_Terms.Size = new System.Drawing.Size(163, 20);
            this.lL_Terms.TabIndex = 17;
            this.lL_Terms.TabStop = true;
            this.lL_Terms.Text = "Terms and Conditions";
            this.lL_Terms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lL_Terms_LinkClicked);
            // 
            // l_error_firstName
            // 
            this.l_error_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_error_firstName.AutoSize = true;
            this.l_error_firstName.ForeColor = System.Drawing.Color.Red;
            this.l_error_firstName.Location = new System.Drawing.Point(191, 201);
            this.l_error_firstName.Name = "l_error_firstName";
            this.l_error_firstName.Size = new System.Drawing.Size(0, 20);
            this.l_error_firstName.TabIndex = 18;
            // 
            // l_error_lastName
            // 
            this.l_error_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_error_lastName.AutoSize = true;
            this.l_error_lastName.ForeColor = System.Drawing.Color.Red;
            this.l_error_lastName.Location = new System.Drawing.Point(463, 202);
            this.l_error_lastName.Name = "l_error_lastName";
            this.l_error_lastName.Size = new System.Drawing.Size(0, 20);
            this.l_error_lastName.TabIndex = 19;
            // 
            // l_error_username
            // 
            this.l_error_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_error_username.AutoSize = true;
            this.l_error_username.ForeColor = System.Drawing.Color.Red;
            this.l_error_username.Location = new System.Drawing.Point(748, 205);
            this.l_error_username.Name = "l_error_username";
            this.l_error_username.Size = new System.Drawing.Size(0, 20);
            this.l_error_username.TabIndex = 20;
            // 
            // l_error_email
            // 
            this.l_error_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_error_email.AutoSize = true;
            this.l_error_email.ForeColor = System.Drawing.Color.Red;
            this.l_error_email.Location = new System.Drawing.Point(191, 305);
            this.l_error_email.Name = "l_error_email";
            this.l_error_email.Size = new System.Drawing.Size(0, 20);
            this.l_error_email.TabIndex = 21;
            // 
            // l_error_password
            // 
            this.l_error_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_error_password.AutoSize = true;
            this.l_error_password.ForeColor = System.Drawing.Color.Red;
            this.l_error_password.Location = new System.Drawing.Point(191, 400);
            this.l_error_password.Name = "l_error_password";
            this.l_error_password.Size = new System.Drawing.Size(0, 20);
            this.l_error_password.TabIndex = 22;
            // 
            // CredentialsSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 642);
            this.Controls.Add(this.l_error_password);
            this.Controls.Add(this.l_error_email);
            this.Controls.Add(this.l_error_username);
            this.Controls.Add(this.l_error_lastName);
            this.Controls.Add(this.l_error_firstName);
            this.Controls.Add(this.lL_Terms);
            this.Controls.Add(this.bt_ShowPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Agree);
            this.Controls.Add(this.bt_SignUp);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CredentialsSignUp";
            this.Text = "CredentialsSignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CredentialsSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button bt_SignUp;
        private System.Windows.Forms.CheckBox cb_Agree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_ShowPassword;
        private System.Windows.Forms.LinkLabel lL_Terms;
        private System.Windows.Forms.Label l_error_firstName;
        private System.Windows.Forms.Label l_error_lastName;
        private System.Windows.Forms.Label l_error_username;
        private System.Windows.Forms.Label l_error_email;
        private System.Windows.Forms.Label l_error_password;
    }
}