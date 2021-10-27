
namespace LogIn.Pages.PasswordRecoveredSuccessfullyPage
{
    partial class PasswordRecoveredSuccessfullyPageCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecoveredSuccessfullyPageCode));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_passRecSucc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_recover_sendCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_passRecSucc
            // 
            this.label_passRecSucc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_passRecSucc.BackColor = System.Drawing.Color.Transparent;
            this.label_passRecSucc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_passRecSucc.Location = new System.Drawing.Point(113, 99);
            this.label_passRecSucc.Name = "label_passRecSucc";
            this.label_passRecSucc.Size = new System.Drawing.Size(750, 116);
            this.label_passRecSucc.TabIndex = 4;
            this.label_passRecSucc.Text = "Sucess! Please insert below the five digit code we sent to your email.";
            this.label_passRecSucc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_passRecSucc.Click += new System.EventHandler(this.label_passRecSucc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(360, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 50);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // bt_recover_sendCode
            // 
            this.bt_recover_sendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_recover_sendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_recover_sendCode.Location = new System.Drawing.Point(398, 362);
            this.bt_recover_sendCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_recover_sendCode.Name = "bt_recover_sendCode";
            this.bt_recover_sendCode.Size = new System.Drawing.Size(166, 62);
            this.bt_recover_sendCode.TabIndex = 6;
            this.bt_recover_sendCode.Text = "Verify";
            this.bt_recover_sendCode.UseVisualStyleBackColor = true;
            this.bt_recover_sendCode.Click += new System.EventHandler(this.bt_recover_sendCode_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "The token is not valid.";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordRecoveredSuccessfullyPageCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_recover_sendCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_passRecSucc);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PasswordRecoveredSuccessfullyPageCode";
            this.Text = "PasswordRecoveredSuccessfullyPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_passRecSucc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_recover_sendCode;
        private System.Windows.Forms.Label label1;
    }
}