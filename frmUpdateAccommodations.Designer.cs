
namespace vaalrusGUIPrototype
{
    partial class frmUpdateAccommodations
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
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlConnetionControls = new System.Windows.Forms.Panel();
            this.dataGridViewAccom = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.gBoxAccom = new System.Windows.Forms.GroupBox();
            this.pnlGroupBoxDetails = new System.Windows.Forms.Panel();
            this.lblAccomPrice = new System.Windows.Forms.Label();
            this.lblTotalOccupants = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAccomType = new System.Windows.Forms.Label();
            this.lblAccomID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.pnlGroupBoxSearch = new System.Windows.Forms.Panel();
            this.lblSearchPrice = new System.Windows.Forms.Label();
            this.txtsearchPrice = new System.Windows.Forms.TextBox();
            this.lblSearchOccupants = new System.Windows.Forms.Label();
            this.txtSearchOccupants = new System.Windows.Forms.TextBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.txtSearchType = new System.Windows.Forms.TextBox();
            this.lblsearchID = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.pnlConnetionControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccom)).BeginInit();
            this.gBoxAccom.SuspendLayout();
            this.pnlGroupBoxDetails.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.pnlGroupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = global::vaalrusGUIPrototype.Properties.Resources.WallpaperDog_20455774;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(800, 533);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // pnlConnetionControls
            // 
            this.pnlConnetionControls.Controls.Add(this.groupBoxSearch);
            this.pnlConnetionControls.Controls.Add(this.btnPrev);
            this.pnlConnetionControls.Controls.Add(this.btnNext);
            this.pnlConnetionControls.Controls.Add(this.btnReset);
            this.pnlConnetionControls.Controls.Add(this.btnUpdate);
            this.pnlConnetionControls.Controls.Add(this.gBoxAccom);
            this.pnlConnetionControls.Location = new System.Drawing.Point(12, 12);
            this.pnlConnetionControls.Name = "pnlConnetionControls";
            this.pnlConnetionControls.Size = new System.Drawing.Size(752, 511);
            this.pnlConnetionControls.TabIndex = 1;
            // 
            // dataGridViewAccom
            // 
            this.dataGridViewAccom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccom.Location = new System.Drawing.Point(433, 13);
            this.dataGridViewAccom.Name = "dataGridViewAccom";
            this.dataGridViewAccom.Size = new System.Drawing.Size(355, 291);
            this.dataGridViewAccom.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(130, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 33);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(287, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 72);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(14, 220);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(110, 72);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // gBoxAccom
            // 
            this.gBoxAccom.Controls.Add(this.pnlGroupBoxDetails);
            this.gBoxAccom.Location = new System.Drawing.Point(14, 3);
            this.gBoxAccom.Name = "gBoxAccom";
            this.gBoxAccom.Size = new System.Drawing.Size(384, 211);
            this.gBoxAccom.TabIndex = 1;
            this.gBoxAccom.TabStop = false;
            this.gBoxAccom.Text = "Accommodation Details:";
            // 
            // pnlGroupBoxDetails
            // 
            this.pnlGroupBoxDetails.Controls.Add(this.lblAccomPrice);
            this.pnlGroupBoxDetails.Controls.Add(this.lblTotalOccupants);
            this.pnlGroupBoxDetails.Controls.Add(this.textBox4);
            this.pnlGroupBoxDetails.Controls.Add(this.textBox3);
            this.pnlGroupBoxDetails.Controls.Add(this.textBox2);
            this.pnlGroupBoxDetails.Controls.Add(this.lblAccomType);
            this.pnlGroupBoxDetails.Controls.Add(this.lblAccomID);
            this.pnlGroupBoxDetails.Controls.Add(this.textBox1);
            this.pnlGroupBoxDetails.Location = new System.Drawing.Point(3, 20);
            this.pnlGroupBoxDetails.Name = "pnlGroupBoxDetails";
            this.pnlGroupBoxDetails.Size = new System.Drawing.Size(386, 185);
            this.pnlGroupBoxDetails.TabIndex = 0;
            // 
            // lblAccomPrice
            // 
            this.lblAccomPrice.AutoSize = true;
            this.lblAccomPrice.Location = new System.Drawing.Point(13, 151);
            this.lblAccomPrice.Name = "lblAccomPrice";
            this.lblAccomPrice.Size = new System.Drawing.Size(113, 13);
            this.lblAccomPrice.TabIndex = 15;
            this.lblAccomPrice.Text = "Accommodation Price:";
            // 
            // lblTotalOccupants
            // 
            this.lblTotalOccupants.AutoSize = true;
            this.lblTotalOccupants.Location = new System.Drawing.Point(37, 109);
            this.lblTotalOccupants.Name = "lblTotalOccupants";
            this.lblTotalOccupants.Size = new System.Drawing.Size(89, 13);
            this.lblTotalOccupants.TabIndex = 14;
            this.lblTotalOccupants.Text = "Total Occupants:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 144);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 11;
            // 
            // lblAccomType
            // 
            this.lblAccomType.AutoSize = true;
            this.lblAccomType.Location = new System.Drawing.Point(13, 67);
            this.lblAccomType.Name = "lblAccomType";
            this.lblAccomType.Size = new System.Drawing.Size(113, 13);
            this.lblAccomType.TabIndex = 10;
            this.lblAccomType.Text = "Accommodation Type:";
            // 
            // lblAccomID
            // 
            this.lblAccomID.AutoSize = true;
            this.lblAccomID.Location = new System.Drawing.Point(26, 27);
            this.lblAccomID.Name = "lblAccomID";
            this.lblAccomID.Size = new System.Drawing.Size(100, 13);
            this.lblAccomID.TabIndex = 9;
            this.lblAccomID.Text = "Accommodation ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 8;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.pnlGroupBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(33, 307);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(703, 182);
            this.groupBoxSearch.TabIndex = 7;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search:";
            // 
            // pnlGroupBoxSearch
            // 
            this.pnlGroupBoxSearch.Controls.Add(this.lblSearchPrice);
            this.pnlGroupBoxSearch.Controls.Add(this.txtsearchPrice);
            this.pnlGroupBoxSearch.Controls.Add(this.lblSearchOccupants);
            this.pnlGroupBoxSearch.Controls.Add(this.txtSearchOccupants);
            this.pnlGroupBoxSearch.Controls.Add(this.lblSearchType);
            this.pnlGroupBoxSearch.Controls.Add(this.txtSearchType);
            this.pnlGroupBoxSearch.Controls.Add(this.lblsearchID);
            this.pnlGroupBoxSearch.Controls.Add(this.txtSearchID);
            this.pnlGroupBoxSearch.Location = new System.Drawing.Point(14, 18);
            this.pnlGroupBoxSearch.Name = "pnlGroupBoxSearch";
            this.pnlGroupBoxSearch.Size = new System.Drawing.Size(683, 157);
            this.pnlGroupBoxSearch.TabIndex = 0;
            // 
            // lblSearchPrice
            // 
            this.lblSearchPrice.AutoSize = true;
            this.lblSearchPrice.Location = new System.Drawing.Point(386, 78);
            this.lblSearchPrice.Name = "lblSearchPrice";
            this.lblSearchPrice.Size = new System.Drawing.Size(113, 13);
            this.lblSearchPrice.TabIndex = 22;
            this.lblSearchPrice.Text = "Accommodation Price:";
            // 
            // txtsearchPrice
            // 
            this.txtsearchPrice.Location = new System.Drawing.Point(389, 110);
            this.txtsearchPrice.Name = "txtsearchPrice";
            this.txtsearchPrice.Size = new System.Drawing.Size(207, 20);
            this.txtsearchPrice.TabIndex = 21;
            // 
            // lblSearchOccupants
            // 
            this.lblSearchOccupants.AutoSize = true;
            this.lblSearchOccupants.Location = new System.Drawing.Point(410, 13);
            this.lblSearchOccupants.Name = "lblSearchOccupants";
            this.lblSearchOccupants.Size = new System.Drawing.Size(89, 13);
            this.lblSearchOccupants.TabIndex = 20;
            this.lblSearchOccupants.Text = "Total Occupants:";
            // 
            // txtSearchOccupants
            // 
            this.txtSearchOccupants.Location = new System.Drawing.Point(389, 40);
            this.txtSearchOccupants.Name = "txtSearchOccupants";
            this.txtSearchOccupants.Size = new System.Drawing.Size(207, 20);
            this.txtSearchOccupants.TabIndex = 19;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(72, 78);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(113, 13);
            this.lblSearchType.TabIndex = 18;
            this.lblSearchType.Text = "Accommodation Type:";
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(72, 110);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(207, 20);
            this.txtSearchType.TabIndex = 17;
            // 
            // lblsearchID
            // 
            this.lblsearchID.AutoSize = true;
            this.lblsearchID.Location = new System.Drawing.Point(85, 13);
            this.lblsearchID.Name = "lblsearchID";
            this.lblsearchID.Size = new System.Drawing.Size(100, 13);
            this.lblsearchID.TabIndex = 16;
            this.lblsearchID.Text = "Accommodation ID:";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(72, 40);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(207, 20);
            this.txtSearchID.TabIndex = 14;
            // 
            // frmUpdateAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.dataGridViewAccom);
            this.Controls.Add(this.pnlConnetionControls);
            this.Controls.Add(this.picBackground);
            this.Name = "frmUpdateAccommodations";
            this.Text = "frmUpdateAccommodations";
            this.Load += new System.EventHandler(this.frmUpdateAccommodations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.pnlConnetionControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccom)).EndInit();
            this.gBoxAccom.ResumeLayout(false);
            this.pnlGroupBoxDetails.ResumeLayout(false);
            this.pnlGroupBoxDetails.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.pnlGroupBoxSearch.ResumeLayout(false);
            this.pnlGroupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel pnlConnetionControls;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewAccom;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gBoxAccom;
        private System.Windows.Forms.Panel pnlGroupBoxDetails;
        private System.Windows.Forms.Label lblAccomPrice;
        private System.Windows.Forms.Label lblTotalOccupants;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAccomType;
        private System.Windows.Forms.Label lblAccomID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Panel pnlGroupBoxSearch;
        private System.Windows.Forms.Label lblSearchPrice;
        private System.Windows.Forms.TextBox txtsearchPrice;
        private System.Windows.Forms.Label lblSearchOccupants;
        private System.Windows.Forms.TextBox txtSearchOccupants;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.TextBox txtSearchType;
        private System.Windows.Forms.Label lblsearchID;
        private System.Windows.Forms.TextBox txtSearchID;
    }
}