
namespace vaalrusGUIPrototype
{
    partial class frmCheckOut
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
            this.dtgCheckOut = new System.Windows.Forms.DataGridView();
            this.pnlCheckOut = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnDisplayBook = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tbIDNum = new System.Windows.Forms.TextBox();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.rbIDnum = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckOut)).BeginInit();
            this.pnlCheckOut.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCheckOut
            // 
            this.dtgCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCheckOut.Location = new System.Drawing.Point(433, 229);
            this.dtgCheckOut.Name = "dtgCheckOut";
            this.dtgCheckOut.RowHeadersWidth = 51;
            this.dtgCheckOut.RowTemplate.Height = 24;
            this.dtgCheckOut.Size = new System.Drawing.Size(548, 341);
            this.dtgCheckOut.TabIndex = 0;
            this.dtgCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCheckOut_CellContentClick);
            this.dtgCheckOut.SelectionChanged += new System.EventHandler(this.dtgCheckOut_SelectionChanged);
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.Controls.Add(this.tbBookID);
            this.pnlCheckOut.Controls.Add(this.label2);
            this.pnlCheckOut.Controls.Add(this.btnCheckout);
            this.pnlCheckOut.Location = new System.Drawing.Point(12, 239);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(378, 292);
            this.pnlCheckOut.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(809, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 92);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(602, 10);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(170, 22);
            this.tbLastName.TabIndex = 7;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(159, 80);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(47, 22);
            this.tbBookID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verify Select Booking ID";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(113, 146);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(151, 66);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDisplayBook
            // 
            this.btnDisplayBook.Location = new System.Drawing.Point(187, 22);
            this.btnDisplayBook.Name = "btnDisplayBook";
            this.btnDisplayBook.Size = new System.Drawing.Size(302, 48);
            this.btnDisplayBook.TabIndex = 1;
            this.btnDisplayBook.Text = "Display Bookings";
            this.btnDisplayBook.UseVisualStyleBackColor = true;
            this.btnDisplayBook.Click += new System.EventHandler(this.btnDisplayBook_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.rbIDnum);
            this.pnlSearch.Controls.Add(this.rbLastName);
            this.pnlSearch.Controls.Add(this.tbIDNum);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.tbLastName);
            this.pnlSearch.Location = new System.Drawing.Point(12, 109);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(976, 114);
            this.pnlSearch.TabIndex = 9;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbIDNum
            // 
            this.tbIDNum.Location = new System.Drawing.Point(602, 58);
            this.tbIDNum.Name = "tbIDNum";
            this.tbIDNum.Size = new System.Drawing.Size(170, 22);
            this.tbIDNum.TabIndex = 9;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(419, 11);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(139, 21);
            this.rbLastName.TabIndex = 11;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Enter Last Name:";
            this.rbLastName.UseVisualStyleBackColor = true;
            this.rbLastName.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbIDnum
            // 
            this.rbIDnum.AutoSize = true;
            this.rbIDnum.Location = new System.Drawing.Point(419, 58);
            this.rbIDnum.Name = "rbIDnum";
            this.rbIDnum.Size = new System.Drawing.Size(138, 21);
            this.rbIDnum.TabIndex = 12;
            this.rbIDnum.TabStop = true;
            this.rbIDnum.Text = "Enter ID Number:";
            this.rbIDnum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "SEARCH BY LAST NAME OR ID NUMBER:";
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.btnDisplayBook);
            this.pnlDisplay.Location = new System.Drawing.Point(145, 3);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(651, 100);
            this.pnlDisplay.TabIndex = 6;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlCheckOut);
            this.Controls.Add(this.dtgCheckOut);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckOut)).EndInit();
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlCheckOut.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCheckOut;
        private System.Windows.Forms.Panel pnlCheckOut;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnDisplayBook;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.RadioButton rbIDnum;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.TextBox tbIDNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDisplay;
    }
}