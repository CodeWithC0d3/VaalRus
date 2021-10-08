
namespace vaalrusGUIPrototype.Forms
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.pictureBoxViewAllBookingsBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.eProviderFN = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderLN = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderCN = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderLN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderEmail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxViewAllBookingsBackground
            // 
            this.pictureBoxViewAllBookingsBackground.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBoxViewAllBookingsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxViewAllBookingsBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxViewAllBookingsBackground.Image")));
            this.pictureBoxViewAllBookingsBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxViewAllBookingsBackground.Name = "pictureBoxViewAllBookingsBackground";
            this.pictureBoxViewAllBookingsBackground.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxViewAllBookingsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxViewAllBookingsBackground.TabIndex = 1;
            this.pictureBoxViewAllBookingsBackground.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(36, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 412);
            this.panel1.TabIndex = 2;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(38, 105);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(351, 72);
            this.rtbAddress.TabIndex = 5;
            this.rtbAddress.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(289, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.txtID_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Physical Address details:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(342, 358);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 38);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create customer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identity Number (ID):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "email:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(38, 47);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtContactNumber.TabIndex = 3;
            this.txtContactNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactNumber_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(162, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contact number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(38, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // eProviderFN
            // 
            this.eProviderFN.ContainerControl = this;
            // 
            // eProviderLN
            // 
            this.eProviderLN.ContainerControl = this;
            // 
            // eProviderID
            // 
            this.eProviderID.ContainerControl = this;
            // 
            // eProviderCN
            // 
            this.eProviderCN.ContainerControl = this;
            // 
            // eProviderEmail
            // 
            this.eProviderEmail.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(21, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbAddress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtContactNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 191);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact details:";
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxViewAllBookingsBackground);
            this.Name = "frmAddCustomer";
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eProviderFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderLN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderEmail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxViewAllBookingsBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider eProviderFN;
        private System.Windows.Forms.ErrorProvider eProviderLN;
        private System.Windows.Forms.ErrorProvider eProviderID;
        private System.Windows.Forms.ErrorProvider eProviderCN;
        private System.Windows.Forms.ErrorProvider eProviderEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}