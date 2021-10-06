
namespace vaalrusGUIPrototype.Forms
{
    partial class frmAddAccommodation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccommodation));
            this.pictureBoxViewAllBookingsBackground = new System.Windows.Forms.PictureBox();
            this.pnlNewAccom = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlNewAccomDetails = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccomPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfOccupants = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDGrid = new System.Windows.Forms.Panel();
            this.dataGridAccommodations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).BeginInit();
            this.pnlNewAccom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlNewAccomDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfOccupants)).BeginInit();
            this.pnlDGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccommodations)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxViewAllBookingsBackground
            // 
            this.pictureBoxViewAllBookingsBackground.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBoxViewAllBookingsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxViewAllBookingsBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxViewAllBookingsBackground.Image")));
            this.pictureBoxViewAllBookingsBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxViewAllBookingsBackground.Name = "pictureBoxViewAllBookingsBackground";
            this.pictureBoxViewAllBookingsBackground.Size = new System.Drawing.Size(800, 601);
            this.pictureBoxViewAllBookingsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxViewAllBookingsBackground.TabIndex = 1;
            this.pictureBoxViewAllBookingsBackground.TabStop = false;
            // 
            // pnlNewAccom
            // 
            this.pnlNewAccom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.pnlNewAccom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewAccom.Controls.Add(this.btnCreate);
            this.pnlNewAccom.Controls.Add(this.groupBox1);
            this.pnlNewAccom.Location = new System.Drawing.Point(12, 12);
            this.pnlNewAccom.Name = "pnlNewAccom";
            this.pnlNewAccom.Size = new System.Drawing.Size(256, 273);
            this.pnlNewAccom.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(90, 218);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 43);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlNewAccomDetails);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Accommodation details:";
            // 
            // pnlNewAccomDetails
            // 
            this.pnlNewAccomDetails.Controls.Add(this.label4);
            this.pnlNewAccomDetails.Controls.Add(this.txtAccomPrice);
            this.pnlNewAccomDetails.Controls.Add(this.label3);
            this.pnlNewAccomDetails.Controls.Add(this.numOfOccupants);
            this.pnlNewAccomDetails.Controls.Add(this.label2);
            this.pnlNewAccomDetails.Controls.Add(this.cbAccomType);
            this.pnlNewAccomDetails.Controls.Add(this.label1);
            this.pnlNewAccomDetails.Location = new System.Drawing.Point(6, 19);
            this.pnlNewAccomDetails.Name = "pnlNewAccomDetails";
            this.pnlNewAccomDetails.Size = new System.Drawing.Size(211, 163);
            this.pnlNewAccomDetails.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "R";
            // 
            // txtAccomPrice
            // 
            this.txtAccomPrice.Location = new System.Drawing.Point(90, 127);
            this.txtAccomPrice.Name = "txtAccomPrice";
            this.txtAccomPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAccomPrice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Accommodation price:";
            // 
            // numOfOccupants
            // 
            this.numOfOccupants.Location = new System.Drawing.Point(130, 77);
            this.numOfOccupants.Name = "numOfOccupants";
            this.numOfOccupants.Size = new System.Drawing.Size(60, 20);
            this.numOfOccupants.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of occupants:";
            // 
            // cbAccomType
            // 
            this.cbAccomType.FormattingEnabled = true;
            this.cbAccomType.Location = new System.Drawing.Point(68, 25);
            this.cbAccomType.Name = "cbAccomType";
            this.cbAccomType.Size = new System.Drawing.Size(121, 21);
            this.cbAccomType.TabIndex = 8;
            this.cbAccomType.Text = " < None Selected >";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type of Accommodation:";
            // 
            // pnlDGrid
            // 
            this.pnlDGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDGrid.Controls.Add(this.dataGridAccommodations);
            this.pnlDGrid.Location = new System.Drawing.Point(294, 9);
            this.pnlDGrid.Name = "pnlDGrid";
            this.pnlDGrid.Size = new System.Drawing.Size(492, 563);
            this.pnlDGrid.TabIndex = 4;
            // 
            // dataGridAccommodations
            // 
            this.dataGridAccommodations.AllowUserToAddRows = false;
            this.dataGridAccommodations.AllowUserToDeleteRows = false;
            this.dataGridAccommodations.AllowUserToResizeRows = false;
            this.dataGridAccommodations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAccommodations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccommodations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccommodations.Location = new System.Drawing.Point(0, 0);
            this.dataGridAccommodations.Name = "dataGridAccommodations";
            this.dataGridAccommodations.ReadOnly = true;
            this.dataGridAccommodations.RowHeadersVisible = false;
            this.dataGridAccommodations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAccommodations.Size = new System.Drawing.Size(492, 563);
            this.dataGridAccommodations.TabIndex = 0;
            this.dataGridAccommodations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAccommodations_CellClick);
            // 
            // frmAddAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.pnlDGrid);
            this.Controls.Add(this.pnlNewAccom);
            this.Controls.Add(this.pictureBoxViewAllBookingsBackground);
            this.Name = "frmAddAccommodation";
            this.Text = "frmAddAccommodation";
            this.Load += new System.EventHandler(this.frmAddAccommodation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).EndInit();
            this.pnlNewAccom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlNewAccomDetails.ResumeLayout(false);
            this.pnlNewAccomDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfOccupants)).EndInit();
            this.pnlDGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccommodations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxViewAllBookingsBackground;
        private System.Windows.Forms.Panel pnlNewAccom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlNewAccomDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccomPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numOfOccupants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDGrid;
        private System.Windows.Forms.DataGridView dataGridAccommodations;
    }
}