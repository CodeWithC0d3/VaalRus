
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpto = new System.Windows.Forms.DateTimePicker();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnBooked = new System.Windows.Forms.Button();
            this.btnDisplayAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewAcc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgViewAcc
            // 
<<<<<<< HEAD
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 405);
            this.dataGridView1.TabIndex = 0;
=======
            this.dtgViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewAcc.Location = new System.Drawing.Point(438, 50);
            this.dtgViewAcc.Name = "dtgViewAcc";
            this.dtgViewAcc.RowHeadersWidth = 51;
            this.dtgViewAcc.RowTemplate.Height = 24;
            this.dtgViewAcc.Size = new System.Drawing.Size(576, 498);
            this.dtgViewAcc.TabIndex = 0;
>>>>>>> BookedAccom
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dpto);
            this.panel1.Controls.Add(this.dpFrom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
<<<<<<< HEAD
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(29, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
=======
            this.panel1.Controls.Add(this.btnAvailable);
            this.panel1.Controls.Add(this.btnBooked);
            this.panel1.Controls.Add(this.btnDisplayAcc);
            this.panel1.Location = new System.Drawing.Point(39, 50);
>>>>>>> BookedAccom
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 392);
            this.panel1.TabIndex = 1;
            // 
            // dpto
            // 
<<<<<<< HEAD
            this.dpto.Location = new System.Drawing.Point(59, 159);
            this.dpto.Margin = new System.Windows.Forms.Padding(2);
=======
            this.dpto.Location = new System.Drawing.Point(79, 135);
>>>>>>> BookedAccom
            this.dpto.Name = "dpto";
            this.dpto.Size = new System.Drawing.Size(151, 20);
            this.dpto.TabIndex = 8;
            // 
            // dpFrom
            // 
<<<<<<< HEAD
            this.dpFrom.Location = new System.Drawing.Point(69, 108);
            this.dpFrom.Margin = new System.Windows.Forms.Padding(2);
=======
            this.dpFrom.Location = new System.Drawing.Point(79, 46);
>>>>>>> BookedAccom
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(151, 20);
            this.dpFrom.TabIndex = 7;
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(32, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.label2.Location = new System.Drawing.Point(32, 140);
>>>>>>> BookedAccom
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.label1.Location = new System.Drawing.Point(21, 51);
>>>>>>> BookedAccom
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM:";
            // 
            // btnAvailable
            // 
<<<<<<< HEAD
            this.button3.Location = new System.Drawing.Point(86, 221);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Available";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
=======
            this.btnAvailable.Location = new System.Drawing.Point(94, 223);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(131, 58);
            this.btnAvailable.TabIndex = 2;
            this.btnAvailable.Text = "Available";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.button3_Click);
>>>>>>> BookedAccom
            // 
            // btnBooked
            // 
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(86, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Booked";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
=======
            this.btnBooked.Location = new System.Drawing.Point(94, 313);
            this.btnBooked.Name = "btnBooked";
            this.btnBooked.Size = new System.Drawing.Size(131, 60);
            this.btnBooked.TabIndex = 1;
            this.btnBooked.Text = "Booked";
            this.btnBooked.UseVisualStyleBackColor = true;
            this.btnBooked.Click += new System.EventHandler(this.button2_Click_1);
>>>>>>> BookedAccom
            // 
            // btnDisplayAcc
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(59, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display All Accommodations";
            this.button1.UseVisualStyleBackColor = true;
=======
            this.btnDisplayAcc.Location = new System.Drawing.Point(71, 412);
            this.btnDisplayAcc.Name = "btnDisplayAcc";
            this.btnDisplayAcc.Size = new System.Drawing.Size(208, 40);
            this.btnDisplayAcc.TabIndex = 0;
            this.btnDisplayAcc.Text = "Display All Accommodations";
            this.btnDisplayAcc.UseVisualStyleBackColor = true;
            this.btnDisplayAcc.Click += new System.EventHandler(this.button1_Click_1);
>>>>>>> BookedAccom
            // 
            // frmViewAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.Controls.Add(this.panel1);
<<<<<<< HEAD
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
=======
            this.Controls.Add(this.dtgViewAcc);
>>>>>>> BookedAccom
            this.Name = "frmViewAccommodations";
            this.Text = "frmViewAccommodations";
            this.Load += new System.EventHandler(this.frmViewAccommodations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewAcc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViewAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Button btnBooked;
        private System.Windows.Forms.Button btnDisplayAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpto;
        private System.Windows.Forms.DateTimePicker dpFrom;
    }
}