
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
            this.NextSlide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_EventName
            // 
            this.tb_EventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EventName.Location = new System.Drawing.Point(162, 214);
            this.tb_EventName.Name = "tb_EventName";
            this.tb_EventName.Size = new System.Drawing.Size(495, 35);
            this.tb_EventName.TabIndex = 0;
            this.tb_EventName.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name of your event\r\n";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(162, 296);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(494, 128);
            this.tb_Description.TabIndex = 7;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "=======";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "=======";
            // 
            // pb_thirdStep
            // 
            this.pb_thirdStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_thirdStep.Location = new System.Drawing.Point(538, 12);
            this.pb_thirdStep.Name = "pb_thirdStep";
            this.pb_thirdStep.Size = new System.Drawing.Size(80, 65);
            this.pb_thirdStep.TabIndex = 12;
            this.pb_thirdStep.TabStop = false;
            // 
            // pb_secondStep
            // 
            this.pb_secondStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_secondStep.Location = new System.Drawing.Point(381, 12);
            this.pb_secondStep.Name = "pb_secondStep";
            this.pb_secondStep.Size = new System.Drawing.Size(80, 65);
            this.pb_secondStep.TabIndex = 11;
            this.pb_secondStep.TabStop = false;
            // 
            // pb_firstStep
            // 
            this.pb_firstStep.Image = global::AddEditEvent.Properties.Resources.placeholder_stepper;
            this.pb_firstStep.Location = new System.Drawing.Point(216, 12);
            this.pb_firstStep.Name = "pb_firstStep";
            this.pb_firstStep.Size = new System.Drawing.Size(80, 65);
            this.pb_firstStep.TabIndex = 10;
            this.pb_firstStep.TabStop = false;
            // 
            // pb_Close
            // 
            this.pb_Close.Location = new System.Drawing.Point(788, 12);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(60, 60);
            this.pb_Close.TabIndex = 9;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // NextSlide
            // 
            this.NextSlide.Image = ((System.Drawing.Image)(resources.GetObject("NextSlide.Image")));
            this.NextSlide.Location = new System.Drawing.Point(689, 457);
            this.NextSlide.Name = "NextSlide";
            this.NextSlide.Size = new System.Drawing.Size(142, 64);
            this.NextSlide.TabIndex = 6;
            this.NextSlide.TabStop = false;
            this.NextSlide.Click += new System.EventHandler(this.NextSlide_Click);
            // 
            // AddEvent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_thirdStep);
            this.Controls.Add(this.pb_secondStep);
            this.Controls.Add(this.pb_firstStep);
            this.Controls.Add(this.pb_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.NextSlide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_EventName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_thirdStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_firstStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSlide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox NextSlide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.PictureBox pb_firstStep;
        private System.Windows.Forms.PictureBox pb_secondStep;
        private System.Windows.Forms.PictureBox pb_thirdStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_EventName;
        public System.Windows.Forms.TextBox tb_Description;
    }
}

