
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.txtNrOcc = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAccNr = new System.Windows.Forms.TextBox();
            this.lblNrOcc = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.btnDeleteAccomm = new System.Windows.Forms.Button();
            this.lblAccNr = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.panelChildForm.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelChildForm.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Controls.Add(this.pnlFilter);
            this.panelChildForm.Controls.Add(this.pnlDelete);
            this.panelChildForm.Controls.Add(this.pnlGrid);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(818, 449);
            this.panelChildForm.TabIndex = 14;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.Controls.Add(this.cmbType);
            this.pnlFilter.Controls.Add(this.lblSearchType);
            this.pnlFilter.Location = new System.Drawing.Point(265, 21);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(536, 24);
            this.pnlFilter.TabIndex = 20;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(79, 2);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(76, 21);
            this.cmbType.TabIndex = 7;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(2, 7);
            this.lblSearchType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(73, 13);
            this.lblSearchType.TabIndex = 2;
            this.lblSearchType.Text = "Filter by Type:";
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.Silver;
            this.pnlDelete.Controls.Add(this.txtNrOcc);
            this.pnlDelete.Controls.Add(this.txtType);
            this.pnlDelete.Controls.Add(this.txtAccNr);
            this.pnlDelete.Controls.Add(this.lblNrOcc);
            this.pnlDelete.Controls.Add(this.lblAccType);
            this.pnlDelete.Controls.Add(this.btnDeleteAccomm);
            this.pnlDelete.Controls.Add(this.lblAccNr);
            this.pnlDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDelete.Location = new System.Drawing.Point(21, 21);
            this.pnlDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(222, 363);
            this.pnlDelete.TabIndex = 19;
            // 
            // txtNrOcc
            // 
            this.txtNrOcc.Enabled = false;
            this.txtNrOcc.Location = new System.Drawing.Point(124, 66);
            this.txtNrOcc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNrOcc.Name = "txtNrOcc";
            this.txtNrOcc.Size = new System.Drawing.Size(76, 20);
            this.txtNrOcc.TabIndex = 10;
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(124, 36);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(76, 20);
            this.txtType.TabIndex = 9;
            // 
            // txtAccNr
            // 
            this.txtAccNr.Enabled = false;
            this.txtAccNr.Location = new System.Drawing.Point(124, 6);
            this.txtAccNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccNr.Name = "txtAccNr";
            this.txtAccNr.Size = new System.Drawing.Size(76, 20);
            this.txtAccNr.TabIndex = 8;
            // 
            // lblNrOcc
            // 
            this.lblNrOcc.AutoSize = true;
            this.lblNrOcc.Location = new System.Drawing.Point(4, 68);
            this.lblNrOcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNrOcc.Name = "lblNrOcc";
            this.lblNrOcc.Size = new System.Drawing.Size(109, 13);
            this.lblNrOcc.TabIndex = 7;
            this.lblNrOcc.Text = "Number of occupants";
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Location = new System.Drawing.Point(81, 36);
            this.lblAccType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(31, 13);
            this.lblAccType.TabIndex = 6;
            this.lblAccType.Text = "Type";
            // 
            // btnDeleteAccomm
            // 
            this.btnDeleteAccomm.Location = new System.Drawing.Point(6, 112);
            this.btnDeleteAccomm.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccomm.Name = "btnDeleteAccomm";
            this.btnDeleteAccomm.Size = new System.Drawing.Size(194, 47);
            this.btnDeleteAccomm.TabIndex = 4;
            this.btnDeleteAccomm.Text = "Delete";
            this.btnDeleteAccomm.UseVisualStyleBackColor = true;
            this.btnDeleteAccomm.Click += new System.EventHandler(this.btnDeleteAccomm_Click);
            // 
            // lblAccNr
            // 
            this.lblAccNr.AutoSize = true;
            this.lblAccNr.Location = new System.Drawing.Point(22, 11);
            this.lblAccNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccNr.Name = "lblAccNr";
            this.lblAccNr.Size = new System.Drawing.Size(91, 13);
            this.lblAccNr.TabIndex = 5;
            this.lblAccNr.Text = "Accommdation Nr";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Controls.Add(this.dgView);
            this.pnlGrid.Location = new System.Drawing.Point(265, 45);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(536, 339);
            this.pnlGrid.TabIndex = 18;
            // 
            // dgView
            // 
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(0, 0);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 51;
            this.dgView.Size = new System.Drawing.Size(536, 339);
            this.dgView.TabIndex = 17;
            this.dgView.SelectionChanged += new System.EventHandler(this.dgView_SelectionChanged);
            // 
            // frmDeleteAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 449);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDeleteAccommodation";
            this.Text = "frmDeleteAccommodation_1_";
            this.Load += new System.EventHandler(this.frmDeleteAccommodation_Load_1);
            this.panelChildForm.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDeleteAccomm;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtNrOcc;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAccNr;
        private System.Windows.Forms.Label lblNrOcc;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblAccNr;
    }
}