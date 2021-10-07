
namespace vaalrusGUIPrototype
{
    partial class frmReportBookings
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelReportViewer = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.panelInput.SuspendLayout();
            this.panelReportViewer.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.panelInput.Controls.Add(this.groupBoxDisplay);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(800, 60);
            this.panelInput.TabIndex = 1;
            // 
            // panelReportViewer
            // 
            this.panelReportViewer.Controls.Add(this.reportViewer1);
            this.panelReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportViewer.Location = new System.Drawing.Point(0, 60);
            this.panelReportViewer.Name = "panelReportViewer";
            this.panelReportViewer.Size = new System.Drawing.Size(800, 390);
            this.panelReportViewer.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 390);
            this.reportViewer1.TabIndex = 1;
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.Controls.Add(this.dpEnd);
            this.groupBoxDisplay.Controls.Add(this.dpStart);
            this.groupBoxDisplay.Controls.Add(this.btnDisplayReport);
            this.groupBoxDisplay.Controls.Add(this.lblEnd);
            this.groupBoxDisplay.Controls.Add(this.lblStartDate);
            this.groupBoxDisplay.Location = new System.Drawing.Point(12, 3);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(776, 54);
            this.groupBoxDisplay.TabIndex = 0;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "Display report per month";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(24, 22);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(307, 22);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(55, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Date:";
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(591, 13);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(169, 30);
            this.btnDisplayReport.TabIndex = 4;
            this.btnDisplayReport.Text = "Display";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(88, 19);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(198, 20);
            this.dpStart.TabIndex = 5;
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(375, 19);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(198, 20);
            this.dpEnd.TabIndex = 6;
            // 
            // frmReportBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReportViewer);
            this.Controls.Add(this.panelInput);
            this.Name = "frmReportBookings";
            this.Text = "frmReportBookings";
            this.Load += new System.EventHandler(this.frmReportBookings_Load);
            this.panelInput.ResumeLayout(false);
            this.panelReportViewer.ResumeLayout(false);
            this.groupBoxDisplay.ResumeLayout(false);
            this.groupBoxDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
    }
}