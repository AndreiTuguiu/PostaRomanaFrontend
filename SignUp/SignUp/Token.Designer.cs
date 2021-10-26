
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Token));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Token = new System.Windows.Forms.TextBox();
            this.bt_Register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(271, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, insert your Token here!";
            // 
            // tb_Token
            // 
            this.tb_Token.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Token.Font = new System.Drawing.Font("Berlin Sans FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Token.Location = new System.Drawing.Point(276, 256);
            this.tb_Token.Multiline = true;
            this.tb_Token.Name = "tb_Token";
            this.tb_Token.Size = new System.Drawing.Size(303, 67);
            this.tb_Token.TabIndex = 1;
            // 
            // bt_Register
            // 
            this.bt_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Register.BackColor = System.Drawing.Color.Transparent;
            this.bt_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Register.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.bt_Register.FlatAppearance.BorderSize = 3;
            this.bt_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Register.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Register.ForeColor = System.Drawing.Color.Black;
            this.bt_Register.Location = new System.Drawing.Point(351, 382);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(153, 50);
            this.bt_Register.TabIndex = 2;
            this.bt_Register.Text = "Register";
            this.bt_Register.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(109, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check your email address to get your Token";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.bt_Exit);
            this.gradientPanel1.Controls.Add(this.tb_Token);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.bt_Register);
            this.gradientPanel1.Location = new System.Drawing.Point(-24, -3);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(875, 500);
            this.gradientPanel1.TabIndex = 4;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Exit.BackgroundImage")));
            this.bt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Location = new System.Drawing.Point(733, 15);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(65, 66);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 494);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Token";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Token;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Label label2;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button bt_Exit;
    }
}