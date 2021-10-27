﻿
namespace AddEditEvent
{
    partial class AddEvent2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent2));
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.citiesBox = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postaRomanaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postaRomanaDataSet = new AddEditEvent.PostaRomanaDataSet();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countiesBox = new System.Windows.Forms.ComboBox();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.CitiesTableAdapter();
            this.countiesTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.CountiesTableAdapter();
            this.countriesTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.CountriesTableAdapter();
            this.AddressLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_thirdStep = new System.Windows.Forms.PictureBox();
            this.pb_secondStep = new System.Windows.Forms.PictureBox();
            this.pb_firstStep = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.bt_NextSlide = new System.Windows.Forms.Button();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(637, 460);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(310, 32);
            this.StartDate.TabIndex = 0;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(1020, 460);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(317, 32);
            this.EndDate.TabIndex = 1;
            // 
            // citiesBox
            // 
            this.citiesBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citiesBox.FormattingEnabled = true;
            this.citiesBox.Location = new System.Drawing.Point(1154, 673);
            this.citiesBox.Name = "citiesBox";
            this.citiesBox.Size = new System.Drawing.Size(183, 32);
            this.citiesBox.TabIndex = 2;
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.postaRomanaDataSetBindingSource;
            // 
            // postaRomanaDataSetBindingSource
            // 
            this.postaRomanaDataSetBindingSource.DataSource = this.postaRomanaDataSet;
            this.postaRomanaDataSetBindingSource.Position = 0;
            // 
            // postaRomanaDataSet
            // 
            this.postaRomanaDataSet.DataSetName = "PostaRomanaDataSet";
            this.postaRomanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBox
            // 
            this.countryBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(637, 673);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(191, 32);
            this.countryBox.TabIndex = 3;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.postaRomanaDataSetBindingSource;
            // 
            // countiesBox
            // 
            this.countiesBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countiesBox.FormattingEnabled = true;
            this.countiesBox.Location = new System.Drawing.Point(888, 673);
            this.countiesBox.Name = "countiesBox";
            this.countiesBox.Size = new System.Drawing.Size(183, 32);
            this.countiesBox.TabIndex = 4;
            // 
            // countiesBindingSource
            // 
            this.countiesBindingSource.DataMember = "Counties";
            this.countiesBindingSource.DataSource = this.postaRomanaDataSetBindingSource;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // countiesTableAdapter
            // 
            this.countiesTableAdapter.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // AddressLine
            // 
            this.AddressLine.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine.Location = new System.Drawing.Point(636, 559);
            this.AddressLine.Name = "AddressLine";
            this.AddressLine.Size = new System.Drawing.Size(701, 32);
            this.AddressLine.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(632, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event\'s Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(1015, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Event\'s Ending Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(632, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(639, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(886, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "County";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(1150, 625);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(987, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "=======";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "=======";
            // 
            // pb_thirdStep
            // 
            this.pb_thirdStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_thirdStep.Location = new System.Drawing.Point(1234, 160);
            this.pb_thirdStep.Name = "pb_thirdStep";
            this.pb_thirdStep.Size = new System.Drawing.Size(144, 110);
            this.pb_thirdStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_thirdStep.TabIndex = 18;
            this.pb_thirdStep.TabStop = false;
            // 
            // pb_secondStep
            // 
            this.pb_secondStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_secondStep.Location = new System.Drawing.Point(901, 160);
            this.pb_secondStep.Name = "pb_secondStep";
            this.pb_secondStep.Size = new System.Drawing.Size(144, 110);
            this.pb_secondStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_secondStep.TabIndex = 17;
            this.pb_secondStep.TabStop = false;
            // 
            // pb_firstStep
            // 
            this.pb_firstStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_firstStep.Location = new System.Drawing.Point(573, 160);
            this.pb_firstStep.Name = "pb_firstStep";
            this.pb_firstStep.Size = new System.Drawing.Size(144, 110);
            this.pb_firstStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_firstStep.TabIndex = 16;
            this.pb_firstStep.TabStop = false;
            this.pb_firstStep.Click += new System.EventHandler(this.pb_firstStep_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Close.BackColor = System.Drawing.Color.Transparent;
            this.pb_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(1816, 8);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(81, 85);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Close.TabIndex = 15;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // bt_NextSlide
            // 
            this.bt_NextSlide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_NextSlide.BackColor = System.Drawing.Color.Transparent;
            this.bt_NextSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_NextSlide.BackgroundImage")));
            this.bt_NextSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_NextSlide.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.bt_NextSlide.FlatAppearance.BorderSize = 3;
            this.bt_NextSlide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_NextSlide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_NextSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NextSlide.Location = new System.Drawing.Point(1347, 805);
            this.bt_NextSlide.Name = "bt_NextSlide";
            this.bt_NextSlide.Size = new System.Drawing.Size(116, 104);
            this.bt_NextSlide.TabIndex = 21;
            this.bt_NextSlide.UseVisualStyleBackColor = false;
            this.bt_NextSlide.Click += new System.EventHandler(this.bt_NextSlide_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.AddressLine);
            this.gradientPanel1.Controls.Add(this.bt_NextSlide);
            this.gradientPanel1.Controls.Add(this.StartDate);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.EndDate);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.citiesBox);
            this.gradientPanel1.Controls.Add(this.pb_thirdStep);
            this.gradientPanel1.Controls.Add(this.countryBox);
            this.gradientPanel1.Controls.Add(this.pb_secondStep);
            this.gradientPanel1.Controls.Add(this.countiesBox);
            this.gradientPanel1.Controls.Add(this.pb_firstStep);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.gradientPanel1.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(561, 655);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(561, 541);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(561, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pb_Close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 25;
            // 
            // AddEvent2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent2";
            this.Text = "AddEvent2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddEvent2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource postaRomanaDataSetBindingSource;
        private PostaRomanaDataSet postaRomanaDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private PostaRomanaDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private PostaRomanaDataSetTableAdapters.CountiesTableAdapter countiesTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private PostaRomanaDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_thirdStep;
        private System.Windows.Forms.PictureBox pb_secondStep;
        private System.Windows.Forms.PictureBox pb_firstStep;
        public System.Windows.Forms.DateTimePicker StartDate;
        public System.Windows.Forms.DateTimePicker EndDate;
        public System.Windows.Forms.ComboBox citiesBox;
        public System.Windows.Forms.ComboBox countryBox;
        public System.Windows.Forms.ComboBox countiesBox;
        public System.Windows.Forms.TextBox AddressLine;
        private System.Windows.Forms.Button bt_NextSlide;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}