
namespace MainPage
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.pb_Location = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.bt_Logo = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.l_login = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.lb_city = new System.Windows.Forms.ListBox();
            this.lb_county = new System.Windows.Forms.ListBox();
            this.lb_country = new System.Windows.Forms.ListBox();
            this.pb_Search = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Location)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.bt_Exit);
            this.gradientPanel1.Controls.Add(this.lb_country);
            this.gradientPanel1.Controls.Add(this.lb_county);
            this.gradientPanel1.Controls.Add(this.lb_city);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1898, 1024);
            this.gradientPanel1.TabIndex = 0;
            // 
            // pb_Location
            // 
            this.pb_Location.BackColor = System.Drawing.Color.Transparent;
            this.pb_Location.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Location.Image = ((System.Drawing.Image)(resources.GetObject("pb_Location.Image")));
            this.pb_Location.Location = new System.Drawing.Point(5, 2);
            this.pb_Location.Name = "pb_Location";
            this.pb_Location.Size = new System.Drawing.Size(64, 62);
            this.pb_Location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Location.TabIndex = 19;
            this.pb_Location.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pb_Search);
            this.panel1.Controls.Add(this.pb_Close);
            this.panel1.Controls.Add(this.bt_Logo);
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.l_login);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 126);
            this.panel1.TabIndex = 18;
            // 
            // pb_Close
            // 
            this.pb_Close.BackColor = System.Drawing.Color.Transparent;
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(1776, 12);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(91, 78);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Close.TabIndex = 9;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // bt_Logo
            // 
            this.bt_Logo.BackColor = System.Drawing.Color.Transparent;
            this.bt_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Logo.ForeColor = System.Drawing.Color.White;
            this.bt_Logo.Location = new System.Drawing.Point(48, 7);
            this.bt_Logo.Name = "bt_Logo";
            this.bt_Logo.Size = new System.Drawing.Size(129, 83);
            this.bt_Logo.TabIndex = 0;
            this.bt_Logo.Text = "LOGO";
            this.bt_Logo.UseVisualStyleBackColor = false;
            this.bt_Logo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(289, 22);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(674, 67);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.BackColor = System.Drawing.Color.Transparent;
            this.l_login.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_login.ForeColor = System.Drawing.Color.White;
            this.l_login.Location = new System.Drawing.Point(1658, 41);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(87, 33);
            this.l_login.TabIndex = 2;
            this.l_login.Text = "LogIn";
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(1792, 23);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 79);
            this.bt_Exit.TabIndex = 1;
            this.bt_Exit.UseVisualStyleBackColor = true;
            // 
            // lb_city
            // 
            this.lb_city.FormattingEnabled = true;
            this.lb_city.ItemHeight = 20;
            this.lb_city.Location = new System.Drawing.Point(1453, 132);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(211, 84);
            this.lb_city.TabIndex = 5;
            this.lb_city.SelectedIndexChanged += new System.EventHandler(this.lb_city_SelectedIndexChanged);
            // 
            // lb_county
            // 
            this.lb_county.FormattingEnabled = true;
            this.lb_county.ItemHeight = 20;
            this.lb_county.Location = new System.Drawing.Point(1261, 132);
            this.lb_county.Name = "lb_county";
            this.lb_county.Size = new System.Drawing.Size(174, 84);
            this.lb_county.TabIndex = 4;
            // 
            // lb_country
            // 
            this.lb_country.FormattingEnabled = true;
            this.lb_country.ItemHeight = 20;
            this.lb_country.Location = new System.Drawing.Point(1029, 132);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(226, 84);
            this.lb_country.TabIndex = 3;
            this.lb_country.SelectedIndexChanged += new System.EventHandler(this.lb_country_SelectedIndexChanged);
            // 
            // pb_Search
            // 
            this.pb_Search.BackColor = System.Drawing.Color.Transparent;
            this.pb_Search.Image = ((System.Drawing.Image)(resources.GetObject("pb_Search.Image")));
            this.pb_Search.Location = new System.Drawing.Point(1453, 22);
            this.pb_Search.Name = "pb_Search";
            this.pb_Search.Size = new System.Drawing.Size(75, 62);
            this.pb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Search.TabIndex = 10;
            this.pb_Search.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(75, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 52);
            this.textBox1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.pb_Location);
            this.panel2.Location = new System.Drawing.Point(972, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 67);
            this.panel2.TabIndex = 20;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Location)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.ListBox lb_country;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Logo;
        private System.Windows.Forms.ListBox lb_city;
        private System.Windows.Forms.ListBox lb_county;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.PictureBox pb_Location;
        private System.Windows.Forms.PictureBox pb_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

