
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
            this.pnlViewBookings = new System.Windows.Forms.Panel();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.radbViewAllBookings = new System.Windows.Forms.RadioButton();
            this.rdbSelectPeriod = new System.Windows.Forms.RadioButton();
            this.grpBoxSelectPeriod = new System.Windows.Forms.GroupBox();
            this.rdPayed = new System.Windows.Forms.RadioButton();
            this.rdPending = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblViewCurrentBookings = new System.Windows.Forms.Label();
            this.pictureBoxViewAllBookingsBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridACC = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlViewBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.grpBoxSelectPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridACC)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewBookings
            // 
            this.pnlViewBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.pnlViewBookings.Controls.Add(this.panel3);
            this.pnlViewBookings.Controls.Add(this.radbViewAllBookings);
            this.pnlViewBookings.Controls.Add(this.rdbSelectPeriod);
            this.pnlViewBookings.Controls.Add(this.grpBoxSelectPeriod);
            this.pnlViewBookings.Location = new System.Drawing.Point(28, 23);
            this.pnlViewBookings.Name = "pnlViewBookings";
            this.pnlViewBookings.Size = new System.Drawing.Size(263, 467);
            this.pnlViewBookings.TabIndex = 4;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBookings.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersWidth = 51;
            this.dataGridViewBookings.RowTemplate.Height = 24;
            this.dataGridViewBookings.Size = new System.Drawing.Size(730, 306);
            this.dataGridViewBookings.TabIndex = 12;
            this.dataGridViewBookings.SelectionChanged += new System.EventHandler(this.dataGridViewBookings_SelectionChanged);
            // 
            // radbViewAllBookings
            // 
            this.radbViewAllBookings.AutoSize = true;
            this.radbViewAllBookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radbViewAllBookings.Location = new System.Drawing.Point(51, 64);
            this.radbViewAllBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radbViewAllBookings.Name = "radbViewAllBookings";
            this.radbViewAllBookings.Size = new System.Drawing.Size(107, 17);
            this.radbViewAllBookings.TabIndex = 11;
            this.radbViewAllBookings.TabStop = true;
            this.radbViewAllBookings.Text = "View all bookings\r\n";
            this.radbViewAllBookings.UseVisualStyleBackColor = true;
            this.radbViewAllBookings.CheckedChanged += new System.EventHandler(this.radbViewAllBookings_CheckedChanged);
            // 
            // rdbSelectPeriod
            // 
            this.rdbSelectPeriod.AutoSize = true;
            this.rdbSelectPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSelectPeriod.Location = new System.Drawing.Point(51, 93);
            this.rdbSelectPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSelectPeriod.Name = "rdbSelectPeriod";
            this.rdbSelectPeriod.Size = new System.Drawing.Size(159, 17);
            this.rdbSelectPeriod.TabIndex = 10;
            this.rdbSelectPeriod.TabStop = true;
            this.rdbSelectPeriod.Text = "Filter bookings to time period";
            this.rdbSelectPeriod.UseVisualStyleBackColor = true;
            this.rdbSelectPeriod.CheckedChanged += new System.EventHandler(this.rdbSelectPeriod_CheckedChanged);
            // 
            // grpBoxSelectPeriod
            // 
            this.grpBoxSelectPeriod.Controls.Add(this.rdPayed);
            this.grpBoxSelectPeriod.Controls.Add(this.rdPending);
            this.grpBoxSelectPeriod.Controls.Add(this.btnReset);
            this.grpBoxSelectPeriod.Controls.Add(this.lblEndDate);
            this.grpBoxSelectPeriod.Controls.Add(this.lblStartDate);
            this.grpBoxSelectPeriod.Controls.Add(this.dateTimePickerEnd);
            this.grpBoxSelectPeriod.Controls.Add(this.btnViewBookings);
            this.grpBoxSelectPeriod.Controls.Add(this.dateTimePickerStart);
            this.grpBoxSelectPeriod.Enabled = false;
            this.grpBoxSelectPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxSelectPeriod.Location = new System.Drawing.Point(24, 134);
            this.grpBoxSelectPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSelectPeriod.Name = "grpBoxSelectPeriod";
            this.grpBoxSelectPeriod.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxSelectPeriod.Size = new System.Drawing.Size(214, 252);
            this.grpBoxSelectPeriod.TabIndex = 9;
            this.grpBoxSelectPeriod.TabStop = false;
            this.grpBoxSelectPeriod.Text = "Filter bookings to time period";
            // 
            // rdPayed
            // 
            this.rdPayed.AutoSize = true;
            this.rdPayed.Location = new System.Drawing.Point(31, 177);
            this.rdPayed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdPayed.Name = "rdPayed";
            this.rdPayed.Size = new System.Drawing.Size(72, 17);
            this.rdPayed.TabIndex = 12;
            this.rdPayed.TabStop = true;
            this.rdPayed.Text = "Confirmed";
            this.rdPayed.UseVisualStyleBackColor = true;
            // 
            // rdPending
            // 
            this.rdPending.AutoSize = true;
            this.rdPending.Location = new System.Drawing.Point(31, 155);
            this.rdPending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdPending.Name = "rdPending";
            this.rdPending.Size = new System.Drawing.Size(64, 17);
            this.rdPending.TabIndex = 11;
            this.rdPending.TabStop = true;
            this.rdPending.Text = "Pending";
            this.rdPending.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(119, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 38);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(25, 99);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(103, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "Select the end date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(25, 38);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(105, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Select the start date:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(27, 125);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewBookings.Location = new System.Drawing.Point(27, 200);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(86, 38);
            this.btnViewBookings.TabIndex = 7;
            this.btnViewBookings.Text = "View Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(27, 68);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // lblViewCurrentBookings
            // 
            this.lblViewCurrentBookings.AutoSize = true;
            this.lblViewCurrentBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCurrentBookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblViewCurrentBookings.Location = new System.Drawing.Point(46, 11);
            this.lblViewCurrentBookings.Name = "lblViewCurrentBookings";
            this.lblViewCurrentBookings.Size = new System.Drawing.Size(111, 20);
            this.lblViewCurrentBookings.TabIndex = 4;
            this.lblViewCurrentBookings.Text = "View bookings";
            // 
            // pictureBoxViewAllBookingsBackground
            // 
            this.pictureBoxViewAllBookingsBackground.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBoxViewAllBookingsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxViewAllBookingsBackground.Image = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.pictureBoxViewAllBookingsBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxViewAllBookingsBackground.Name = "pictureBoxViewAllBookingsBackground";
            this.pictureBoxViewAllBookingsBackground.Size = new System.Drawing.Size(1171, 655);
            this.pictureBoxViewAllBookingsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxViewAllBookingsBackground.TabIndex = 3;
            this.pictureBoxViewAllBookingsBackground.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewBookings);
            this.panel1.Location = new System.Drawing.Point(297, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 306);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridACC);
            this.panel2.Location = new System.Drawing.Point(297, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 146);
            this.panel2.TabIndex = 6;
            // 
            // gridACC
            // 
            this.gridACC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridACC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridACC.Location = new System.Drawing.Point(0, 0);
            this.gridACC.Name = "gridACC";
            this.gridACC.Size = new System.Drawing.Size(730, 146);
            this.gridACC.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblViewCurrentBookings);
            this.panel3.Location = new System.Drawing.Point(24, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 49);
            this.panel3.TabIndex = 12;
            // 
            // frmViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlViewBookings);
            this.Controls.Add(this.pictureBoxViewAllBookingsBackground);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewBookings";
            this.Text = "frmViewBookings";
            this.Load += new System.EventHandler(this.frmViewBookings_Load);
            this.pnlViewBookings.ResumeLayout(false);
            this.pnlViewBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.grpBoxSelectPeriod.ResumeLayout(false);
            this.grpBoxSelectPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridACC)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewBookings;
        private System.Windows.Forms.Label lblViewCurrentBookings;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.PictureBox pictureBoxViewAllBookingsBackground;
        private System.Windows.Forms.GroupBox grpBoxSelectPeriod;
        private System.Windows.Forms.RadioButton rdbSelectPeriod;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.RadioButton radbViewAllBookings;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdPayed;
        private System.Windows.Forms.RadioButton rdPending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridACC;
        private System.Windows.Forms.Panel panel3;
    }
}