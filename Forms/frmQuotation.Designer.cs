
namespace vaalrusGUIPrototype.Forms
{
    partial class frmQuotation
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
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlBookingDetails = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlavailibleAccommodation = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlAddRemove = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlSelectedAccommodation = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlBookingDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlavailibleAccommodation.SuspendLayout();
            this.pnlAddRemove.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlSelectedAccommodation.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(761, 416);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.pnlAddRemove);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(761, 416);
            this.pnlMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User - ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlBookingDetails);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(761, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Details";
            // 
            // pnlBookingDetails
            // 
            this.pnlBookingDetails.Controls.Add(this.dateTimePicker2);
            this.pnlBookingDetails.Controls.Add(this.label4);
            this.pnlBookingDetails.Controls.Add(this.dateTimePicker1);
            this.pnlBookingDetails.Controls.Add(this.label3);
            this.pnlBookingDetails.Controls.Add(this.cmbCustomer);
            this.pnlBookingDetails.Controls.Add(this.label2);
            this.pnlBookingDetails.Controls.Add(this.txtUser);
            this.pnlBookingDetails.Controls.Add(this.label1);
            this.pnlBookingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookingDetails.Location = new System.Drawing.Point(2, 15);
            this.pnlBookingDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBookingDetails.Name = "pnlBookingDetails";
            this.pnlBookingDetails.Size = new System.Drawing.Size(757, 81);
            this.pnlBookingDetails.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(40, 5);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(155, 20);
            this.txtUser.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer -";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(68, 50);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(127, 21);
            this.cmbCustomer.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 3);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(245, 48);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlavailibleAccommodation);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(338, 318);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availible Accommodations";
            // 
            // pnlavailibleAccommodation
            // 
            this.pnlavailibleAccommodation.Controls.Add(this.listBox1);
            this.pnlavailibleAccommodation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlavailibleAccommodation.Location = new System.Drawing.Point(2, 15);
            this.pnlavailibleAccommodation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlavailibleAccommodation.Name = "pnlavailibleAccommodation";
            this.pnlavailibleAccommodation.Size = new System.Drawing.Size(334, 301);
            this.pnlavailibleAccommodation.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 301);
            this.listBox1.TabIndex = 0;
            // 
            // pnlAddRemove
            // 
            this.pnlAddRemove.Controls.Add(this.button2);
            this.pnlAddRemove.Controls.Add(this.button1);
            this.pnlAddRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddRemove.Location = new System.Drawing.Point(338, 98);
            this.pnlAddRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAddRemove.Name = "pnlAddRemove";
            this.pnlAddRemove.Size = new System.Drawing.Size(77, 318);
            this.pnlAddRemove.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add =>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 177);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "<= Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlSelectedAccommodation);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(415, 98);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(346, 318);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Accommodation";
            // 
            // pnlSelectedAccommodation
            // 
            this.pnlSelectedAccommodation.Controls.Add(this.listBox2);
            this.pnlSelectedAccommodation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectedAccommodation.Location = new System.Drawing.Point(2, 15);
            this.pnlSelectedAccommodation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSelectedAccommodation.Name = "pnlSelectedAccommodation";
            this.pnlSelectedAccommodation.Size = new System.Drawing.Size(342, 301);
            this.pnlSelectedAccommodation.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(342, 301);
            this.listBox2.TabIndex = 0;
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 416);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.picBackground);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuotation";
            this.Text = "frmQuotation";
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlBookingDetails.ResumeLayout(false);
            this.pnlBookingDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlavailibleAccommodation.ResumeLayout(false);
            this.pnlAddRemove.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pnlSelectedAccommodation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlSelectedAccommodation;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel pnlAddRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlavailibleAccommodation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBookingDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
    }
}