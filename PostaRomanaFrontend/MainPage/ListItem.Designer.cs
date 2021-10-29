
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
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.l_name = new System.Windows.Forms.Label();
            this.l_organizer = new System.Windows.Forms.Label();
            this.l_date = new System.Windows.Forms.Label();
            this.l_location = new System.Windows.Forms.Label();
            this.l_cost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Icon
            // 
            this.pb_Icon.Location = new System.Drawing.Point(13, 11);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(158, 169);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Icon.TabIndex = 0;
            this.pb_Icon.TabStop = false;
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
            // l_location
            // 
            this.l_location.AutoSize = true;
            this.l_location.Location = new System.Drawing.Point(188, 139);
            this.l_location.Name = "l_location";
            this.l_location.Size = new System.Drawing.Size(74, 20);
            this.l_location.TabIndex = 4;
            this.l_location.Text = "Location:";
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
            this.Controls.Add(this.l_location);
            this.Controls.Add(this.l_date);
            this.Controls.Add(this.l_organizer);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.pb_Icon);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(743, 195);
            this.Load += new System.EventHandler(this.ListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_organizer;
        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.Label l_location;
        private System.Windows.Forms.Label l_cost;
    }
}
