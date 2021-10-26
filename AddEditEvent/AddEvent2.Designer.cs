
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
            this.NextSlide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(107, 156);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(255, 26);
            this.StartDate.TabIndex = 0;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(418, 156);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(255, 26);
            this.EndDate.TabIndex = 1;
            // 
            // citiesBox
            // 
            this.citiesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citiesBox.FormattingEnabled = true;
            this.citiesBox.Location = new System.Drawing.Point(490, 291);
            this.citiesBox.Name = "citiesBox";
            this.citiesBox.Size = new System.Drawing.Size(183, 37);
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
            this.countryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(107, 291);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(183, 37);
            this.countryBox.TabIndex = 3;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.postaRomanaDataSetBindingSource;
            // 
            // countiesBox
            // 
            this.countiesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countiesBox.FormattingEnabled = true;
            this.countiesBox.Location = new System.Drawing.Point(301, 291);
            this.countiesBox.Name = "countiesBox";
            this.countiesBox.Size = new System.Drawing.Size(183, 37);
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
            this.AddressLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLine.Location = new System.Drawing.Point(107, 220);
            this.AddressLine.Name = "AddressLine";
            this.AddressLine.Size = new System.Drawing.Size(566, 35);
            this.AddressLine.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event\'s Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Event\'s Ending Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "County";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "=======";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "=======";
            // 
            // pb_thirdStep
            // 
            this.pb_thirdStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_thirdStep.Location = new System.Drawing.Point(531, 12);
            this.pb_thirdStep.Name = "pb_thirdStep";
            this.pb_thirdStep.Size = new System.Drawing.Size(80, 65);
            this.pb_thirdStep.TabIndex = 18;
            this.pb_thirdStep.TabStop = false;
            // 
            // pb_secondStep
            // 
            this.pb_secondStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_secondStep.Location = new System.Drawing.Point(374, 12);
            this.pb_secondStep.Name = "pb_secondStep";
            this.pb_secondStep.Size = new System.Drawing.Size(80, 65);
            this.pb_secondStep.TabIndex = 17;
            this.pb_secondStep.TabStop = false;
            // 
            // pb_firstStep
            // 
            this.pb_firstStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_firstStep.Location = new System.Drawing.Point(210, 12);
            this.pb_firstStep.Name = "pb_firstStep";
            this.pb_firstStep.Size = new System.Drawing.Size(80, 65);
            this.pb_firstStep.TabIndex = 16;
            this.pb_firstStep.TabStop = false;
            this.pb_firstStep.Click += new System.EventHandler(this.pb_firstStep_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Location = new System.Drawing.Point(728, 12);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(60, 60);
            this.pb_Close.TabIndex = 15;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // NextSlide
            // 
            this.NextSlide.Image = ((System.Drawing.Image)(resources.GetObject("NextSlide.Image")));
            this.NextSlide.Location = new System.Drawing.Point(628, 374);
            this.NextSlide.Name = "NextSlide";
            this.NextSlide.Size = new System.Drawing.Size(142, 64);
            this.NextSlide.TabIndex = 7;
            this.NextSlide.TabStop = false;
            this.NextSlide.Click += new System.EventHandler(this.NextSlide_Click);
            // 
            // AddEvent2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pb_thirdStep);
            this.Controls.Add(this.pb_secondStep);
            this.Controls.Add(this.pb_firstStep);
            this.Controls.Add(this.pb_Close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressLine);
            this.Controls.Add(this.NextSlide);
            this.Controls.Add(this.countiesBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.citiesBox);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent2";
            this.Text = "AddEvent2";
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
            ((System.ComponentModel.ISupportInitialize)(this.NextSlide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox NextSlide;
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
    }
}