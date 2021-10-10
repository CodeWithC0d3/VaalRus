
namespace vaalrusGUIPrototype
{
    partial class frmReport
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
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.lblED = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.panelReportViewer = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelInput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.panelReportViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.panelInput.Controls.Add(this.groupBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(800, 64);
            this.panelInput.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.btnDisplay);
            this.groupBoxInput.Controls.Add(this.dpEnd);
            this.groupBoxInput.Controls.Add(this.dpStart);
            this.groupBoxInput.Controls.Add(this.lblED);
            this.groupBoxInput.Controls.Add(this.lblSD);
            this.groupBoxInput.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(749, 55);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "View report per time period:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(566, 12);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(162, 37);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(365, 20);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(180, 20);
            this.dpEnd.TabIndex = 3;
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(85, 20);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(180, 20);
            this.dpStart.TabIndex = 2;
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(282, 26);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(61, 15);
            this.lblED.TabIndex = 1;
            this.lblED.Text = "End Date:";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(9, 26);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(64, 15);
            this.lblSD.TabIndex = 0;
            this.lblSD.Text = "Start Date:";
            // 
            // panelReportViewer
            // 
            this.panelReportViewer.Controls.Add(this.reportViewer);
            this.panelReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportViewer.Location = new System.Drawing.Point(0, 64);
            this.panelReportViewer.Name = "panelReportViewer";
            this.panelReportViewer.Size = new System.Drawing.Size(800, 386);
            this.panelReportViewer.TabIndex = 1;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "vaalrusGUIPrototype.Bookings.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(800, 386);
            this.reportViewer.TabIndex = 1;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReportViewer);
            this.Controls.Add(this.panelInput);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panelInput.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.panelReportViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.Label lblSD;
    }
}