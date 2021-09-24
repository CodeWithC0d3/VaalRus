
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
            this.pnlConnetionControls = new System.Windows.Forms.Panel();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewAccom = new System.Windows.Forms.DataGridView();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gBoxAccom = new System.Windows.Forms.GroupBox();
            this.pnlGroupBoxDetails = new System.Windows.Forms.Panel();
            this.lblAccomPrice = new System.Windows.Forms.Label();
            this.lblTotalOccupants = new System.Windows.Forms.Label();
            this.txtAPrice = new System.Windows.Forms.TextBox();
            this.txtAOccupants = new System.Windows.Forms.TextBox();
            this.txtAType = new System.Windows.Forms.TextBox();
            this.lblAccomType = new System.Windows.Forms.Label();
            this.lblAccomID = new System.Windows.Forms.Label();
            this.txtAID = new System.Windows.Forms.TextBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlConnetionControls.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.pnlGroupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccom)).BeginInit();
            this.gBoxAccom.SuspendLayout();
            this.pnlGroupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConnetionControls
            // 
            this.pnlConnetionControls.Controls.Add(this.groupBoxSearch);
            this.pnlConnetionControls.Controls.Add(this.btnUpdate);
            this.pnlConnetionControls.Controls.Add(this.dataGridViewAccom);
            this.pnlConnetionControls.Controls.Add(this.btnPrev);
            this.pnlConnetionControls.Controls.Add(this.btnNext);
            this.pnlConnetionControls.Controls.Add(this.btnReset);
            this.pnlConnetionControls.Controls.Add(this.gBoxAccom);
            this.pnlConnetionControls.Location = new System.Drawing.Point(12, 12);
            this.pnlConnetionControls.Name = "pnlConnetionControls";
            this.pnlConnetionControls.Size = new System.Drawing.Size(752, 432);
            this.pnlConnetionControls.TabIndex = 1;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.pnlGroupBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(426, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(295, 213);
            this.groupBoxSearch.TabIndex = 8;
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
            this.pnlGroupBoxSearch.Location = new System.Drawing.Point(29, 9);
            this.pnlGroupBoxSearch.Name = "pnlGroupBoxSearch";
            this.pnlGroupBoxSearch.Size = new System.Drawing.Size(235, 204);
            this.pnlGroupBoxSearch.TabIndex = 0;
            // 
            // lblSearchPrice
            // 
            this.lblSearchPrice.AutoSize = true;
            this.lblSearchPrice.Location = new System.Drawing.Point(11, 155);
            this.lblSearchPrice.Name = "lblSearchPrice";
            this.lblSearchPrice.Size = new System.Drawing.Size(113, 13);
            this.lblSearchPrice.TabIndex = 22;
            this.lblSearchPrice.Text = "Accommodation Price:";
            // 
            // txtsearchPrice
            // 
            this.txtsearchPrice.Location = new System.Drawing.Point(11, 177);
            this.txtsearchPrice.Name = "txtsearchPrice";
            this.txtsearchPrice.Size = new System.Drawing.Size(207, 20);
            this.txtsearchPrice.TabIndex = 21;
            this.txtsearchPrice.TextChanged += new System.EventHandler(this.txtsearchPrice_TextChanged);
            // 
            // lblSearchOccupants
            // 
            this.lblSearchOccupants.AutoSize = true;
            this.lblSearchOccupants.Location = new System.Drawing.Point(35, 102);
            this.lblSearchOccupants.Name = "lblSearchOccupants";
            this.lblSearchOccupants.Size = new System.Drawing.Size(89, 13);
            this.lblSearchOccupants.TabIndex = 20;
            this.lblSearchOccupants.Text = "Total Occupants:";
            // 
            // txtSearchOccupants
            // 
            this.txtSearchOccupants.Location = new System.Drawing.Point(11, 122);
            this.txtSearchOccupants.Name = "txtSearchOccupants";
            this.txtSearchOccupants.Size = new System.Drawing.Size(207, 20);
            this.txtSearchOccupants.TabIndex = 19;
            this.txtSearchOccupants.TextChanged += new System.EventHandler(this.txtSearchOccupants_TextChanged);
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(11, 50);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(113, 13);
            this.lblSearchType.TabIndex = 18;
            this.lblSearchType.Text = "Accommodation Type:";
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(11, 72);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(207, 20);
            this.txtSearchType.TabIndex = 17;
            this.txtSearchType.TextChanged += new System.EventHandler(this.txtSearchType_TextChanged);
            // 
            // lblsearchID
            // 
            this.lblsearchID.AutoSize = true;
            this.lblsearchID.Location = new System.Drawing.Point(24, 2);
            this.lblsearchID.Name = "lblsearchID";
            this.lblsearchID.Size = new System.Drawing.Size(100, 13);
            this.lblsearchID.TabIndex = 16;
            this.lblsearchID.Text = "Accommodation ID:";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(11, 23);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(207, 20);
            this.txtSearchID.TabIndex = 14;
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAccom
            // 
            this.dataGridViewAccom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccom.Location = new System.Drawing.Point(3, 222);
            this.dataGridViewAccom.Name = "dataGridViewAccom";
            this.dataGridViewAccom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccom.Size = new System.Drawing.Size(746, 207);
            this.dataGridViewAccom.TabIndex = 2;
            this.dataGridViewAccom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccom_CellClick);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(19, 144);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(110, 72);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(292, 144);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 72);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(135, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 36);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gBoxAccom
            // 
            this.gBoxAccom.Controls.Add(this.pnlGroupBoxDetails);
            this.gBoxAccom.Location = new System.Drawing.Point(19, 3);
            this.gBoxAccom.Name = "gBoxAccom";
            this.gBoxAccom.Size = new System.Drawing.Size(384, 135);
            this.gBoxAccom.TabIndex = 1;
            this.gBoxAccom.TabStop = false;
            this.gBoxAccom.Text = "Accommodation Details:";
            // 
            // pnlGroupBoxDetails
            // 
            this.pnlGroupBoxDetails.Controls.Add(this.lblAccomPrice);
            this.pnlGroupBoxDetails.Controls.Add(this.lblTotalOccupants);
            this.pnlGroupBoxDetails.Controls.Add(this.txtAPrice);
            this.pnlGroupBoxDetails.Controls.Add(this.txtAOccupants);
            this.pnlGroupBoxDetails.Controls.Add(this.txtAType);
            this.pnlGroupBoxDetails.Controls.Add(this.lblAccomType);
            this.pnlGroupBoxDetails.Controls.Add(this.lblAccomID);
            this.pnlGroupBoxDetails.Controls.Add(this.txtAID);
            this.pnlGroupBoxDetails.Location = new System.Drawing.Point(3, 11);
            this.pnlGroupBoxDetails.Name = "pnlGroupBoxDetails";
            this.pnlGroupBoxDetails.Size = new System.Drawing.Size(386, 124);
            this.pnlGroupBoxDetails.TabIndex = 0;
            // 
            // lblAccomPrice
            // 
            this.lblAccomPrice.AutoSize = true;
            this.lblAccomPrice.Location = new System.Drawing.Point(45, 96);
            this.lblAccomPrice.Name = "lblAccomPrice";
            this.lblAccomPrice.Size = new System.Drawing.Size(113, 13);
            this.lblAccomPrice.TabIndex = 15;
            this.lblAccomPrice.Text = "Accommodation Price:";
            // 
            // lblTotalOccupants
            // 
            this.lblTotalOccupants.AutoSize = true;
            this.lblTotalOccupants.Location = new System.Drawing.Point(69, 70);
            this.lblTotalOccupants.Name = "lblTotalOccupants";
            this.lblTotalOccupants.Size = new System.Drawing.Size(89, 13);
            this.lblTotalOccupants.TabIndex = 14;
            this.lblTotalOccupants.Text = "Total Occupants:";
            // 
            // txtAPrice
            // 
            this.txtAPrice.Location = new System.Drawing.Point(196, 93);
            this.txtAPrice.Name = "txtAPrice";
            this.txtAPrice.Size = new System.Drawing.Size(134, 20);
            this.txtAPrice.TabIndex = 13;
            // 
            // txtAOccupants
            // 
            this.txtAOccupants.Location = new System.Drawing.Point(196, 67);
            this.txtAOccupants.Name = "txtAOccupants";
            this.txtAOccupants.Size = new System.Drawing.Size(134, 20);
            this.txtAOccupants.TabIndex = 12;
            // 
            // txtAType
            // 
            this.txtAType.Location = new System.Drawing.Point(196, 41);
            this.txtAType.Name = "txtAType";
            this.txtAType.Size = new System.Drawing.Size(134, 20);
            this.txtAType.TabIndex = 11;
            // 
            // lblAccomType
            // 
            this.lblAccomType.AutoSize = true;
            this.lblAccomType.Location = new System.Drawing.Point(45, 44);
            this.lblAccomType.Name = "lblAccomType";
            this.lblAccomType.Size = new System.Drawing.Size(113, 13);
            this.lblAccomType.TabIndex = 10;
            this.lblAccomType.Text = "Accommodation Type:";
            // 
            // lblAccomID
            // 
            this.lblAccomID.AutoSize = true;
            this.lblAccomID.Location = new System.Drawing.Point(58, 18);
            this.lblAccomID.Name = "lblAccomID";
            this.lblAccomID.Size = new System.Drawing.Size(100, 13);
            this.lblAccomID.TabIndex = 9;
            this.lblAccomID.Text = "Accommodation ID:";
            // 
            // txtAID
            // 
            this.txtAID.Location = new System.Drawing.Point(196, 15);
            this.txtAID.Name = "txtAID";
            this.txtAID.Size = new System.Drawing.Size(134, 20);
            this.txtAID.TabIndex = 8;
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(800, 533);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 3;
            this.picBackground.TabStop = false;
            // 
            // frmUpdateAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.pnlConnetionControls);
            this.Controls.Add(this.picBackground);
            this.Name = "frmUpdateAccommodations";
            this.Text = "frmUpdateAccommodations";
            this.Load += new System.EventHandler(this.frmUpdateAccommodations_Load);
            this.pnlConnetionControls.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.pnlGroupBoxSearch.ResumeLayout(false);
            this.pnlGroupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccom)).EndInit();
            this.gBoxAccom.ResumeLayout(false);
            this.pnlGroupBoxDetails.ResumeLayout(false);
            this.pnlGroupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtAPrice;
        private System.Windows.Forms.TextBox txtAOccupants;
        private System.Windows.Forms.TextBox txtAType;
        private System.Windows.Forms.Label lblAccomType;
        private System.Windows.Forms.Label lblAccomID;
        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.PictureBox picBackground;
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