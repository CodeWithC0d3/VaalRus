
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
            this.dtgViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewAcc.Location = new System.Drawing.Point(438, 50);
            this.dtgViewAcc.Name = "dtgViewAcc";
            this.dtgViewAcc.RowHeadersWidth = 51;
            this.dtgViewAcc.RowTemplate.Height = 24;
            this.dtgViewAcc.Size = new System.Drawing.Size(576, 498);
            this.dtgViewAcc.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dpto);
            this.panel1.Controls.Add(this.dpFrom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAvailable);
            this.panel1.Controls.Add(this.btnBooked);
            this.panel1.Controls.Add(this.btnDisplayAcc);
            this.panel1.Location = new System.Drawing.Point(39, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 482);
            this.panel1.TabIndex = 1;
            // 
            // dpto
            // 
            this.dpto.Location = new System.Drawing.Point(79, 135);
            this.dpto.Name = "dpto";
            this.dpto.Size = new System.Drawing.Size(200, 22);
            this.dpto.TabIndex = 8;
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(79, 46);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(200, 22);
            this.dpFrom.TabIndex = 7;
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM:";
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(94, 223);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(131, 58);
            this.btnAvailable.TabIndex = 2;
            this.btnAvailable.Text = "Available";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBooked
            // 
            this.btnBooked.Location = new System.Drawing.Point(94, 313);
            this.btnBooked.Name = "btnBooked";
            this.btnBooked.Size = new System.Drawing.Size(131, 60);
            this.btnBooked.TabIndex = 1;
            this.btnBooked.Text = "Booked";
            this.btnBooked.UseVisualStyleBackColor = true;
            this.btnBooked.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnDisplayAcc
            // 
            this.btnDisplayAcc.Location = new System.Drawing.Point(71, 412);
            this.btnDisplayAcc.Name = "btnDisplayAcc";
            this.btnDisplayAcc.Size = new System.Drawing.Size(208, 40);
            this.btnDisplayAcc.TabIndex = 0;
            this.btnDisplayAcc.Text = "Display All Accommodations";
            this.btnDisplayAcc.UseVisualStyleBackColor = true;
            this.btnDisplayAcc.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmViewAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgViewAcc);
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