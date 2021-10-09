
namespace vaalrusGUIPrototype.Forms
{
    partial class frmUpdateCustomer
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearchCustNo = new System.Windows.Forms.ComboBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.cbOverride = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eProviderFN = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderLN = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderCN = new System.Windows.Forms.ErrorProvider(this.components);
            this.eProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelChildForm.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderLN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(168)))));
            this.panelChildForm.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Controls.Add(this.panel5);
            this.panelChildForm.Controls.Add(this.panel4);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1126, 539);
            this.panelChildForm.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgView);
            this.panel5.Location = new System.Drawing.Point(343, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(759, 513);
            this.panel5.TabIndex = 20;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(0, 0);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(759, 513);
            this.dgView.TabIndex = 0;
            this.dgView.SelectionChanged += new System.EventHandler(this.dgView_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 513);
            this.panel4.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 140);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSearchCustNo);
            this.panel1.Controls.Add(this.txtSearchID);
            this.panel1.Controls.Add(this.txtSearchLastName);
            this.panel1.Controls.Add(this.txtSearchFirstName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 121);
            this.panel1.TabIndex = 0;
            // 
            // cbSearchCustNo
            // 
            this.cbSearchCustNo.FormattingEnabled = true;
            this.cbSearchCustNo.Location = new System.Drawing.Point(119, 7);
            this.cbSearchCustNo.Name = "cbSearchCustNo";
            this.cbSearchCustNo.Size = new System.Drawing.Size(142, 21);
            this.cbSearchCustNo.TabIndex = 8;
            this.cbSearchCustNo.SelectedIndexChanged += new System.EventHandler(this.cbSearchCustNo_SelectedIndexChanged);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(119, 94);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(142, 20);
            this.txtSearchID.TabIndex = 7;
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged_1);
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(119, 64);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(142, 20);
            this.txtSearchLastName.TabIndex = 6;
            this.txtSearchLastName.TextChanged += new System.EventHandler(this.txtSearchLastName_TextChanged);
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(119, 34);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(142, 20);
            this.txtSearchFirstName.TabIndex = 5;
            this.txtSearchFirstName.TextChanged += new System.EventHandler(this.txtSearchFirstName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOutput);
            this.panel2.Controls.Add(this.btnAll);
            this.panel2.Location = new System.Drawing.Point(3, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 52);
            this.panel2.TabIndex = 16;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(49, 20);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(152, 9);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(159, 34);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "Reload";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(6, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 306);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Customer Details:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtCustNo);
            this.panel3.Controls.Add(this.cbOverride);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtContact);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.txtLastName);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtFirstName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 287);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Number:";
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(187, 24);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(82, 20);
            this.txtCustNo.TabIndex = 20;
            this.txtCustNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOverride
            // 
            this.cbOverride.AutoSize = true;
            this.cbOverride.Location = new System.Drawing.Point(17, 252);
            this.cbOverride.Name = "cbOverride";
            this.cbOverride.Size = new System.Drawing.Size(99, 17);
            this.cbOverride.TabIndex = 20;
            this.cbOverride.Text = "Saftey Override";
            this.cbOverride.UseVisualStyleBackColor = true;
            this.cbOverride.CheckedChanged += new System.EventHandler(this.cbOverride_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tel:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(126, 153);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(142, 20);
            this.txtContact.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(126, 212);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 20);
            this.txtAddress.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 242);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Address:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 115);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 20);
            this.txtID.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 20);
            this.txtLastName.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "First name:";
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
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 539);
            this.Controls.Add(this.panelChildForm);
            this.Name = "frmUpdateCustomer";
            this.Text = "frmUpdateCustomer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderLN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eProviderEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cbSearchCustNo;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.CheckBox cbOverride;
        private System.Windows.Forms.ErrorProvider eProviderFN;
        private System.Windows.Forms.ErrorProvider eProviderLN;
        private System.Windows.Forms.ErrorProvider eProviderID;
        private System.Windows.Forms.ErrorProvider eProviderCN;
        private System.Windows.Forms.ErrorProvider eProviderEmail;
    }
}