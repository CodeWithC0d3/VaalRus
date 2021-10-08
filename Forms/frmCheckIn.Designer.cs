
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
            this.dtgCheckIn = new System.Windows.Forms.DataGridView();
            this.pnlCheckIn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnDisplayBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckIn)).BeginInit();
            this.pnlCheckIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCheckIn
            // 
            this.dtgCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCheckIn.Location = new System.Drawing.Point(427, 29);
            this.dtgCheckIn.Name = "dtgCheckIn";
            this.dtgCheckIn.RowHeadersWidth = 51;
            this.dtgCheckIn.RowTemplate.Height = 24;
            this.dtgCheckIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCheckIn.Size = new System.Drawing.Size(551, 415);
            this.dtgCheckIn.TabIndex = 0;
            this.dtgCheckIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgCheckIn.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pnlCheckIn
            // 
            this.pnlCheckIn.Controls.Add(this.label2);
            this.pnlCheckIn.Controls.Add(this.tbBookID);
            this.pnlCheckIn.Controls.Add(this.btnCheckIn);
            this.pnlCheckIn.Controls.Add(this.btnDisplayBook);
            this.pnlCheckIn.Location = new System.Drawing.Point(6, 29);
            this.pnlCheckIn.Name = "pnlCheckIn";
            this.pnlCheckIn.Size = new System.Drawing.Size(378, 439);
            this.pnlCheckIn.TabIndex = 1;
            this.pnlCheckIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Booking ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(94, 220);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(50, 22);
            this.tbBookID.TabIndex = 4;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(94, 311);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(142, 66);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDisplayBook
            // 
            this.btnDisplayBook.Location = new System.Drawing.Point(94, 63);
            this.btnDisplayBook.Name = "btnDisplayBook";
            this.btnDisplayBook.Size = new System.Drawing.Size(153, 54);
            this.btnDisplayBook.TabIndex = 0;
            this.btnDisplayBook.Text = "Display Bookings";
            this.btnDisplayBook.UseVisualStyleBackColor = true;
            this.btnDisplayBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1025, 576);
            this.Controls.Add(this.pnlCheckIn);
            this.Controls.Add(this.dtgCheckIn);
            this.Name = "frmCheckIn";
            this.Text = "frmCheckIn";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCheckIn)).EndInit();
            this.pnlCheckIn.ResumeLayout(false);
            this.pnlCheckIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCheckIn;
        private System.Windows.Forms.Panel pnlCheckIn;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnDisplayBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookID;
    }
}