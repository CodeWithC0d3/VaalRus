
namespace vaalrusGUIPrototype.Forms
{
    partial class frmAddAccommodation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccommodation));
            this.pictureBoxViewAllBookingsBackground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAccomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccomPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(37, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 307);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAccomPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbAccomType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Accommodation details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Accommodation:";
            // 
            // cbAccomType
            // 
            this.cbAccomType.FormattingEnabled = true;
            this.cbAccomType.Items.AddRange(new object[] {
            "Stand",
            "Chalet"});
            this.cbAccomType.Location = new System.Drawing.Point(27, 49);
            this.cbAccomType.Name = "cbAccomType";
            this.cbAccomType.Size = new System.Drawing.Size(121, 21);
            this.cbAccomType.TabIndex = 1;
            this.cbAccomType.Text = " < None Selected >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of occupants:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 113);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Accommodation price:";
            // 
            // txtAccomPrice
            // 
            this.txtAccomPrice.Location = new System.Drawing.Point(49, 178);
            this.txtAccomPrice.Name = "txtAccomPrice";
            this.txtAccomPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAccomPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "R";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(88, 259);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmAddAccommodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxViewAllBookingsBackground);
            this.Name = "frmAddAccommodation";
            this.Text = "frmAddAccommodation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewAllBookingsBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxViewAllBookingsBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAccomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccomPrice;
        private System.Windows.Forms.Label label3;
    }
}