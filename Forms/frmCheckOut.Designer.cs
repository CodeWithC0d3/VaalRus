
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
            this.components = new System.ComponentModel.Container();
            this.dtgCheckOut = new System.Windows.Forms.DataGridView();
            this.pnlCheckOut = new System.Windows.Forms.Panel();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
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
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckOut)).BeginInit();
            this.pnlCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIDNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCheckOut
            // 
            this.dtgCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCheckOut.Location = new System.Drawing.Point(0, 0);
            this.dtgCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCheckOut.Name = "dtgCheckOut";
            this.dtgCheckOut.RowHeadersWidth = 51;
            this.dtgCheckOut.RowTemplate.Height = 24;
            this.dtgCheckOut.Size = new System.Drawing.Size(812, 506);
            this.dtgCheckOut.TabIndex = 0;
            this.dtgCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCheckIn_CellContentClick);
            this.dtgCheckOut.SelectionChanged += new System.EventHandler(this.dtgCheckOut_SelectionChanged_1);
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.Controls.Add(this.gbSearch);
            this.pnlCheckOut.Controls.Add(this.label2);
            this.pnlCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCheckOut.Location = new System.Drawing.Point(0, 0);
            this.pnlCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(381, 233);
            this.pnlCheckOut.TabIndex = 1;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(148, 15);
            this.tbBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(47, 22);
            this.tbBookID.TabIndex = 5;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(88, 81);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(151, 66);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verify Slelected Booking ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(341, 54);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(190, 46);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(143, 22);
            this.tbLastName.TabIndex = 7;
            // 
            // btnDisplayBook
            // 
            this.btnDisplayBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisplayBook.Location = new System.Drawing.Point(7, 18);
            this.btnDisplayBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayBook.Name = "btnDisplayBook";
            this.btnDisplayBook.Size = new System.Drawing.Size(367, 54);
            this.btnDisplayBook.TabIndex = 1;
            this.btnDisplayBook.Text = "Refresh Booking List";
            this.btnDisplayBook.UseVisualStyleBackColor = true;
            this.btnDisplayBook.Click += new System.EventHandler(this.btnDisplayBook_Click);
            // 
            // rbIDnum
            // 
            this.rbIDnum.AutoSize = true;
            this.rbIDnum.Location = new System.Drawing.Point(15, 2);
            this.rbIDnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbIDnum.Name = "rbIDnum";
            this.rbIDnum.Size = new System.Drawing.Size(138, 21);
            this.rbIDnum.TabIndex = 12;
            this.rbIDnum.TabStop = true;
            this.rbIDnum.Text = "Enter ID Number:";
            this.rbIDnum.UseVisualStyleBackColor = true;
            this.rbIDnum.CheckedChanged += new System.EventHandler(this.rbIDnum_CheckedChanged);
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(15, 49);
            this.rbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(139, 21);
            this.rbLastName.TabIndex = 11;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Enter Last Name:";
            this.rbLastName.UseVisualStyleBackColor = true;
            // 
            // tbIDNum
            // 
            this.tbIDNum.Location = new System.Drawing.Point(190, 2);
            this.tbIDNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIDNum.Name = "tbIDNum";
            this.tbIDNum.Size = new System.Drawing.Size(143, 22);
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
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlDisplay);
            this.panel1.Controls.Add(this.pnlCheckOut);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 506);
            this.panel1.TabIndex = 10;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.btnDisplayBook);
            this.pnlDisplay.Location = new System.Drawing.Point(0, 404);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(381, 86);
            this.pnlDisplay.TabIndex = 8;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.pnlSearch);
            this.gbSearch.ForeColor = System.Drawing.Color.White;
            this.gbSearch.Location = new System.Drawing.Point(7, 13);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearch.Size = new System.Drawing.Size(362, 171);
            this.gbSearch.TabIndex = 7;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "SEARCH BY LAST NAME OR ID NUMBER:";
            this.gbSearch.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.tbIDNum);
            this.pnlSearch.Controls.Add(this.rbLastName);
            this.pnlSearch.Controls.Add(this.rbIDnum);
            this.pnlSearch.Controls.Add(this.tbLastName);
            this.pnlSearch.Location = new System.Drawing.Point(4, 19);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(350, 148);
            this.pnlSearch.TabIndex = 0;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearch_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtgCheckOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(405, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 506);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-2, -13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 528);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Controls.Add(this.tbBookID);
            this.panel4.Location = new System.Drawing.Point(17, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 159);
            this.panel4.TabIndex = 13;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckIn";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckOut)).EndInit();
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlCheckOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIDNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCheckOut;
        private System.Windows.Forms.Panel pnlCheckOut;
        private System.Windows.Forms.Button btnCheckOut;
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
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}