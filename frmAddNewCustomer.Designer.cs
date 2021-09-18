
namespace vaalrusGUIPrototype
{
    partial class frmAddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewCustomer));
            this.pictureBoxMainFormBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.gbCD = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbPD = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblIDno = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainFormBackground)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbCD.SuspendLayout();
            this.gbPD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMainFormBackground
            // 
            this.pictureBoxMainFormBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainFormBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainFormBackground.Image")));
            this.pictureBoxMainFormBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMainFormBackground.Name = "pictureBoxMainFormBackground";
            this.pictureBoxMainFormBackground.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxMainFormBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainFormBackground.TabIndex = 1;
            this.pictureBoxMainFormBackground.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCreateCustomer);
            this.panel1.Controls.Add(this.gbCD);
            this.panel1.Controls.Add(this.gbPD);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 398);
            this.panel1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(403, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(176, 353);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(146, 34);
            this.btnCreateCustomer.TabIndex = 9;
            this.btnCreateCustomer.Text = "Create Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            // 
            // gbCD
            // 
            this.gbCD.Controls.Add(this.richTextBox1);
            this.gbCD.Controls.Add(this.label1);
            this.gbCD.Controls.Add(this.txtCellNumber);
            this.gbCD.Controls.Add(this.lblAddress);
            this.gbCD.Controls.Add(this.lblemail);
            this.gbCD.Controls.Add(this.txtEmail);
            this.gbCD.Location = new System.Drawing.Point(27, 170);
            this.gbCD.Name = "gbCD";
            this.gbCD.Size = new System.Drawing.Size(464, 177);
            this.gbCD.TabIndex = 8;
            this.gbCD.TabStop = false;
            this.gbCD.Text = "Contact Details:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(88, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 69);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cell number:";
            // 
            // txtCellNumber
            // 
            this.txtCellNumber.Location = new System.Drawing.Point(9, 54);
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCellNumber.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 92);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(146, 34);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(34, 13);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // gbPD
            // 
            this.gbPD.Controls.Add(this.lblFirstName);
            this.gbPD.Controls.Add(this.txtIDNumber);
            this.gbPD.Controls.Add(this.txtFirstName);
            this.gbPD.Controls.Add(this.lblIDno);
            this.gbPD.Controls.Add(this.lblLastname);
            this.gbPD.Controls.Add(this.txtLastName);
            this.gbPD.Location = new System.Drawing.Point(27, 56);
            this.gbPD.Name = "gbPD";
            this.gbPD.Size = new System.Drawing.Size(464, 86);
            this.gbPD.TabIndex = 7;
            this.gbPD.TabStop = false;
            this.gbPD.Text = "Personal Details:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Frist name:";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(292, 50);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIDNumber.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(9, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblIDno
            // 
            this.lblIDno.AutoSize = true;
            this.lblIDno.Location = new System.Drawing.Point(289, 30);
            this.lblIDno.Name = "lblIDno";
            this.lblIDno.Size = new System.Drawing.Size(102, 13);
            this.lblIDno.TabIndex = 5;
            this.lblIDno.Text = "Identity number (ID):";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(146, 30);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(59, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Last name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(149, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(24, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(114, 13);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "New Customer Details:";
            // 
            // frmAddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMainFormBackground);
            this.Name = "frmAddNewCustomer";
            this.Text = "Add a new customer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainFormBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCD.ResumeLayout(false);
            this.gbCD.PerformLayout();
            this.gbPD.ResumeLayout(false);
            this.gbPD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainFormBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label lblIDno;
        private System.Windows.Forms.GroupBox gbCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCellNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbPD;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnClear;
    }
}