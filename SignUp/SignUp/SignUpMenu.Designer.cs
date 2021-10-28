
namespace PostaRomanaFrontend.SignUp
{
    partial class SignUpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpMenu));
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.bt_Exit);
            this.gradientPanel1.Controls.Add(this.btSignUp);
            this.gradientPanel1.Controls.Add(this.linkSignUp);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.gradientPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 980);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1333, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(593, 1154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
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
            this.bt_Exit.Location = new System.Drawing.Point(1809, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(86, 83);
            this.bt_Exit.TabIndex = 6;
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // btSignUp
            // 
            this.btSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSignUp.AutoSize = true;
            this.btSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btSignUp.FlatAppearance.BorderSize = 3;
            this.btSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.btSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignUp.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.Location = new System.Drawing.Point(1071, 574);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(302, 73);
            this.btSignUp.TabIndex = 0;
            this.btSignUp.Text = "Sign up with email";
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // linkSignUp
            // 
            this.linkSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.BackColor = System.Drawing.Color.Transparent;
            this.linkSignUp.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.Location = new System.Drawing.Point(1360, 421);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(94, 33);
            this.linkSignUp.TabIndex = 4;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Log In";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(1035, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign up to get started";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(1014, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Already have an account?";
            // 
            // SignUpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpMenu";
            this.Text = "SignUpMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SignUpMenu_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}