
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
            this.dgvDeleteAccomm = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteAccomm = new System.Windows.Forms.Button();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.btnDisplayAccomm = new System.Windows.Forms.Button();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.lblSearchNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteAccomm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeleteAccomm
            // 
            this.dgvDeleteAccomm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteAccomm.Location = new System.Drawing.Point(467, 21);
            this.dgvDeleteAccomm.Name = "dgvDeleteAccomm";
            this.dgvDeleteAccomm.RowHeadersWidth = 51;
            this.dgvDeleteAccomm.RowTemplate.Height = 24;
            this.dgvDeleteAccomm.Size = new System.Drawing.Size(586, 520);
            this.dgvDeleteAccomm.TabIndex = 1;
            this.dgvDeleteAccomm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearchNumber);
            this.panel1.Controls.Add(this.txtBoxNumber);
            this.panel1.Controls.Add(this.btnDeleteAccomm);
            this.panel1.Controls.Add(this.txtBoxType);
            this.panel1.Controls.Add(this.lblSearchType);
            this.panel1.Controls.Add(this.btnDisplayAccomm);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 386);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.lblSearchType.Click += new System.EventHandler(this.label1_Click);
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
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(45, 155);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(344, 22);
            this.txtBoxNumber.TabIndex = 5;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 598);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDeleteAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDeleteAccomm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDeleteAccommodation";
            this.Text = "frmDeleteAccommodation";
            this.Load += new System.EventHandler(this.frmDeleteAccommodation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteAccomm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDeleteAccomm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteAccomm;
        private System.Windows.Forms.TextBox txtBoxType;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Button btnDisplayAccomm;
        private System.Windows.Forms.Label lblSearchNumber;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}