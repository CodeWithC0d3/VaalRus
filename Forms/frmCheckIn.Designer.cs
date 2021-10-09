
namespace vaalrusGUIPrototype
{
    partial class frmCheckIn
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
            this.dtgCheckIn = new System.Windows.Forms.DataGridView();
            this.pnlCheckIn = new System.Windows.Forms.Panel();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnDisplayBook = new System.Windows.Forms.Button();
            this.rbIDnum = new System.Windows.Forms.RadioButton();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.tbIDNum = new System.Windows.Forms.TextBox();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIDNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckIn)).BeginInit();
            this.pnlCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIDNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCheckIn
            // 
            this.dtgCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCheckIn.Location = new System.Drawing.Point(0, 0);
            this.dtgCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCheckIn.Name = "dtgCheckIn";
            this.dtgCheckIn.RowHeadersWidth = 51;
            this.dtgCheckIn.RowTemplate.Height = 24;
            this.dtgCheckIn.Size = new System.Drawing.Size(609, 411);
            this.dtgCheckIn.TabIndex = 0;
            this.dtgCheckIn.SelectionChanged += new System.EventHandler(this.dtgCheckIn_SelectionChanged);
            // 
            // pnlCheckIn
            // 
            this.pnlCheckIn.Controls.Add(this.tbBookID);
            this.pnlCheckIn.Controls.Add(this.btnCheckIn);
            this.pnlCheckIn.Controls.Add(this.label2);
            this.pnlCheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCheckIn.Location = new System.Drawing.Point(0, 139);
            this.pnlCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCheckIn.Name = "pnlCheckIn";
            this.pnlCheckIn.Size = new System.Drawing.Size(286, 189);
            this.pnlCheckIn.TabIndex = 1;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(119, 55);
            this.tbBookID.Margin = new System.Windows.Forms.Padding(2);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(36, 20);
            this.tbBookID.TabIndex = 5;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(74, 109);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(113, 54);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verify Select Booking ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(2, 70);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(275, 44);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(149, 37);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(128, 20);
            this.tbLastName.TabIndex = 7;
            // 
            // btnDisplayBook
            // 
            this.btnDisplayBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisplayBook.Location = new System.Drawing.Point(5, 15);
            this.btnDisplayBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplayBook.Name = "btnDisplayBook";
            this.btnDisplayBook.Size = new System.Drawing.Size(275, 44);
            this.btnDisplayBook.TabIndex = 1;
            this.btnDisplayBook.Text = "Display Bookings ?";
            this.btnDisplayBook.UseVisualStyleBackColor = true;
            this.btnDisplayBook.Click += new System.EventHandler(this.btnDisplayBook_Click);
            // 
            // rbIDnum
            // 
            this.rbIDnum.AutoSize = true;
            this.rbIDnum.Location = new System.Drawing.Point(11, 2);
            this.rbIDnum.Margin = new System.Windows.Forms.Padding(2);
            this.rbIDnum.Name = "rbIDnum";
            this.rbIDnum.Size = new System.Drawing.Size(107, 17);
            this.rbIDnum.TabIndex = 12;
            this.rbIDnum.TabStop = true;
            this.rbIDnum.Text = "Enter ID Number:";
            this.rbIDnum.UseVisualStyleBackColor = true;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(11, 40);
            this.rbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(107, 17);
            this.rbLastName.TabIndex = 11;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Enter Last Name:";
            this.rbLastName.UseVisualStyleBackColor = true;
            this.rbLastName.CheckedChanged += new System.EventHandler(this.rbLastName_CheckedChanged);
            // 
            // tbIDNum
            // 
            this.tbIDNum.Location = new System.Drawing.Point(149, 2);
            this.tbIDNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbIDNum.Name = "tbIDNum";
            this.tbIDNum.Size = new System.Drawing.Size(128, 20);
            this.tbIDNum.TabIndex = 9;
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // epIDNumber
            // 
            this.epIDNumber.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlCheckIn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 411);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDisplayBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 70);
            this.panel3.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH BY LAST NAME OR ID NUMBER:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtgCheckIn);
            this.panel2.Location = new System.Drawing.Point(304, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 411);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.tbIDNum);
            this.panel4.Controls.Add(this.rbLastName);
            this.panel4.Controls.Add(this.rbIDnum);
            this.panel4.Controls.Add(this.tbLastName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 120);
            this.panel4.TabIndex = 0;
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCheckIn";
            this.Text = "frmCheckIn";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckIn)).EndInit();
            this.pnlCheckIn.ResumeLayout(false);
            this.pnlCheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIDNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCheckIn;
        private System.Windows.Forms.Panel pnlCheckIn;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnDisplayBook;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbIDnum;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.TextBox tbIDNum;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epIDNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
    }
}