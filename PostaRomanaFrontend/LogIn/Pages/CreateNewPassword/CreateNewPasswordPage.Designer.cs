
namespace LogIn.Pages.CreateNewPassword
{
    partial class CreateNewPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewPasswordPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_login_showPassword = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label1.Location = new System.Drawing.Point(732, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter new password:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label2.Location = new System.Drawing.Point(713, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm new password:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(692, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Passwords do not match.";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 14F);
            this.button1.Location = new System.Drawing.Point(744, 529);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(692, 341);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(311, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(692, 439);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(311, 26);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // button_login_showPassword
            // 
            this.button_login_showPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.button_login_showPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_login_showPassword.BackgroundImage")));
            this.button_login_showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_login_showPassword.FlatAppearance.BorderSize = 0;
            this.button_login_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login_showPassword.Location = new System.Drawing.Point(1008, 343);
            this.button_login_showPassword.Name = "button_login_showPassword";
            this.button_login_showPassword.Size = new System.Drawing.Size(32, 20);
            this.button_login_showPassword.TabIndex = 11;
            this.button_login_showPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_login_showPassword.UseVisualStyleBackColor = false;
            this.button_login_showPassword.Click += new System.EventHandler(this.button_login_showPassword_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1008, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 20);
            this.button2.TabIndex = 12;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(593, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(557, 209);
            this.label4.TabIndex = 13;
            this.label4.Text = "Your password has been reset! You can now log in with your new password.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 14F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(727, 510);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(313, 113);
            this.button3.TabIndex = 14;
            this.button3.Text = "Return to LogIn page";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.button3);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.button2);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.button_login_showPassword);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.textBox2);
            this.gradientPanel1.Controls.Add(this.textBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1732, 819);
            this.gradientPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bt_Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1732, 80);
            this.panel1.TabIndex = 16;
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Exit.BackgroundImage")));
            this.bt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Location = new System.Drawing.Point(1628, 5);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(85, 65);
            this.bt_Exit.TabIndex = 15;
            this.bt_Exit.UseVisualStyleBackColor = false;
            // 
            // CreateNewPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 819);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateNewPasswordPage";
            this.Text = "CreateNewPasswordPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_login_showPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Panel panel1;
    }
}