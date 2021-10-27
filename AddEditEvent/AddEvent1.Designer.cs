
namespace AddEditEvent
{
    partial class AddEvent1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent1));
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.bt_NextSlide = new System.Windows.Forms.Button();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.tb_EventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_Error = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.l_Error);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.pictureBox5);
            this.gradientPanel1.Controls.Add(this.pictureBox4);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.bt_NextSlide);
            this.gradientPanel1.Controls.Add(this.tb_Description);
            this.gradientPanel1.Controls.Add(this.tb_EventName);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.gradientPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pb_Close);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 17;
            // 
            // pb_Close
            // 
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(1752, 14);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(91, 78);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Close.TabIndex = 9;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // bt_NextSlide
            // 
            this.bt_NextSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_NextSlide.BackgroundImage")));
            this.bt_NextSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_NextSlide.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.bt_NextSlide.FlatAppearance.BorderSize = 3;
            this.bt_NextSlide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_NextSlide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_NextSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NextSlide.ForeColor = System.Drawing.Color.Transparent;
            this.bt_NextSlide.Location = new System.Drawing.Point(1394, 966);
            this.bt_NextSlide.Name = "bt_NextSlide";
            this.bt_NextSlide.Size = new System.Drawing.Size(108, 102);
            this.bt_NextSlide.TabIndex = 15;
            this.bt_NextSlide.UseVisualStyleBackColor = true;
            this.bt_NextSlide.Click += new System.EventHandler(this.bt_NextSlide_Click);
            // 
            // tb_Description
            // 
            this.tb_Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Description.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(621, 731);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(605, 194);
            this.tb_Description.TabIndex = 7;
            // 
            // tb_EventName
            // 
            this.tb_EventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_EventName.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EventName.Location = new System.Drawing.Point(621, 557);
            this.tb_EventName.Multiline = true;
            this.tb_EventName.Name = "tb_EventName";
            this.tb_EventName.Size = new System.Drawing.Size(611, 56);
            this.tb_EventName.TabIndex = 0;
            this.tb_EventName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_EventName.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(772, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name of your event\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(846, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(818, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1212, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(488, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 65);
            this.label3.TabIndex = 20;
            this.label3.Text = "1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(662, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1063, 265);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(904, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 65);
            this.label4.TabIndex = 23;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(1298, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 65);
            this.label5.TabIndex = 24;
            this.label5.Text = "3";
            // 
            // l_Error
            // 
            this.l_Error.AutoSize = true;
            this.l_Error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Error.ForeColor = System.Drawing.Color.Red;
            this.l_Error.Location = new System.Drawing.Point(616, 940);
            this.l_Error.Name = "l_Error";
            this.l_Error.Size = new System.Drawing.Size(266, 26);
            this.l_Error.TabIndex = 25;
            this.l_Error.Text = "*The fields are required!";
            this.l_Error.Visible = false;
            // 
            // AddEvent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Close;
        public System.Windows.Forms.TextBox tb_EventName;
        public System.Windows.Forms.TextBox tb_Description;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button bt_NextSlide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_Error;
    }
}

