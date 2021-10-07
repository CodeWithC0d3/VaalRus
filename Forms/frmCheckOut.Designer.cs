
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
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnDisplayBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckOut)).BeginInit();
            this.pnlCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCheckOut
            // 
            this.dtgCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCheckOut.Location = new System.Drawing.Point(440, 26);
            this.dtgCheckOut.Name = "dtgCheckOut";
            this.dtgCheckOut.RowHeadersWidth = 51;
            this.dtgCheckOut.RowTemplate.Height = 24;
            this.dtgCheckOut.Size = new System.Drawing.Size(548, 455);
            this.dtgCheckOut.TabIndex = 0;
            this.dtgCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCheckOut_CellContentClick);
            this.dtgCheckOut.SelectionChanged += new System.EventHandler(this.dtgCheckOut_SelectionChanged);
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.Controls.Add(this.tbBookID);
            this.pnlCheckOut.Controls.Add(this.label2);
            this.pnlCheckOut.Controls.Add(this.btnCheckout);
            this.pnlCheckOut.Controls.Add(this.btnDisplayBook);
            this.pnlCheckOut.Location = new System.Drawing.Point(42, 26);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(376, 455);
            this.pnlCheckOut.TabIndex = 1;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(86, 227);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(47, 22);
            this.tbBookID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Booking ID";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(86, 312);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(151, 66);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDisplayBook
            // 
            this.btnDisplayBook.Location = new System.Drawing.Point(86, 59);
            this.btnDisplayBook.Name = "btnDisplayBook";
            this.btnDisplayBook.Size = new System.Drawing.Size(136, 55);
            this.btnDisplayBook.TabIndex = 1;
            this.btnDisplayBook.Text = "Display Bookings";
            this.btnDisplayBook.UseVisualStyleBackColor = true;
            this.btnDisplayBook.Click += new System.EventHandler(this.btnDisplayBook_Click);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.Controls.Add(this.pnlCheckOut);
            this.Controls.Add(this.dtgCheckOut);
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckOut)).EndInit();
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCheckOut;
        private System.Windows.Forms.Panel pnlCheckOut;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnDisplayBook;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label2;
    }
}