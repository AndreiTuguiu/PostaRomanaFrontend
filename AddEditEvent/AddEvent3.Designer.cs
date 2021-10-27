
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
            this.bt_NextSlide = new System.Windows.Forms.Button();
            this.pb_thirdStep = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.pb_secondStep = new System.Windows.Forms.PictureBox();
            this.cb_EventType = new System.Windows.Forms.ComboBox();
            this.pb_firstStep = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeDictionaryBindingSource)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.bt_NextSlide);
            this.gradientPanel1.Controls.Add(this.pb_thirdStep);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.tb_cost);
            this.gradientPanel1.Controls.Add(this.pb_secondStep);
            this.gradientPanel1.Controls.Add(this.cb_EventType);
            this.gradientPanel1.Controls.Add(this.pb_firstStep);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1946, 1080);
            this.gradientPanel1.TabIndex = 20;
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
            // pb_thirdStep
            // 
            this.pb_thirdStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_thirdStep.Location = new System.Drawing.Point(1217, 116);
            this.pb_thirdStep.Name = "pb_thirdStep";
            this.pb_thirdStep.Size = new System.Drawing.Size(105, 87);
            this.pb_thirdStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_thirdStep.TabIndex = 17;
            this.pb_thirdStep.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1299, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "=======";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(491, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an entry cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "=======";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(493, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost:";
            // 
            // tb_cost
            // 
            this.tb_cost.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cost.Location = new System.Drawing.Point(579, 462);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(225, 34);
            this.tb_cost.TabIndex = 3;
            // 
            // pb_secondStep
            // 
            this.pb_secondStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_secondStep.Location = new System.Drawing.Point(838, 117);
            this.pb_secondStep.Name = "pb_secondStep";
            this.pb_secondStep.Size = new System.Drawing.Size(104, 86);
            this.pb_secondStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_secondStep.TabIndex = 16;
            this.pb_secondStep.TabStop = false;
            // 
            // cb_EventType
            // 
            this.cb_EventType.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventType.FormattingEnabled = true;
            this.cb_EventType.Location = new System.Drawing.Point(1002, 460);
            this.cb_EventType.Name = "cb_EventType";
            this.cb_EventType.Size = new System.Drawing.Size(417, 34);
            this.cb_EventType.TabIndex = 4;
            // 
            // pb_firstStep
            // 
            this.pb_firstStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_firstStep.Location = new System.Drawing.Point(530, 116);
            this.pb_firstStep.Name = "pb_firstStep";
            this.pb_firstStep.Size = new System.Drawing.Size(110, 87);
            this.pb_firstStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_firstStep.TabIndex = 15;
            this.pb_firstStep.TabStop = false;
            this.pb_firstStep.Click += new System.EventHandler(this.pb_firstStep_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(1009, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 82);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select the type of \r\nevent you are organizing";
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_thirdStep;
        private System.Windows.Forms.PictureBox pb_secondStep;
        private System.Windows.Forms.PictureBox pb_firstStep;
        public System.Windows.Forms.TextBox tb_cost;
        public System.Windows.Forms.ComboBox cb_EventType;
        private PostaRomanaDataSet postaRomanaDataSet;
        private System.Windows.Forms.BindingSource eventTypeDictionaryBindingSource;
        private PostaRomanaDataSetTableAdapters.EventTypeDictionaryTableAdapter eventTypeDictionaryTableAdapter;
        private PostaRomanaFrontend.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button bt_NextSlide;
        private System.Windows.Forms.Panel panel1;
    }
}