
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
            this.recoverPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label_login_username = new System.Windows.Forms.Label();
            this.label_recover_invalidEmail = new System.Windows.Forms.Label();
            this.bt_recover_sendCode = new System.Windows.Forms.Button();
            this.label_passwordRecoverySuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertEmailLabel
            // 
            this.InsertEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertEmailLabel.Location = new System.Drawing.Point(85, 65);
            this.InsertEmailLabel.Name = "InsertEmailLabel";
            this.InsertEmailLabel.Size = new System.Drawing.Size(689, 174);
            this.InsertEmailLabel.TabIndex = 0;
            this.InsertEmailLabel.Text = "Insert the email associated to your account below and we will send you a password" +
    " recovery code.";
            this.InsertEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertEmailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // recoverPasswordTextBox
            // 
            this.recoverPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recoverPasswordTextBox.Location = new System.Drawing.Point(237, 254);
            this.recoverPasswordTextBox.Name = "recoverPasswordTextBox";
            this.recoverPasswordTextBox.Size = new System.Drawing.Size(389, 26);
            this.recoverPasswordTextBox.TabIndex = 1;
            this.recoverPasswordTextBox.TextChanged += new System.EventHandler(this.recoverPasswordTextBox_TextChanged);
            this.recoverPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.recoverPasswordTextBox_KeyDown);
            // 
            // label_login_username
            // 
            this.label_login_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_username.AutoSize = true;
            this.label_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_username.Location = new System.Drawing.Point(232, 226);
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
            this.label_recover_invalidEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recover_invalidEmail.ForeColor = System.Drawing.Color.Red;
            this.label_recover_invalidEmail.Location = new System.Drawing.Point(360, 297);
            this.label_recover_invalidEmail.Name = "label_recover_invalidEmail";
            this.label_recover_invalidEmail.Size = new System.Drawing.Size(124, 25);
            this.label_recover_invalidEmail.TabIndex = 13;
            this.label_recover_invalidEmail.Text = "Invalid email.";
            this.label_recover_invalidEmail.Visible = false;
            // 
            // bt_recover_sendCode
            // 
            this.bt_recover_sendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_recover_sendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_recover_sendCode.Location = new System.Drawing.Point(295, 343);
            this.bt_recover_sendCode.Name = "bt_recover_sendCode";
            this.bt_recover_sendCode.Size = new System.Drawing.Size(247, 50);
            this.bt_recover_sendCode.TabIndex = 2;
            this.bt_recover_sendCode.Text = "Send recovery code";
            this.bt_recover_sendCode.UseVisualStyleBackColor = true;
            this.bt_recover_sendCode.Click += new System.EventHandler(this.bt_recover_sendCode_Click);
            // 
            // label_passwordRecoverySuccess
            // 
            this.label_passwordRecoverySuccess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_passwordRecoverySuccess.AutoSize = true;
            this.label_passwordRecoverySuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passwordRecoverySuccess.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_passwordRecoverySuccess.Location = new System.Drawing.Point(232, 297);
            this.label_passwordRecoverySuccess.Name = "label_passwordRecoverySuccess";
            this.label_passwordRecoverySuccess.Size = new System.Drawing.Size(402, 25);
            this.label_passwordRecoverySuccess.TabIndex = 14;
            this.label_passwordRecoverySuccess.Text = "Success! A code has been sent to this email!";
            this.label_passwordRecoverySuccess.Visible = false;
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 534);
            this.Controls.Add(this.label_passwordRecoverySuccess);
            this.Controls.Add(this.bt_recover_sendCode);
            this.Controls.Add(this.label_recover_invalidEmail);
            this.Controls.Add(this.label_login_username);
            this.Controls.Add(this.recoverPasswordTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InsertEmailLabel);
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
        private System.Windows.Forms.TextBox recoverPasswordTextBox;
        private System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.Label label_recover_invalidEmail;
        private System.Windows.Forms.Button bt_recover_sendCode;
        private System.Windows.Forms.Label label_passwordRecoverySuccess;
        //this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
        }
}