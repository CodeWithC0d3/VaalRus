
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.panelReportViewer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.panelInput.Controls.Add(this.groupBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1067, 79);
            this.panelInput.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.panel1);
            this.groupBoxInput.Location = new System.Drawing.Point(4, 4);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInput.Size = new System.Drawing.Size(999, 68);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "View report per time period:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(757, 2);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(216, 39);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(489, 12);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(239, 22);
            this.dpEnd.TabIndex = 3;
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(115, 12);
            this.dpStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(239, 22);
            this.dpStart.TabIndex = 2;
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(378, 19);
            this.lblED.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(71, 17);
            this.lblED.TabIndex = 1;
            this.lblED.Text = "End Date:";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(14, 19);
            this.lblSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(76, 17);
            this.lblSD.TabIndex = 0;
            this.lblSD.Text = "Start Date:";
            // 
            // panelReportViewer
            // 
            this.panelReportViewer.Controls.Add(this.reportViewer);
            this.panelReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportViewer.Location = new System.Drawing.Point(0, 79);
            this.panelReportViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReportViewer.Name = "panelReportViewer";
            this.panelReportViewer.Size = new System.Drawing.Size(1067, 475);
            this.panelReportViewer.TabIndex = 1;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "vaalrusGUIPrototype.Bookings.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1067, 475);
            this.reportViewer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.lblSD);
            this.panel1.Controls.Add(this.dpEnd);
            this.panel1.Controls.Add(this.lblED);
            this.panel1.Controls.Add(this.dpStart);
            this.panel1.Location = new System.Drawing.Point(9, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 45);
            this.panel1.TabIndex = 2;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelReportViewer);
            this.Controls.Add(this.panelInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panelInput.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.panelReportViewer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
    }
}