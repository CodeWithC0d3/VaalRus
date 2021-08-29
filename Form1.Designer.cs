
namespace vaalrusGUIPrototype
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBookings = new System.Windows.Forms.Button();
            this.panelSubMenuBooking = new System.Windows.Forms.Panel();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panelSubMenuCustomer = new System.Windows.Forms.Panel();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnAccomodations = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.panelSubMenuAccommodation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateAccommodation = new System.Windows.Forms.Button();
            this.btnAddAccommodation = new System.Windows.Forms.Button();
            this.btnViewAccommodations = new System.Windows.Forms.Button();
            this.btnQoutation = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSubMenuBooking.SuspendLayout();
            this.panelSubMenuCustomer.SuspendLayout();
            this.panelSubMenuAccommodation.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnQoutation);
            this.panel1.Controls.Add(this.panelSubMenuAccommodation);
            this.panel1.Controls.Add(this.btnAccomodations);
            this.panel1.Controls.Add(this.panelSubMenuCustomer);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.panelSubMenuBooking);
            this.panel1.Controls.Add(this.btnBookings);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 467);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 80);
            this.panel2.TabIndex = 0;
            // 
            // btnBookings
            // 
            this.btnBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookings.Location = new System.Drawing.Point(0, 80);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(169, 40);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // panelSubMenuBooking
            // 
            this.panelSubMenuBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelSubMenuBooking.Controls.Add(this.btnDeleteBooking);
            this.panelSubMenuBooking.Controls.Add(this.btnCheckOut);
            this.panelSubMenuBooking.Controls.Add(this.btnCheckIn);
            this.panelSubMenuBooking.Controls.Add(this.btnCreateBooking);
            this.panelSubMenuBooking.Controls.Add(this.btnViewBookings);
            this.panelSubMenuBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuBooking.Location = new System.Drawing.Point(0, 120);
            this.panelSubMenuBooking.Name = "panelSubMenuBooking";
            this.panelSubMenuBooking.Size = new System.Drawing.Size(169, 181);
            this.panelSubMenuBooking.TabIndex = 2;
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewBookings.FlatAppearance.BorderSize = 0;
            this.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewBookings.Location = new System.Drawing.Point(0, 0);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnViewBookings.Size = new System.Drawing.Size(169, 35);
            this.btnViewBookings.TabIndex = 0;
            this.btnViewBookings.Text = "View All Bookings";
            this.btnViewBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateBooking.FlatAppearance.BorderSize = 0;
            this.btnCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateBooking.Location = new System.Drawing.Point(0, 35);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreateBooking.Size = new System.Drawing.Size(169, 35);
            this.btnCreateBooking.TabIndex = 1;
            this.btnCreateBooking.Text = "Create New Booking";
            this.btnCreateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckIn.Location = new System.Drawing.Point(0, 70);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCheckIn.Size = new System.Drawing.Size(169, 35);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckOut.Location = new System.Drawing.Point(0, 105);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCheckOut.Size = new System.Drawing.Size(169, 35);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.Location = new System.Drawing.Point(0, 301);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(169, 35);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // panelSubMenuCustomer
            // 
            this.panelSubMenuCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelSubMenuCustomer.Controls.Add(this.btnDeleteCustomer);
            this.panelSubMenuCustomer.Controls.Add(this.btnUpdateCustomer);
            this.panelSubMenuCustomer.Controls.Add(this.btnAddCustomer);
            this.panelSubMenuCustomer.Controls.Add(this.btnViewCustomers);
            this.panelSubMenuCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCustomer.Location = new System.Drawing.Point(0, 336);
            this.panelSubMenuCustomer.Name = "panelSubMenuCustomer";
            this.panelSubMenuCustomer.Size = new System.Drawing.Size(169, 143);
            this.panelSubMenuCustomer.TabIndex = 4;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(0, 105);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDeleteCustomer.Size = new System.Drawing.Size(169, 35);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(0, 70);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUpdateCustomer.Size = new System.Drawing.Size(169, 35);
            this.btnUpdateCustomer.TabIndex = 2;
            this.btnUpdateCustomer.Text = "Update Existing Customer";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 35);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(169, 35);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCustomers.FlatAppearance.BorderSize = 0;
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnViewCustomers.Size = new System.Drawing.Size(169, 35);
            this.btnViewCustomers.TabIndex = 0;
            this.btnViewCustomers.Text = "View All Customers";
            this.btnViewCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            // 
            // btnAccomodations
            // 
            this.btnAccomodations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccomodations.FlatAppearance.BorderSize = 0;
            this.btnAccomodations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccomodations.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccomodations.Location = new System.Drawing.Point(0, 479);
            this.btnAccomodations.Name = "btnAccomodations";
            this.btnAccomodations.Size = new System.Drawing.Size(169, 35);
            this.btnAccomodations.TabIndex = 5;
            this.btnAccomodations.Text = "Accommodations";
            this.btnAccomodations.UseVisualStyleBackColor = true;
            this.btnAccomodations.Click += new System.EventHandler(this.btnAccomodations_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteBooking.FlatAppearance.BorderSize = 0;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteBooking.Location = new System.Drawing.Point(0, 140);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDeleteBooking.Size = new System.Drawing.Size(169, 35);
            this.btnDeleteBooking.TabIndex = 4;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // panelSubMenuAccommodation
            // 
            this.panelSubMenuAccommodation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelSubMenuAccommodation.Controls.Add(this.button1);
            this.panelSubMenuAccommodation.Controls.Add(this.btnUpdateAccommodation);
            this.panelSubMenuAccommodation.Controls.Add(this.btnAddAccommodation);
            this.panelSubMenuAccommodation.Controls.Add(this.btnViewAccommodations);
            this.panelSubMenuAccommodation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAccommodation.Location = new System.Drawing.Point(0, 514);
            this.panelSubMenuAccommodation.Name = "panelSubMenuAccommodation";
            this.panelSubMenuAccommodation.Size = new System.Drawing.Size(169, 143);
            this.panelSubMenuAccommodation.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 105);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(169, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Accommodation";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccommodation
            // 
            this.btnUpdateAccommodation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateAccommodation.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccommodation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccommodation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateAccommodation.Location = new System.Drawing.Point(0, 70);
            this.btnUpdateAccommodation.Name = "btnUpdateAccommodation";
            this.btnUpdateAccommodation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUpdateAccommodation.Size = new System.Drawing.Size(169, 35);
            this.btnUpdateAccommodation.TabIndex = 2;
            this.btnUpdateAccommodation.Text = "Update Existing Accommodation";
            this.btnUpdateAccommodation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccommodation.UseVisualStyleBackColor = true;
            // 
            // btnAddAccommodation
            // 
            this.btnAddAccommodation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAccommodation.FlatAppearance.BorderSize = 0;
            this.btnAddAccommodation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccommodation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAccommodation.Location = new System.Drawing.Point(0, 35);
            this.btnAddAccommodation.Name = "btnAddAccommodation";
            this.btnAddAccommodation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAddAccommodation.Size = new System.Drawing.Size(169, 35);
            this.btnAddAccommodation.TabIndex = 1;
            this.btnAddAccommodation.Text = "Add New Accommodation";
            this.btnAddAccommodation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccommodation.UseVisualStyleBackColor = true;
            // 
            // btnViewAccommodations
            // 
            this.btnViewAccommodations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAccommodations.FlatAppearance.BorderSize = 0;
            this.btnViewAccommodations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAccommodations.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewAccommodations.Location = new System.Drawing.Point(0, 0);
            this.btnViewAccommodations.Name = "btnViewAccommodations";
            this.btnViewAccommodations.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnViewAccommodations.Size = new System.Drawing.Size(169, 35);
            this.btnViewAccommodations.TabIndex = 0;
            this.btnViewAccommodations.Text = "View All Accommodations";
            this.btnViewAccommodations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAccommodations.UseVisualStyleBackColor = true;
            // 
            // btnQoutation
            // 
            this.btnQoutation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQoutation.FlatAppearance.BorderSize = 0;
            this.btnQoutation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQoutation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQoutation.Location = new System.Drawing.Point(0, 657);
            this.btnQoutation.Name = "btnQoutation";
            this.btnQoutation.Size = new System.Drawing.Size(169, 35);
            this.btnQoutation.TabIndex = 7;
            this.btnQoutation.Text = "Quotations";
            this.btnQoutation.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.Location = new System.Drawing.Point(0, 692);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(169, 35);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(186, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(745, 467);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 467);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelSubMenuBooking.ResumeLayout(false);
            this.panelSubMenuCustomer.ResumeLayout(false);
            this.panelSubMenuAccommodation.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSubMenuBooking;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccomodations;
        private System.Windows.Forms.Panel panelSubMenuCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Panel panelSubMenuAccommodation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateAccommodation;
        private System.Windows.Forms.Button btnAddAccommodation;
        private System.Windows.Forms.Button btnViewAccommodations;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnQoutation;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

