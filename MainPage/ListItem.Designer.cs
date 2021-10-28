
namespace MainPage
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_name = new System.Windows.Forms.Label();
            this.l_organizer = new System.Windows.Forms.Label();
            this.l_date = new System.Windows.Forms.Label();
            this.l_Location = new System.Windows.Forms.Label();
            this.l_cost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.BackColor = System.Drawing.Color.Transparent;
            this.l_name.Location = new System.Drawing.Point(188, 11);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(55, 20);
            this.l_name.TabIndex = 1;
            this.l_name.Text = "Name:";
            // 
            // l_organizer
            // 
            this.l_organizer.AutoSize = true;
            this.l_organizer.Location = new System.Drawing.Point(188, 53);
            this.l_organizer.Name = "l_organizer";
            this.l_organizer.Size = new System.Drawing.Size(126, 20);
            this.l_organizer.TabIndex = 2;
            this.l_organizer.Text = "Organizer name:";
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Location = new System.Drawing.Point(188, 98);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(48, 20);
            this.l_date.TabIndex = 3;
            this.l_date.Text = "Date:";
            // 
            // l_Location
            // 
            this.l_Location.AutoSize = true;
            this.l_Location.Location = new System.Drawing.Point(192, 140);
            this.l_Location.Name = "l_Location";
            this.l_Location.Size = new System.Drawing.Size(74, 20);
            this.l_Location.TabIndex = 4;
            this.l_Location.Text = "Location:";
            // 
            // l_cost
            // 
            this.l_cost.AutoSize = true;
            this.l_cost.Location = new System.Drawing.Point(526, 149);
            this.l_cost.Name = "l_cost";
            this.l_cost.Size = new System.Drawing.Size(46, 20);
            this.l_cost.TabIndex = 5;
            this.l_cost.Text = "Cost:";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_cost);
            this.Controls.Add(this.l_Location);
            this.Controls.Add(this.l_date);
            this.Controls.Add(this.l_organizer);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(1293, 195);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_organizer;
        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.Label l_Location;
        private System.Windows.Forms.Label l_cost;
    }
}
