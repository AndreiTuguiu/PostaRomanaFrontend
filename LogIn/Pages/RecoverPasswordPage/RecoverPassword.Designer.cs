
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
            this.label_login_username = new System.Windows.Forms.Label();
            this.label_recover_invalidEmail = new System.Windows.Forms.Label();
            this.bt_recover_sendCode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertEmailLabel
            // 
            this.InsertEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.InsertEmailLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InsertEmailLabel.ForeColor = System.Drawing.Color.Indigo;
            this.InsertEmailLabel.Location = new System.Drawing.Point(562, 263);
            this.InsertEmailLabel.Name = "InsertEmailLabel";
            this.InsertEmailLabel.Size = new System.Drawing.Size(766, 218);
            this.InsertEmailLabel.TabIndex = 0;
            this.InsertEmailLabel.Text = "Insert the email associated to your account below and we will send you a password" +
    " recovery code.";
            this.InsertEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertEmailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_login_username
            // 
            this.label_login_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login_username.AutoSize = true;
            this.label_login_username.BackColor = System.Drawing.Color.Transparent;
            this.label_login_username.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login_username.ForeColor = System.Drawing.Color.Black;
            this.label_login_username.Location = new System.Drawing.Point(726, 513);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(87, 31);
            this.label_login_username.TabIndex = 5;
            this.label_login_username.Text = "Email:";
            this.label_login_username.Click += new System.EventHandler(this.label_login_username_Click);
            // 
            // label_recover_invalidEmail
            // 
            this.label_recover_invalidEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_recover_invalidEmail.AutoSize = true;
            this.label_recover_invalidEmail.BackColor = System.Drawing.Color.Transparent;
            this.label_recover_invalidEmail.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_recover_invalidEmail.ForeColor = System.Drawing.Color.Red;
            this.label_recover_invalidEmail.Location = new System.Drawing.Point(866, 620);
            this.label_recover_invalidEmail.Name = "label_recover_invalidEmail";
            this.label_recover_invalidEmail.Size = new System.Drawing.Size(154, 25);
            this.label_recover_invalidEmail.TabIndex = 13;
            this.label_recover_invalidEmail.Text = "*Invalid email.";
            this.label_recover_invalidEmail.Visible = false;
            // 
            // bt_recover_sendCode
            // 
            this.bt_recover_sendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_recover_sendCode.BackColor = System.Drawing.Color.Transparent;
            this.bt_recover_sendCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_recover_sendCode.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.bt_recover_sendCode.FlatAppearance.BorderSize = 3;
            this.bt_recover_sendCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_recover_sendCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_recover_sendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_recover_sendCode.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_recover_sendCode.ForeColor = System.Drawing.Color.Indigo;
            this.bt_recover_sendCode.Location = new System.Drawing.Point(806, 688);
            this.bt_recover_sendCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_recover_sendCode.Name = "bt_recover_sendCode";
            this.bt_recover_sendCode.Size = new System.Drawing.Size(293, 79);
            this.bt_recover_sendCode.TabIndex = 2;
            this.bt_recover_sendCode.Text = "Send recovery code";
            this.bt_recover_sendCode.UseVisualStyleBackColor = false;
            this.bt_recover_sendCode.Click += new System.EventHandler(this.bt_recover_sendCode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(726, 558);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 38);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.InsertEmailLabel);
            this.gradientPanel1.Controls.Add(this.textBox1);
            this.gradientPanel1.Controls.Add(this.label_login_username);
            this.gradientPanel1.Controls.Add(this.bt_recover_sendCode);
            this.gradientPanel1.Controls.Add(this.label_recover_invalidEmail);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.gradientPanel1.TabIndex = 16;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bt_Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 16;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Exit.BackgroundImage")));
            this.bt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Location = new System.Drawing.Point(1816, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(92, 75);
            this.bt_Exit.TabIndex = 0;
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecoverPassword";
            this.Text = "RecoverPassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InsertEmailLabel;
        private System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.Label label_recover_invalidEmail;
        private System.Windows.Forms.Button bt_recover_sendCode;
        private TextBox textBox1;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private Panel panel1;
        private Button bt_Exit;
        //this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
    }
}