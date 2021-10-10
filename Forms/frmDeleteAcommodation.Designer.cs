
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
            this.btnDeleteAccomm = new System.Windows.Forms.Button();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.btnDisplayAccomm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAccNr = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.lblNrOcc = new System.Windows.Forms.Label();
            this.txtAccNr = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNrOcc = new System.Windows.Forms.TextBox();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelChildForm.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.panel4);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1090, 553);
            this.panelChildForm.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtNrOcc);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtAccNr);
            this.panel1.Controls.Add(this.lblNrOcc);
            this.panel1.Controls.Add(this.lblAccType);
            this.panel1.Controls.Add(this.btnDeleteAccomm);
            this.panel1.Controls.Add(this.lblAccNr);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(28, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 447);
            this.panel1.TabIndex = 19;
            // 
            // lblSearchNumber
            // 
            this.lblSearchNumber.AutoSize = true;
            this.lblSearchNumber.Location = new System.Drawing.Point(3, 66);
            this.lblSearchNumber.Name = "lblSearchNumber";
            this.lblSearchNumber.Size = new System.Drawing.Size(131, 17);
            this.lblSearchNumber.TabIndex = 6;
            this.lblSearchNumber.Text = "Accommodation Nr:";
            // 
            // btnDeleteAccomm
            // 
            this.btnDeleteAccomm.Location = new System.Drawing.Point(8, 138);
            this.btnDeleteAccomm.Name = "btnDeleteAccomm";
            this.btnDeleteAccomm.Size = new System.Drawing.Size(258, 58);
            this.btnDeleteAccomm.TabIndex = 4;
            this.btnDeleteAccomm.Text = "Delete";
            this.btnDeleteAccomm.UseVisualStyleBackColor = true;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(3, 25);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(98, 17);
            this.lblSearchType.TabIndex = 2;
            this.lblSearchType.Text = "Filter by Type:";
            // 
            // btnDisplayAccomm
            // 
            this.btnDisplayAccomm.Location = new System.Drawing.Point(267, 27);
            this.btnDisplayAccomm.Name = "btnDisplayAccomm";
            this.btnDisplayAccomm.Size = new System.Drawing.Size(78, 58);
            this.btnDisplayAccomm.TabIndex = 0;
            this.btnDisplayAccomm.Text = "Display";
            this.btnDisplayAccomm.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgView);
            this.panel4.Location = new System.Drawing.Point(353, 137);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(714, 336);
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
            this.dgView.Size = new System.Drawing.Size(714, 336);
            this.dgView.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblSearchNumber);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.lblSearchType);
            this.panel2.Controls.Add(this.btnDisplayAccomm);
            this.panel2.Location = new System.Drawing.Point(353, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 100);
            this.panel2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // lblAccNr
            // 
            this.lblAccNr.AutoSize = true;
            this.lblAccNr.Location = new System.Drawing.Point(29, 13);
            this.lblAccNr.Name = "lblAccNr";
            this.lblAccNr.Size = new System.Drawing.Size(119, 17);
            this.lblAccNr.TabIndex = 5;
            this.lblAccNr.Text = "Accommdation Nr";
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Location = new System.Drawing.Point(108, 44);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(40, 17);
            this.lblAccType.TabIndex = 6;
            this.lblAccType.Text = "Type";
            // 
            // lblNrOcc
            // 
            this.lblNrOcc.AutoSize = true;
            this.lblNrOcc.Location = new System.Drawing.Point(5, 84);
            this.lblNrOcc.Name = "lblNrOcc";
            this.lblNrOcc.Size = new System.Drawing.Size(143, 17);
            this.lblNrOcc.TabIndex = 7;
            this.lblNrOcc.Text = "Number of occupants";
            // 
            // txtAccNr
            // 
            this.txtAccNr.Location = new System.Drawing.Point(166, 8);
            this.txtAccNr.Name = "txtAccNr";
            this.txtAccNr.Size = new System.Drawing.Size(100, 22);
            this.txtAccNr.TabIndex = 8;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(166, 44);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 9;
            // 
            // txtNrOcc
            // 
            this.txtNrOcc.Location = new System.Drawing.Point(166, 81);
            this.txtNrOcc.Name = "txtNrOcc";
            this.txtNrOcc.Size = new System.Drawing.Size(100, 22);
            this.txtNrOcc.TabIndex = 10;
            // 
            // frmDeleteAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 553);
            this.Controls.Add(this.panelChildForm);
            this.Name = "frmDeleteAccommodation";
            this.Text = "frmDeleteAccommodation_1_";
            this.panelChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchNumber;
        private System.Windows.Forms.Button btnDeleteAccomm;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Button btnDisplayAccomm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNrOcc;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAccNr;
        private System.Windows.Forms.Label lblNrOcc;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblAccNr;
    }
}