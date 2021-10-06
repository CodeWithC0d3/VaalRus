
namespace vaalrusGUIPrototype.Forms
{
    partial class frmViewBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBookings));
            this.pnlViewBookings = new System.Windows.Forms.Panel();
            this.lblViewCurrentBookings = new System.Windows.Forms.Label();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.listBoxViewBookings = new System.Windows.Forms.ListBox();
            this.grpBoxSelectPeriod = new System.Windows.Forms.GroupBox();
            this.pictureBoxViewAllBookingsBackground = new System.Windows.Forms.PictureBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.rdbSelectPeriod = new System.Windows.Forms.RadioButton();
            this.pnlViewBookings.SuspendLayout();
            this.grpBoxSelectPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewBookings
            // 
            this.pnlViewBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.pnlViewBookings.Controls.Add(this.rdbSelectPeriod);
            this.pnlViewBookings.Controls.Add(this.grpBoxSelectPeriod);
            this.pnlViewBookings.Controls.Add(this.listBoxViewBookings);
            this.pnlViewBookings.Controls.Add(this.lblViewCurrentBookings);
            this.pnlViewBookings.Location = new System.Drawing.Point(36, 28);
            this.pnlViewBookings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlViewBookings.Name = "pnlViewBookings";
            this.pnlViewBookings.Size = new System.Drawing.Size(1065, 567);
            this.pnlViewBookings.TabIndex = 4;
            // 
            // lblViewCurrentBookings
            // 
            this.lblViewCurrentBookings.AutoSize = true;
            this.lblViewCurrentBookings.Location = new System.Drawing.Point(607, 44);
            this.lblViewCurrentBookings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewCurrentBookings.Name = "lblViewCurrentBookings";
            this.lblViewCurrentBookings.Size = new System.Drawing.Size(116, 17);
            this.lblViewCurrentBookings.TabIndex = 4;
            this.lblViewCurrentBookings.Text = "Current bookings";
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Location = new System.Drawing.Point(79, 293);
            this.btnViewBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(120, 47);
            this.btnViewBookings.TabIndex = 7;
            this.btnViewBookings.Text = "View Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            // 
            // listBoxViewBookings
            // 
            this.listBoxViewBookings.FormattingEnabled = true;
            this.listBoxViewBookings.ItemHeight = 16;
            this.listBoxViewBookings.Location = new System.Drawing.Point(345, 80);
            this.listBoxViewBookings.Name = "listBoxViewBookings";
            this.listBoxViewBookings.Size = new System.Drawing.Size(688, 452);
            this.listBoxViewBookings.TabIndex = 8;
            // 
            // grpBoxSelectPeriod
            // 
            this.grpBoxSelectPeriod.Controls.Add(this.lblEndDate);
            this.grpBoxSelectPeriod.Controls.Add(this.lblStartDate);
            this.grpBoxSelectPeriod.Controls.Add(this.dateTimePickerEnd);
            this.grpBoxSelectPeriod.Controls.Add(this.btnViewBookings);
            this.grpBoxSelectPeriod.Controls.Add(this.dateTimePickerStart);
            this.grpBoxSelectPeriod.Location = new System.Drawing.Point(32, 165);
            this.grpBoxSelectPeriod.Name = "grpBoxSelectPeriod";
            this.grpBoxSelectPeriod.Size = new System.Drawing.Size(286, 367);
            this.grpBoxSelectPeriod.TabIndex = 9;
            this.grpBoxSelectPeriod.TabStop = false;
            this.grpBoxSelectPeriod.Text = "Select time period";
            // 
            // pictureBoxViewAllBookingsBackground
            // 
            this.pictureBoxViewAllBookingsBackground.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBoxViewAllBookingsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxViewAllBookingsBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxViewAllBookingsBackground.Image")));
            this.pictureBoxViewAllBookingsBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxViewAllBookingsBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxViewAllBookingsBackground.Name = "pictureBoxViewAllBookingsBackground";
            this.pictureBoxViewAllBookingsBackground.Size = new System.Drawing.Size(1152, 629);
            this.pictureBoxViewAllBookingsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxViewAllBookingsBackground.TabIndex = 3;
            this.pictureBoxViewAllBookingsBackground.TabStop = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(36, 83);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(36, 213);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(33, 47);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(139, 17);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Select the start date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(33, 167);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(135, 17);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "Select the end date:";
            // 
            // rdbSelectPeriod
            // 
            this.rdbSelectPeriod.AutoSize = true;
            this.rdbSelectPeriod.Location = new System.Drawing.Point(111, 80);
            this.rdbSelectPeriod.Name = "rdbSelectPeriod";
            this.rdbSelectPeriod.Size = new System.Drawing.Size(154, 21);
            this.rdbSelectPeriod.TabIndex = 10;
            this.rdbSelectPeriod.TabStop = true;
            this.rdbSelectPeriod.Text = "Select a time period";
            this.rdbSelectPeriod.UseVisualStyleBackColor = true;
            // 
            // frmViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 629);
            this.Controls.Add(this.pnlViewBookings);
            this.Controls.Add(this.pictureBoxViewAllBookingsBackground);
            this.Name = "frmViewBookings";
            this.Text = "frmViewBookings";
            this.pnlViewBookings.ResumeLayout(false);
            this.pnlViewBookings.PerformLayout();
            this.grpBoxSelectPeriod.ResumeLayout(false);
            this.grpBoxSelectPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewBookings;
        private System.Windows.Forms.Label lblViewCurrentBookings;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.PictureBox pictureBoxViewAllBookingsBackground;
        private System.Windows.Forms.ListBox listBoxViewBookings;
        private System.Windows.Forms.GroupBox grpBoxSelectPeriod;
        private System.Windows.Forms.RadioButton rdbSelectPeriod;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
    }
}