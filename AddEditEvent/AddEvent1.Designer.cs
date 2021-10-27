
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
            this.tb_EventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_thirdStep = new System.Windows.Forms.PictureBox();
            this.pb_secondStep = new System.Windows.Forms.PictureBox();
            this.pb_firstStep = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_NextSlide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "=======";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(894, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "=======";
            // 
            // pb_thirdStep
            // 
            this.pb_thirdStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_thirdStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_thirdStep.Location = new System.Drawing.Point(1143, 167);
            this.pb_thirdStep.Name = "pb_thirdStep";
            this.pb_thirdStep.Size = new System.Drawing.Size(160, 105);
            this.pb_thirdStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_thirdStep.TabIndex = 12;
            this.pb_thirdStep.TabStop = false;
            // 
            // pb_secondStep
            // 
            this.pb_secondStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_secondStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_secondStep.Location = new System.Drawing.Point(821, 167);
            this.pb_secondStep.Name = "pb_secondStep";
            this.pb_secondStep.Size = new System.Drawing.Size(160, 105);
            this.pb_secondStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_secondStep.TabIndex = 11;
            this.pb_secondStep.TabStop = false;
            // 
            // pb_firstStep
            // 
            this.pb_firstStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_firstStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_firstStep.Location = new System.Drawing.Point(531, 167);
            this.pb_firstStep.Name = "pb_firstStep";
            this.pb_firstStep.Size = new System.Drawing.Size(160, 105);
            this.pb_firstStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_firstStep.TabIndex = 10;
            this.pb_firstStep.TabStop = false;
            // 
            // pb_Close
            // 
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(1817, 12);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(91, 78);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Close.TabIndex = 9;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.bt_NextSlide);
            this.gradientPanel1.Controls.Add(this.tb_Description);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.tb_EventName);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.pb_thirdStep);
            this.gradientPanel1.Controls.Add(this.pb_secondStep);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.pb_firstStep);
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
            this.bt_NextSlide.Location = new System.Drawing.Point(1354, 914);
            this.bt_NextSlide.Name = "bt_NextSlide";
            this.bt_NextSlide.Size = new System.Drawing.Size(108, 102);
            this.bt_NextSlide.TabIndex = 15;
            this.bt_NextSlide.UseVisualStyleBackColor = true;
            this.bt_NextSlide.Click += new System.EventHandler(this.bt_NextSlide_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.PictureBox pb_firstStep;
        private System.Windows.Forms.PictureBox pb_secondStep;
        private System.Windows.Forms.PictureBox pb_thirdStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_EventName;
        public System.Windows.Forms.TextBox tb_Description;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button bt_NextSlide;
        private System.Windows.Forms.Panel panel1;
    }
}

