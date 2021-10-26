
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.cb_EventType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_thirdStep = new System.Windows.Forms.PictureBox();
            this.pb_secondStep = new System.Windows.Forms.PictureBox();
            this.pb_firstStep = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.NextSlide = new System.Windows.Forms.PictureBox();
            this.postaRomanaDataSet = new AddEditEvent.PostaRomanaDataSet();
            this.eventTypeDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTypeDictionaryTableAdapter = new AddEditEvent.PostaRomanaDataSetTableAdapters.EventTypeDictionaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeDictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an entry cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost:";
            // 
            // tb_cost
            // 
            this.tb_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cost.Location = new System.Drawing.Point(184, 213);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(147, 35);
            this.tb_cost.TabIndex = 3;
            // 
            // cb_EventType
            // 
            this.cb_EventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventType.FormattingEnabled = true;
            this.cb_EventType.Location = new System.Drawing.Point(424, 211);
            this.cb_EventType.Name = "cb_EventType";
            this.cb_EventType.Size = new System.Drawing.Size(269, 37);
            this.cb_EventType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select the type of \r\nevent you are organizing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "=======";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "=======";
            // 
            // pb_thirdStep
            // 
            this.pb_thirdStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_thirdStep.Location = new System.Drawing.Point(519, 12);
            this.pb_thirdStep.Name = "pb_thirdStep";
            this.pb_thirdStep.Size = new System.Drawing.Size(80, 65);
            this.pb_thirdStep.TabIndex = 17;
            this.pb_thirdStep.TabStop = false;
            // 
            // pb_secondStep
            // 
            this.pb_secondStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_secondStep.Location = new System.Drawing.Point(362, 12);
            this.pb_secondStep.Name = "pb_secondStep";
            this.pb_secondStep.Size = new System.Drawing.Size(80, 65);
            this.pb_secondStep.TabIndex = 16;
            this.pb_secondStep.TabStop = false;
            // 
            // pb_firstStep
            // 
            this.pb_firstStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_firstStep.Location = new System.Drawing.Point(197, 12);
            this.pb_firstStep.Name = "pb_firstStep";
            this.pb_firstStep.Size = new System.Drawing.Size(80, 65);
            this.pb_firstStep.TabIndex = 15;
            this.pb_firstStep.TabStop = false;
            this.pb_firstStep.Click += new System.EventHandler(this.pb_firstStep_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Location = new System.Drawing.Point(728, 12);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(60, 60);
            this.pb_Close.TabIndex = 10;
            this.pb_Close.TabStop = false;
            // 
            // NextSlide
            // 
            this.NextSlide.Image = ((System.Drawing.Image)(resources.GetObject("NextSlide.Image")));
            this.NextSlide.Location = new System.Drawing.Point(637, 363);
            this.NextSlide.Name = "NextSlide";
            this.NextSlide.Size = new System.Drawing.Size(142, 64);
            this.NextSlide.TabIndex = 8;
            this.NextSlide.TabStop = false;
            this.NextSlide.Click += new System.EventHandler(this.NextSlide_Click);
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
            // AddEvent3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_thirdStep);
            this.Controls.Add(this.pb_secondStep);
            this.Controls.Add(this.pb_firstStep);
            this.Controls.Add(this.pb_Close);
            this.Controls.Add(this.NextSlide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_EventType);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent3";
            this.Text = "AddEvent3";
            this.Load += new System.EventHandler(this.AddEvent3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaRomanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeDictionaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox NextSlide;
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
    }
}