
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
            this.components = new System.ComponentModel.Container();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlDatagrid = new System.Windows.Forms.Panel();
            this.dataGridViewAccom = new System.Windows.Forms.DataGridView();
            this.errorProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOccupants = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.pnlConnetionControls = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
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
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.pnlDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOccupants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.pnlGroupBoxSearch.SuspendLayout();
            this.pnlConnetionControls.SuspendLayout();
            this.gBoxAccom.SuspendLayout();
            this.pnlGroupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(945, 562);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 3;
            this.picBackground.TabStop = false;
            // 
            // pnlDatagrid
            // 
            this.pnlDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatagrid.Controls.Add(this.dataGridViewAccom);
            this.pnlDatagrid.Location = new System.Drawing.Point(391, 12);
            this.pnlDatagrid.Name = "pnlDatagrid";
            this.pnlDatagrid.Size = new System.Drawing.Size(542, 538);
            this.pnlDatagrid.TabIndex = 4;
            // 
            // dataGridViewAccom
            // 
            this.dataGridViewAccom.AllowUserToResizeRows = false;
            this.dataGridViewAccom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccom.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAccom.Name = "dataGridViewAccom";
            this.dataGridViewAccom.ReadOnly = true;
            this.dataGridViewAccom.RowHeadersVisible = false;
            this.dataGridViewAccom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccom.Size = new System.Drawing.Size(542, 538);
            this.dataGridViewAccom.TabIndex = 2;
            this.dataGridViewAccom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccom_CellClick);
            this.dataGridViewAccom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccom_CellContentClick);
            // 
            // errorProviderID
            // 
            this.errorProviderID.ContainerControl = this;
            // 
            // errorProviderType
            // 
            this.errorProviderType.ContainerControl = this;
            // 
            // errorProviderOccupants
            // 
            this.errorProviderOccupants.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            this.errorProviderPrice.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.groupBoxSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 184);
            this.panel1.TabIndex = 5;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.pnlGroupBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(16, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(336, 157);
            this.groupBoxSearch.TabIndex = 9;
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
            this.pnlGroupBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.pnlGroupBoxSearch.Name = "pnlGroupBoxSearch";
            this.pnlGroupBoxSearch.Size = new System.Drawing.Size(310, 132);
            this.pnlGroupBoxSearch.TabIndex = 0;
            // 
            // lblSearchPrice
            // 
            this.lblSearchPrice.AutoSize = true;
            this.lblSearchPrice.Location = new System.Drawing.Point(16, 103);
            this.lblSearchPrice.Name = "lblSearchPrice";
            this.lblSearchPrice.Size = new System.Drawing.Size(113, 13);
            this.lblSearchPrice.TabIndex = 22;
            this.lblSearchPrice.Text = "Accommodation Price:";
            // 
            // txtsearchPrice
            // 
            this.txtsearchPrice.Location = new System.Drawing.Point(167, 99);
            this.txtsearchPrice.Name = "txtsearchPrice";
            this.txtsearchPrice.Size = new System.Drawing.Size(134, 20);
            this.txtsearchPrice.TabIndex = 21;
            // 
            // lblSearchOccupants
            // 
            this.lblSearchOccupants.AutoSize = true;
            this.lblSearchOccupants.Location = new System.Drawing.Point(40, 68);
            this.lblSearchOccupants.Name = "lblSearchOccupants";
            this.lblSearchOccupants.Size = new System.Drawing.Size(89, 13);
            this.lblSearchOccupants.TabIndex = 20;
            this.lblSearchOccupants.Text = "Total Occupants:";
            // 
            // txtSearchOccupants
            // 
            this.txtSearchOccupants.Location = new System.Drawing.Point(167, 64);
            this.txtSearchOccupants.Name = "txtSearchOccupants";
            this.txtSearchOccupants.Size = new System.Drawing.Size(134, 20);
            this.txtSearchOccupants.TabIndex = 19;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(16, 35);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(113, 13);
            this.lblSearchType.TabIndex = 18;
            this.lblSearchType.Text = "Accommodation Type:";
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(167, 31);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(134, 20);
            this.txtSearchType.TabIndex = 17;
            // 
            // lblsearchID
            // 
            this.lblsearchID.AutoSize = true;
            this.lblsearchID.Location = new System.Drawing.Point(29, 3);
            this.lblsearchID.Name = "lblsearchID";
            this.lblsearchID.Size = new System.Drawing.Size(100, 13);
            this.lblsearchID.TabIndex = 16;
            this.lblsearchID.Text = "Accommodation ID:";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(167, 3);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(134, 20);
            this.txtSearchID.TabIndex = 14;
            // 
            // pnlConnetionControls
            // 
            this.pnlConnetionControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlConnetionControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.pnlConnetionControls.Controls.Add(this.btnNext);
            this.pnlConnetionControls.Controls.Add(this.btnUpdate);
            this.pnlConnetionControls.Controls.Add(this.btnPrev);
            this.pnlConnetionControls.Controls.Add(this.btnReset);
            this.pnlConnetionControls.Controls.Add(this.gBoxAccom);
            this.pnlConnetionControls.Location = new System.Drawing.Point(12, 224);
            this.pnlConnetionControls.Name = "pnlConnetionControls";
            this.pnlConnetionControls.Size = new System.Drawing.Size(373, 326);
            this.pnlConnetionControls.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 144);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(90, 72);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(115, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 36);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gBoxAccom
            // 
            this.gBoxAccom.Controls.Add(this.pnlGroupBoxDetails);
            this.gBoxAccom.Location = new System.Drawing.Point(16, 3);
            this.gBoxAccom.Name = "gBoxAccom";
            this.gBoxAccom.Size = new System.Drawing.Size(336, 135);
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
            this.pnlGroupBoxDetails.Location = new System.Drawing.Point(6, 11);
            this.pnlGroupBoxDetails.Name = "pnlGroupBoxDetails";
            this.pnlGroupBoxDetails.Size = new System.Drawing.Size(311, 118);
            this.pnlGroupBoxDetails.TabIndex = 0;
            // 
            // lblAccomPrice
            // 
            this.lblAccomPrice.AutoSize = true;
            this.lblAccomPrice.Location = new System.Drawing.Point(15, 89);
            this.lblAccomPrice.Name = "lblAccomPrice";
            this.lblAccomPrice.Size = new System.Drawing.Size(113, 13);
            this.lblAccomPrice.TabIndex = 15;
            this.lblAccomPrice.Text = "Accommodation Price:";
            // 
            // lblTotalOccupants
            // 
            this.lblTotalOccupants.AutoSize = true;
            this.lblTotalOccupants.Location = new System.Drawing.Point(39, 63);
            this.lblTotalOccupants.Name = "lblTotalOccupants";
            this.lblTotalOccupants.Size = new System.Drawing.Size(89, 13);
            this.lblTotalOccupants.TabIndex = 14;
            this.lblTotalOccupants.Text = "Total Occupants:";
            // 
            // txtAPrice
            // 
            this.txtAPrice.Location = new System.Drawing.Point(166, 86);
            this.txtAPrice.Name = "txtAPrice";
            this.txtAPrice.Size = new System.Drawing.Size(134, 20);
            this.txtAPrice.TabIndex = 13;
            // 
            // txtAOccupants
            // 
            this.txtAOccupants.Location = new System.Drawing.Point(166, 60);
            this.txtAOccupants.Name = "txtAOccupants";
            this.txtAOccupants.Size = new System.Drawing.Size(134, 20);
            this.txtAOccupants.TabIndex = 12;
            // 
            // txtAType
            // 
            this.txtAType.Location = new System.Drawing.Point(166, 34);
            this.txtAType.Name = "txtAType";
            this.txtAType.Size = new System.Drawing.Size(134, 20);
            this.txtAType.TabIndex = 11;
            // 
            // lblAccomType
            // 
            this.lblAccomType.AutoSize = true;
            this.lblAccomType.Location = new System.Drawing.Point(15, 37);
            this.lblAccomType.Name = "lblAccomType";
            this.lblAccomType.Size = new System.Drawing.Size(113, 13);
            this.lblAccomType.TabIndex = 10;
            this.lblAccomType.Text = "Accommodation Type:";
            // 
            // lblAccomID
            // 
            this.lblAccomID.AutoSize = true;
            this.lblAccomID.Location = new System.Drawing.Point(28, 11);
            this.lblAccomID.Name = "lblAccomID";
            this.lblAccomID.Size = new System.Drawing.Size(100, 13);
            this.lblAccomID.TabIndex = 9;
            this.lblAccomID.Text = "Accommodation ID:";
            // 
            // txtAID
            // 
            this.txtAID.Location = new System.Drawing.Point(166, 8);
            this.txtAID.Name = "txtAID";
            this.txtAID.Size = new System.Drawing.Size(134, 20);
            this.txtAID.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(262, 144);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 72);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmUpdateAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 562);
            this.Controls.Add(this.pnlConnetionControls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDatagrid);
            this.Controls.Add(this.picBackground);
            this.Name = "frmUpdateAccommodations";
            this.Text = "frmUpdateAccommodations";
            this.Load += new System.EventHandler(this.frmUpdateAccommodations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.pnlDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOccupants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.pnlGroupBoxSearch.ResumeLayout(false);
            this.pnlGroupBoxSearch.PerformLayout();
            this.pnlConnetionControls.ResumeLayout(false);
            this.gBoxAccom.ResumeLayout(false);
            this.pnlGroupBoxDetails.ResumeLayout(false);
            this.pnlGroupBoxDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel pnlDatagrid;
        private System.Windows.Forms.ErrorProvider errorProviderID;
        private System.Windows.Forms.ErrorProvider errorProviderType;
        private System.Windows.Forms.ErrorProvider errorProviderOccupants;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel pnlConnetionControls;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrev;
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
        private System.Windows.Forms.DataGridView dataGridViewAccom;
        private System.Windows.Forms.Button btnNext;
    }
}