
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
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.pnlDeleteDetails = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOccupants = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAccommID = new System.Windows.Forms.Label();
            this.pnlDGrid = new System.Windows.Forms.Panel();
            this.dataGridAccommodations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).BeginInit();
            this.pnlNewAccom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlNewAccomDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfOccupants)).BeginInit();
            this.pnlDelete.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.pnlDeleteDetails.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(47, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "R";
            // 
            // txtAccomPrice
            // 
            this.txtAccomPrice.Location = new System.Drawing.Point(68, 127);
            this.txtAccomPrice.Name = "txtAccomPrice";
            this.txtAccomPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAccomPrice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Accommodation price:";
            // 
            // numOfOccupants
            // 
            this.numOfOccupants.Location = new System.Drawing.Point(46, 77);
            this.numOfOccupants.Name = "numOfOccupants";
            this.numOfOccupants.Size = new System.Drawing.Size(47, 20);
            this.numOfOccupants.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of occupants:";
            // 
            // cbAccomType
            // 
            this.cbAccomType.FormattingEnabled = true;
            this.cbAccomType.Location = new System.Drawing.Point(46, 25);
            this.cbAccomType.Name = "cbAccomType";
            this.cbAccomType.Size = new System.Drawing.Size(121, 21);
            this.cbAccomType.TabIndex = 8;
            this.cbAccomType.Text = " < None Selected >";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type of Accommodation:";
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Controls.Add(this.groupBoxDelete);
            this.pnlDelete.Location = new System.Drawing.Point(12, 291);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(256, 281);
            this.pnlDelete.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(90, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 43);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.pnlDeleteDetails);
            this.groupBoxDelete.Location = new System.Drawing.Point(16, 17);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(223, 204);
            this.groupBoxDelete.TabIndex = 0;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Delete Accommodation details:";
            // 
            // pnlDeleteDetails
            // 
            this.pnlDeleteDetails.Controls.Add(this.lblPrice);
            this.pnlDeleteDetails.Controls.Add(this.lblOccupants);
            this.pnlDeleteDetails.Controls.Add(this.textBox4);
            this.pnlDeleteDetails.Controls.Add(this.textBox3);
            this.pnlDeleteDetails.Controls.Add(this.textBox2);
            this.pnlDeleteDetails.Controls.Add(this.textBox1);
            this.pnlDeleteDetails.Controls.Add(this.lblType);
            this.pnlDeleteDetails.Controls.Add(this.lblAccommID);
            this.pnlDeleteDetails.Location = new System.Drawing.Point(6, 19);
            this.pnlDeleteDetails.Name = "pnlDeleteDetails";
            this.pnlDeleteDetails.Size = new System.Drawing.Size(211, 179);
            this.pnlDeleteDetails.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(47, 122);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(113, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Accommodation Price:";
            // 
            // lblOccupants
            // 
            this.lblOccupants.AutoSize = true;
            this.lblOccupants.Location = new System.Drawing.Point(44, 83);
            this.lblOccupants.Name = "lblOccupants";
            this.lblOccupants.Size = new System.Drawing.Size(116, 13);
            this.lblOccupants.TabIndex = 16;
            this.lblOccupants.Text = "Number Of Occupants:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(47, 44);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(113, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Accommodation Type:";
            // 
            // lblAccommID
            // 
            this.lblAccommID.AutoSize = true;
            this.lblAccommID.Location = new System.Drawing.Point(55, 5);
            this.lblAccommID.Name = "lblAccommID";
            this.lblAccommID.Size = new System.Drawing.Size(100, 13);
            this.lblAccommID.TabIndex = 7;
            this.lblAccommID.Text = "Accommodation ID:";
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
            // 
            // frmAddAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.pnlDGrid);
            this.Controls.Add(this.pnlDelete);
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
            this.pnlDelete.ResumeLayout(false);
            this.groupBoxDelete.ResumeLayout(false);
            this.pnlDeleteDetails.ResumeLayout(false);
            this.pnlDeleteDetails.PerformLayout();
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
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Panel pnlDeleteDetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAccommID;
        private System.Windows.Forms.Panel pnlDGrid;
        private System.Windows.Forms.DataGridView dataGridAccommodations;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOccupants;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}