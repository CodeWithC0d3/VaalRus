
namespace vaalrusGUIPrototype
{
    partial class frmViewAccommodations
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
            this.dtgViewAcc = new System.Windows.Forms.DataGridView();
            this.pnlView = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBooked = new System.Windows.Forms.Button();
            this.dpto = new System.Windows.Forms.DateTimePicker();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewAcc)).BeginInit();
            this.pnlView.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgViewAcc
            // 
            this.dtgViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewAcc.Location = new System.Drawing.Point(438, 128);
            this.dtgViewAcc.Name = "dtgViewAcc";
            this.dtgViewAcc.RowHeadersWidth = 51;
            this.dtgViewAcc.RowTemplate.Height = 24;
            this.dtgViewAcc.Size = new System.Drawing.Size(576, 340);
            this.dtgViewAcc.TabIndex = 0;
            this.dtgViewAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.button3);
            this.pnlView.Controls.Add(this.btnBooked);
            this.pnlView.Location = new System.Drawing.Point(39, 175);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(342, 293);
            this.pnlView.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "Available Accommodation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBooked
            // 
            this.btnBooked.Location = new System.Drawing.Point(100, 181);
            this.btnBooked.Name = "btnBooked";
            this.btnBooked.Size = new System.Drawing.Size(164, 82);
            this.btnBooked.TabIndex = 1;
            this.btnBooked.Text = "Booked Accommodation";
            this.btnBooked.UseVisualStyleBackColor = true;
            this.btnBooked.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dpto
            // 
            this.dpto.Location = new System.Drawing.Point(677, 15);
            this.dpto.Name = "dpto";
            this.dpto.Size = new System.Drawing.Size(322, 22);
            this.dpto.TabIndex = 8;
            this.dpto.ValueChanged += new System.EventHandler(this.dpto_ValueChanged);
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(127, 15);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(326, 22);
            this.dpFrom.TabIndex = 7;
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display All Accommodations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.label2);
            this.pnlDate.Controls.Add(this.dpto);
            this.pnlDate.Controls.Add(this.dpFrom);
            this.pnlDate.Controls.Add(this.label1);
            this.pnlDate.Location = new System.Drawing.Point(12, 71);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(1002, 51);
            this.pnlDate.TabIndex = 2;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.button1);
            this.pnlDisplay.Location = new System.Drawing.Point(12, 12);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1002, 53);
            this.pnlDisplay.TabIndex = 0;
            // 
            // frmViewAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1054, 574);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.dtgViewAcc);
            this.Name = "frmViewAccommodations";
            this.Text = "frmViewAccommodations";
            this.Load += new System.EventHandler(this.frmViewAccommodations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewAcc)).EndInit();
            this.pnlView.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViewAcc;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBooked;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpto;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Panel pnlDisplay;
    }
}