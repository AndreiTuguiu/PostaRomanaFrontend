
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
            this.label_passRecSucc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_recover_sendCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_passRecSucc
            // 
            this.label_passRecSucc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_passRecSucc.BackColor = System.Drawing.Color.Transparent;
            this.label_passRecSucc.Font = new System.Drawing.Font("Berlin Sans FB Demi", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_passRecSucc.ForeColor = System.Drawing.Color.Indigo;
            this.label_passRecSucc.Location = new System.Drawing.Point(605, 303);
            this.label_passRecSucc.Name = "label_passRecSucc";
            this.label_passRecSucc.Size = new System.Drawing.Size(750, 116);
            this.label_passRecSucc.TabIndex = 4;
            this.label_passRecSucc.Text = "Please insert below the five digit code we sent to your email.";
            this.label_passRecSucc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_passRecSucc.Click += new System.EventHandler(this.label_passRecSucc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(807, 443);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 43);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // bt_recover_sendCode
            // 
            this.bt_recover_sendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_recover_sendCode.BackColor = System.Drawing.Color.Transparent;
            this.bt_recover_sendCode.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.bt_recover_sendCode.FlatAppearance.BorderSize = 3;
            this.bt_recover_sendCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_recover_sendCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_recover_sendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_recover_sendCode.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_recover_sendCode.Location = new System.Drawing.Point(890, 566);
            this.bt_recover_sendCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_recover_sendCode.Name = "bt_recover_sendCode";
            this.bt_recover_sendCode.Size = new System.Drawing.Size(166, 62);
            this.bt_recover_sendCode.TabIndex = 6;
            this.bt_recover_sendCode.Text = "Verify";
            this.bt_recover_sendCode.UseVisualStyleBackColor = false;
            this.bt_recover_sendCode.Click += new System.EventHandler(this.bt_recover_sendCode_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(807, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "*The token is not valid.";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.label_passRecSucc);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.textBox1);
            this.gradientPanel1.Controls.Add(this.bt_recover_sendCode);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1898, 1024);
            this.gradientPanel1.TabIndex = 8;
            // 
            // PasswordRecoveredSuccessfullyPageCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordRecoveredSuccessfullyPageCode";
            this.Text = "PasswordRecoveredSuccessfullyPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PasswordRecoveredSuccessfullyPageCode_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_passRecSucc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_recover_sendCode;
        private System.Windows.Forms.Label label1;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
    }
}