
namespace AddEditEvent
{
    partial class Confirm
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
            this.tb_NameOfEvent = new System.Windows.Forms.TextBox();
            this.tb_EventDesc = new System.Windows.Forms.TextBox();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.cb_county = new System.Windows.Forms.ComboBox();
            this.cb_EventType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_AddressLine = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.b_Confirm = new System.Windows.Forms.Button();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.postaRomanaDataSet = new AddEditEvent.PostaRomanaDataSet();
            this.eventTypeDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTypeDictionaryTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.EventTypeDictionaryTableAdapter();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.CountriesTableAdapter();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countiesTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.CountiesTableAdapter();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.CitiesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_NameOfEvent
            // 
            this.tb_NameOfEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameOfEvent.Location = new System.Drawing.Point(18, 21);
            this.tb_NameOfEvent.Name = "tb_NameOfEvent";
            this.tb_NameOfEvent.Size = new System.Drawing.Size(229, 30);
            this.tb_NameOfEvent.TabIndex = 0;
            // 
            // tb_EventDesc
            // 
            this.tb_EventDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EventDesc.Location = new System.Drawing.Point(18, 113);
            this.tb_EventDesc.Multiline = true;
            this.tb_EventDesc.Name = "tb_EventDesc";
            this.tb_EventDesc.Size = new System.Drawing.Size(321, 101);
            this.tb_EventDesc.TabIndex = 1;
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(21, 33);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(139, 26);
            this.dt_start.TabIndex = 2;
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(203, 33);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(139, 26);
            this.dt_end.TabIndex = 3;
            // 
            // cb_country
            // 
            this.cb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(381, 21);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(176, 33);
            this.cb_country.TabIndex = 4;
            // 
            // cb_city
            // 
            this.cb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(381, 107);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(176, 33);
            this.cb_city.TabIndex = 5;
            // 
            // cb_county
            // 
            this.cb_county.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_county.FormattingEnabled = true;
            this.cb_county.Location = new System.Drawing.Point(381, 64);
            this.cb_county.Name = "cb_county";
            this.cb_county.Size = new System.Drawing.Size(176, 33);
            this.cb_county.TabIndex = 6;
            // 
            // cb_EventType
            // 
            this.cb_EventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventType.FormattingEnabled = true;
            this.cb_EventType.Location = new System.Drawing.Point(18, 65);
            this.cb_EventType.Name = "cb_EventType";
            this.cb_EventType.Size = new System.Drawing.Size(229, 33);
            this.cb_EventType.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_NameOfEvent);
            this.panel1.Controls.Add(this.cb_EventType);
            this.panel1.Controls.Add(this.tb_EventDesc);
            this.panel1.Location = new System.Drawing.Point(151, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 237);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dt_start);
            this.panel2.Controls.Add(this.dt_end);
            this.panel2.Location = new System.Drawing.Point(150, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 73);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date interval";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tb_AddressLine);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cb_country);
            this.panel3.Controls.Add(this.cb_city);
            this.panel3.Controls.Add(this.cb_county);
            this.panel3.Location = new System.Drawing.Point(44, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 175);
            this.panel3.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Address Line";
            // 
            // tb_AddressLine
            // 
            this.tb_AddressLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddressLine.Location = new System.Drawing.Point(19, 36);
            this.tb_AddressLine.Multiline = true;
            this.tb_AddressLine.Name = "tb_AddressLine";
            this.tb_AddressLine.Size = new System.Drawing.Size(217, 104);
            this.tb_AddressLine.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "County";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Location";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(88, 655);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cost:";
            // 
            // tb_Cost
            // 
            this.tb_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cost.Location = new System.Drawing.Point(162, 655);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(91, 30);
            this.tb_Cost.TabIndex = 18;
            // 
            // b_Confirm
            // 
            this.b_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Confirm.Location = new System.Drawing.Point(377, 655);
            this.b_Confirm.Name = "b_Confirm";
            this.b_Confirm.Size = new System.Drawing.Size(207, 44);
            this.b_Confirm.TabIndex = 19;
            this.b_Confirm.Text = "Confirm Event";
            this.b_Confirm.UseVisualStyleBackColor = true;
            this.b_Confirm.Click += new System.EventHandler(this.b_Confirm_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Location = new System.Drawing.Point(588, 12);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(60, 60);
            this.pb_Close.TabIndex = 20;
            this.pb_Close.TabStop = false;
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
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.postaRomanaDataSet;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // countiesBindingSource
            // 
            this.countiesBindingSource.DataMember = "Counties";
            this.countiesBindingSource.DataSource = this.postaRomanaDataSet;
            // 
            // countiesTableAdapter
            // 
            this.countiesTableAdapter.ClearBeforeFill = true;
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.postaRomanaDataSet;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 740);
            this.Controls.Add(this.pb_Close);
            this.Controls.Add(this.b_Confirm);
            this.Controls.Add(this.tb_Cost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button b_Confirm;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox tb_NameOfEvent;
        public System.Windows.Forms.TextBox tb_EventDesc;
        public System.Windows.Forms.DateTimePicker dt_start;
        public System.Windows.Forms.DateTimePicker dt_end;
        public System.Windows.Forms.ComboBox cb_country;
        public System.Windows.Forms.ComboBox cb_city;
        public System.Windows.Forms.ComboBox cb_county;
        public System.Windows.Forms.ComboBox cb_EventType;
        public System.Windows.Forms.TextBox tb_AddressLine;
        public System.Windows.Forms.TextBox tb_Cost;
        private PostaRomanaDataSet postaRomanaDataSet;
        private System.Windows.Forms.BindingSource eventTypeDictionaryBindingSource;
        private PostaRomanaDataSetTableAdapters.EventTypeDictionaryTableAdapter eventTypeDictionaryTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private PostaRomanaDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private PostaRomanaDataSetTableAdapters.CountiesTableAdapter countiesTableAdapter;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private PostaRomanaDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
    }
}