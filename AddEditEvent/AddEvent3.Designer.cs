
namespace AddEditEvent
{
    partial class AddEvent3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent3));
            this.postaRomanaDataSet = new AddEditEvent.PostaRomanaDataSet();
            this.eventTypeDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTypeDictionaryTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.EventTypeDictionaryTableAdapter();
            this.gradientPanel1 = new PostaRomanaFrontend.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.bt_NextSlide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.cb_EventType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeDictionaryBindingSource)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // postaRomanaDataSet
            // 
            this.postaRomanaDataSet.DataSetName = "PostaRomanaDataSet";
            this.postaRomanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTypeDictionaryBindingSource
            // 
            this.eventTypeDictionaryBindingSource.DataMember = "EventTypeDictionary";
            this.eventTypeDictionaryBindingSource.DataSource = this.postaRomanaDataSet;
            // 
            // eventTypeDictionaryTableAdapter
            // 
            this.eventTypeDictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.LightCyan;
            this.gradientPanel1.ColorTop = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.pictureBox8);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.pictureBox5);
            this.gradientPanel1.Controls.Add(this.pictureBox4);
            this.gradientPanel1.Controls.Add(this.pictureBox6);
            this.gradientPanel1.Controls.Add(this.pictureBox7);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.bt_NextSlide);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.tb_cost);
            this.gradientPanel1.Controls.Add(this.cb_EventType);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1946, 1080);
            this.gradientPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pb_Close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1946, 100);
            this.panel1.TabIndex = 21;
            // 
            // pb_Close
            // 
            this.pb_Close.BackColor = System.Drawing.Color.Transparent;
            this.pb_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(1844, 12);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(90, 85);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Close.TabIndex = 10;
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
            this.bt_NextSlide.Location = new System.Drawing.Point(1406, 817);
            this.bt_NextSlide.Name = "bt_NextSlide";
            this.bt_NextSlide.Size = new System.Drawing.Size(141, 116);
            this.bt_NextSlide.TabIndex = 20;
            this.bt_NextSlide.UseVisualStyleBackColor = false;
            this.bt_NextSlide.Click += new System.EventHandler(this.bt_NextSlide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(489, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an entry cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(491, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost:";
            // 
            // tb_cost
            // 
            this.tb_cost.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cost.Location = new System.Drawing.Point(577, 647);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(225, 34);
            this.tb_cost.TabIndex = 3;
            // 
            // cb_EventType
            // 
            this.cb_EventType.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventType.FormattingEnabled = true;
            this.cb_EventType.Location = new System.Drawing.Point(1000, 645);
            this.cb_EventType.Name = "cb_EventType";
            this.cb_EventType.Size = new System.Drawing.Size(417, 34);
            this.cb_EventType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(1007, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 82);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select the type of \r\nevent you are organizing";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(580, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 65);
            this.label9.TabIndex = 41;
            this.label9.Text = "1";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(496, 211);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(220, 180);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(1385, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 65);
            this.label7.TabIndex = 39;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(989, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 65);
            this.label8.TabIndex = 38;
            this.label8.Text = "2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1155, 267);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(754, 267);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1304, 211);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(220, 180);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(910, 211);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(220, 180);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            // 
            // AddEvent3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1080);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent3";
            this.Text = "AddEvent3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddEvent3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeDictionaryBindingSource)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_Close;
        public System.Windows.Forms.TextBox tb_cost;
        public System.Windows.Forms.ComboBox cb_EventType;
        private PostaRomanaDataSet postaRomanaDataSet;
        private System.Windows.Forms.BindingSource eventTypeDictionaryBindingSource;
        private PostaRomanaDataSetTableAdapters.EventTypeDictionaryTableAdapter eventTypeDictionaryTableAdapter;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button bt_NextSlide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}