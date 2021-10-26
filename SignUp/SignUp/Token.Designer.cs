
namespace PostaRomanaFrontend.SignUp
{
    partial class Token
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Token = new System.Windows.Forms.TextBox();
            this.bt_Register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, insert your Token here!";
            // 
            // tb_Token
            // 
            this.tb_Token.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Token.Location = new System.Drawing.Point(296, 190);
            this.tb_Token.Name = "tb_Token";
            this.tb_Token.Size = new System.Drawing.Size(217, 26);
            this.tb_Token.TabIndex = 1;
            // 
            // bt_Register
            // 
            this.bt_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Register.Location = new System.Drawing.Point(344, 250);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(106, 50);
            this.bt_Register.TabIndex = 2;
            this.bt_Register.Text = "Register";
            this.bt_Register.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check your email address to get your Token";
            // 
            // Token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.tb_Token);
            this.Controls.Add(this.label1);
            this.Name = "Token";
            this.Text = "Token";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Token;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Label label2;
    }
}