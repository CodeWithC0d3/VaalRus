
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
            this.components = new System.ComponentModel.Container();
            this.panelInput = new System.Windows.Forms.Panel();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.panelInner = new System.Windows.Forms.Panel();
            this.groupBoxOrderBy = new System.Windows.Forms.GroupBox();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.panelReportViewer = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fromDateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelInput.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.panelInner.SuspendLayout();
            this.groupBoxOrderBy.SuspendLayout();
            this.panelReportViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.panelInput.Controls.Add(this.groupBoxDisplay);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1067, 99);
            this.panelInput.TabIndex = 1;
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.Controls.Add(this.panelInner);
            this.groupBoxDisplay.Location = new System.Drawing.Point(16, 4);
            this.groupBoxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDisplay.Size = new System.Drawing.Size(739, 87);
            this.groupBoxDisplay.TabIndex = 0;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "Display report per time period:";
            // 
            // panelInner
            // 
            this.panelInner.Controls.Add(this.groupBoxOrderBy);
            this.panelInner.Controls.Add(this.lblStartDate);
            this.panelInner.Controls.Add(this.dpEnd);
            this.panelInner.Controls.Add(this.lblEnd);
            this.panelInner.Controls.Add(this.dpStart);
            this.panelInner.Controls.Add(this.btnDisplayReport);
            this.panelInner.Location = new System.Drawing.Point(7, 15);
            this.panelInner.Name = "panelInner";
            this.panelInner.Size = new System.Drawing.Size(726, 65);
            this.panelInner.TabIndex = 1;
            // 
            // groupBoxOrderBy
            // 
            this.groupBoxOrderBy.Controls.Add(this.radioButtonDesc);
            this.groupBoxOrderBy.Controls.Add(this.radioButtonAsc);
            this.groupBoxOrderBy.Location = new System.Drawing.Point(400, -3);
            this.groupBoxOrderBy.Name = "groupBoxOrderBy";
            this.groupBoxOrderBy.Size = new System.Drawing.Size(160, 68);
            this.groupBoxOrderBy.TabIndex = 7;
            this.groupBoxOrderBy.TabStop = false;
            this.groupBoxOrderBy.Text = "Order By StartDate:";
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.ForeColor = System.Drawing.Color.White;
            this.radioButtonDesc.Location = new System.Drawing.Point(29, 41);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(104, 21);
            this.radioButtonDesc.TabIndex = 1;
            this.radioButtonDesc.TabStop = true;
            this.radioButtonDesc.Text = "Descending";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.ForeColor = System.Drawing.Color.White;
            this.radioButtonAsc.Location = new System.Drawing.Point(29, 21);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(95, 21);
            this.radioButtonAsc.TabIndex = 0;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "Ascending";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(0, 12);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(103, 38);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(263, 22);
            this.dpEnd.TabIndex = 6;
            this.dpEnd.ValueChanged += new System.EventHandler(this.dpEnd_ValueChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(5, 43);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(71, 17);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Date:";
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(103, 8);
            this.dpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(263, 22);
            this.dpStart.TabIndex = 5;
            this.dpStart.ValueChanged += new System.EventHandler(this.dpStart_ValueChanged);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(590, 1);
            this.btnDisplayReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(128, 63);
            this.btnDisplayReport.TabIndex = 4;
            this.btnDisplayReport.Text = "Display";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // panelReportViewer
            // 
            this.panelReportViewer.Controls.Add(this.reportViewer1);
            this.panelReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportViewer.Location = new System.Drawing.Point(0, 99);
            this.panelReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.panelReportViewer.Name = "panelReportViewer";
            this.panelReportViewer.Size = new System.Drawing.Size(1067, 455);
            this.panelReportViewer.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 455);
            this.reportViewer1.TabIndex = 1;
            // 
            // fromDateErrorProvider
            // 
            this.fromDateErrorProvider.ContainerControl = this;
            // 
            // frmReportBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelReportViewer);
            this.Controls.Add(this.panelInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportBookings";
            this.Text = "frmReportBookings";
            this.Load += new System.EventHandler(this.frmReportBookings_Load);
            this.panelInput.ResumeLayout(false);
            this.groupBoxDisplay.ResumeLayout(false);
            this.panelInner.ResumeLayout(false);
            this.panelInner.PerformLayout();
            this.groupBoxOrderBy.ResumeLayout(false);
            this.groupBoxOrderBy.PerformLayout();
            this.panelReportViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fromDateErrorProvider)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxOrderBy;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.Panel panelInner;
        private System.Windows.Forms.ErrorProvider fromDateErrorProvider;
    }
}