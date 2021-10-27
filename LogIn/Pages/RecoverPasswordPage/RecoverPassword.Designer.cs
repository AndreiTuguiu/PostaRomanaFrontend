
using System.Windows.Forms;

namespace PostaRomana.RecoverPasswordPage
{
    partial class RecoverPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPassword));
            this.InsertEmailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_login_username = new System.Windows.Forms.Label();
            this.label_recover_invalidEmail = new System.Windows.Forms.Label();
            this.bt_recover_sendCode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertEmailLabel
            // 
            this.InsertEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertEmailLabel.Location = new System.Drawing.Point(94, 81);
            this.InsertEmailLabel.Name = "InsertEmailLabel";
            this.InsertEmailLabel.Size = new System.Drawing.Size(766, 218);
            this.InsertEmailLabel.TabIndex = 0;
            this.InsertEmailLabel.Text = "Insert the email associated to your account below and we will send you a password" +
    " recovery code.";
            this.InsertEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertEmailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_login_username
            // 
            this.label_login_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_username.AutoSize = true;
            this.label_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login_username.Location = new System.Drawing.Point(258, 282);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(66, 25);
            this.label_login_username.TabIndex = 5;
            this.label_login_username.Text = "Email:";
            this.label_login_username.Click += new System.EventHandler(this.label_login_username_Click);
            // 
            // label_recover_invalidEmail
            // 
            this.label_recover_invalidEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_recover_invalidEmail.AutoSize = true;
            this.label_recover_invalidEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_recover_invalidEmail.ForeColor = System.Drawing.Color.Red;
            this.label_recover_invalidEmail.Location = new System.Drawing.Point(400, 371);
            this.label_recover_invalidEmail.Name = "label_recover_invalidEmail";
            this.label_recover_invalidEmail.Size = new System.Drawing.Size(124, 25);
            this.label_recover_invalidEmail.TabIndex = 13;
            this.label_recover_invalidEmail.Text = "Invalid email.";
            this.label_recover_invalidEmail.Visible = false;
            // 
            // bt_recover_sendCode
            // 
            this.bt_recover_sendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_recover_sendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_recover_sendCode.Location = new System.Drawing.Point(343, 438);
            this.bt_recover_sendCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_recover_sendCode.Name = "bt_recover_sendCode";
            this.bt_recover_sendCode.Size = new System.Drawing.Size(257, 52);
            this.bt_recover_sendCode.TabIndex = 2;
            this.bt_recover_sendCode.Text = "Send recovery code";
            this.bt_recover_sendCode.UseVisualStyleBackColor = true;
            this.bt_recover_sendCode.Click += new System.EventHandler(this.bt_recover_sendCode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(260, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 31);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 668);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_recover_sendCode);
            this.Controls.Add(this.label_recover_invalidEmail);
            this.Controls.Add(this.label_login_username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InsertEmailLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecoverPassword";
            this.Text = "RecoverPassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsertEmailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.Label label_recover_invalidEmail;
        private System.Windows.Forms.Button bt_recover_sendCode;
        private TextBox textBox1;
        //this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
    }
}