
namespace vaalrusGUIPrototype.Forms
{
    partial class frmDeleteAccommodation
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchNumber = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.btnDeleteAccomm = new System.Windows.Forms.Button();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.btnDisplayAccomm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelChildForm.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.panel4);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1242, 553);
            this.panelChildForm.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblSearchNumber);
            this.panel1.Controls.Add(this.txtBoxNumber);
            this.panel1.Controls.Add(this.btnDeleteAccomm);
            this.panel1.Controls.Add(this.txtBoxType);
            this.panel1.Controls.Add(this.lblSearchType);
            this.panel1.Controls.Add(this.btnDisplayAccomm);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 553);
            this.panel1.TabIndex = 19;
            // 
            // lblSearchNumber
            // 
            this.lblSearchNumber.AutoSize = true;
            this.lblSearchNumber.Location = new System.Drawing.Point(42, 124);
            this.lblSearchNumber.Name = "lblSearchNumber";
            this.lblSearchNumber.Size = new System.Drawing.Size(234, 17);
            this.lblSearchNumber.TabIndex = 6;
            this.lblSearchNumber.Text = "Search by Accommodation Number:";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(45, 155);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(344, 22);
            this.txtBoxNumber.TabIndex = 5;
            // 
            // btnDeleteAccomm
            // 
            this.btnDeleteAccomm.Location = new System.Drawing.Point(45, 298);
            this.btnDeleteAccomm.Name = "btnDeleteAccomm";
            this.btnDeleteAccomm.Size = new System.Drawing.Size(344, 46);
            this.btnDeleteAccomm.TabIndex = 4;
            this.btnDeleteAccomm.Text = "Delete Accommodation";
            this.btnDeleteAccomm.UseVisualStyleBackColor = true;
            // 
            // txtBoxType
            // 
            this.txtBoxType.Location = new System.Drawing.Point(45, 77);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.Size = new System.Drawing.Size(344, 22);
            this.txtBoxType.TabIndex = 3;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(42, 41);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(216, 17);
            this.lblSearchType.TabIndex = 2;
            this.lblSearchType.Text = "Search by Accommodation Type:";
            // 
            // btnDisplayAccomm
            // 
            this.btnDisplayAccomm.Location = new System.Drawing.Point(45, 212);
            this.btnDisplayAccomm.Name = "btnDisplayAccomm";
            this.btnDisplayAccomm.Size = new System.Drawing.Size(344, 48);
            this.btnDisplayAccomm.TabIndex = 0;
            this.btnDisplayAccomm.Text = "Display Accommodation";
            this.btnDisplayAccomm.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgView);
            this.panel4.Location = new System.Drawing.Point(443, 37);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 511);
            this.panel4.TabIndex = 18;
            // 
            // dgView
            // 
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(0, 0);
            this.dgView.Margin = new System.Windows.Forms.Padding(4);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 51;
            this.dgView.Size = new System.Drawing.Size(764, 511);
            this.dgView.TabIndex = 17;
            // 
            // frmDeleteAccommodation_1_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 553);
            this.Controls.Add(this.panelChildForm);
            this.Name = "frmDeleteAccommodation_1_";
            this.Text = "frmDeleteAccommodation_1_";
            this.panelChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchNumber;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Button btnDeleteAccomm;
        private System.Windows.Forms.TextBox txtBoxType;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Button btnDisplayAccomm;
    }
}