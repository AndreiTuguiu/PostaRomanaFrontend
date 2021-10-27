
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
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.lb_city = new System.Windows.Forms.ListBox();
            this.lb_county = new System.Windows.Forms.ListBox();
            this.lb_country = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.bt_Exit);
            this.gradientPanel1.Controls.Add(this.lb_city);
            this.gradientPanel1.Controls.Add(this.lb_county);
            this.gradientPanel1.Controls.Add(this.lb_country);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.textBox1);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1898, 1024);
            this.gradientPanel1.TabIndex = 0;
            // 
            // lb_city
            // 
            this.lb_city.FormattingEnabled = true;
            this.lb_city.ItemHeight = 20;
            this.lb_city.Location = new System.Drawing.Point(650, 156);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(211, 84);
            this.lb_city.TabIndex = 5;
            this.lb_city.SelectedIndexChanged += new System.EventHandler(this.lb_city_SelectedIndexChanged);
            // 
            // lb_county
            // 
            this.lb_county.FormattingEnabled = true;
            this.lb_county.ItemHeight = 20;
            this.lb_county.Location = new System.Drawing.Point(411, 156);
            this.lb_county.Name = "lb_county";
            this.lb_county.Size = new System.Drawing.Size(174, 84);
            this.lb_county.TabIndex = 4;
            // 
            // lb_country
            // 
            this.lb_country.FormattingEnabled = true;
            this.lb_country.ItemHeight = 20;
            this.lb_country.Location = new System.Drawing.Point(135, 156);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(226, 84);
            this.lb_country.TabIndex = 3;
            this.lb_country.SelectedIndexChanged += new System.EventHandler(this.lb_country_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1452, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "LogIn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(859, 61);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(1792, 23);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 79);
            this.bt_Exit.TabIndex = 1;
            this.bt_Exit.UseVisualStyleBackColor = true;
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
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.ListBox lb_country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_city;
        private System.Windows.Forms.ListBox lb_county;
        private System.Windows.Forms.Button bt_Exit;
    }
}

