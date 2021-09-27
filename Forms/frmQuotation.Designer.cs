
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClearLst = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAccommodation = new System.Windows.Forms.ComboBox();
            this.btnGeneratQuote = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlBookingDetails = new System.Windows.Forms.Panel();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlavailibleAccommodation = new System.Windows.Forms.Panel();
            this.lstAccommodation = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlBookingDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlavailibleAccommodation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClearLst);
            this.pnlMain.Controls.Add(this.cmbFilter);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.cmbAccommodation);
            this.pnlMain.Controls.Add(this.btnGeneratQuote);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1003, 666);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Visible = false;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnClearLst
            // 
            this.btnClearLst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLst.Location = new System.Drawing.Point(8, 601);
            this.btnClearLst.Name = "btnClearLst";
            this.btnClearLst.Size = new System.Drawing.Size(103, 53);
            this.btnClearLst.TabIndex = 18;
            this.btnClearLst.Text = "Clear List";
            this.btnClearLst.UseVisualStyleBackColor = true;
            this.btnClearLst.Click += new System.EventHandler(this.btnClearLst_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All"});
            this.cmbFilter.Location = new System.Drawing.Point(4, 285);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(354, 21);
            this.cmbFilter.TabIndex = 17;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filter By";
            // 
            // cmbAccommodation
            // 
            this.cmbAccommodation.Enabled = false;
            this.cmbAccommodation.FormattingEnabled = true;
            this.cmbAccommodation.Location = new System.Drawing.Point(4, 331);
            this.cmbAccommodation.Name = "cmbAccommodation";
            this.cmbAccommodation.Size = new System.Drawing.Size(354, 21);
            this.cmbAccommodation.TabIndex = 15;
            this.cmbAccommodation.DropDown += new System.EventHandler(this.cmbAccommodation_DropDown);
            this.cmbAccommodation.SelectedIndexChanged += new System.EventHandler(this.cmbAccommodation_SelectedIndexChanged);
            this.cmbAccommodation.DropDownClosed += new System.EventHandler(this.cmbAccommodation_DropDownClosed);
            this.cmbAccommodation.Enter += new System.EventHandler(this.cmbAccommodation_Enter);
            // 
            // btnGeneratQuote
            // 
            this.btnGeneratQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGeneratQuote.Location = new System.Drawing.Point(264, 601);
            this.btnGeneratQuote.Name = "btnGeneratQuote";
            this.btnGeneratQuote.Size = new System.Drawing.Size(92, 53);
            this.btnGeneratQuote.TabIndex = 1;
            this.btnGeneratQuote.Text = "Generate Quote";
            this.btnGeneratQuote.UseVisualStyleBackColor = true;
            this.btnGeneratQuote.Click += new System.EventHandler(this.btnGeneratQuote_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(380, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 639);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(602, 639);
            this.dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Add Accommodation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlBookingDetails);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(358, 261);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Details";
            // 
            // pnlBookingDetails
            // 
            this.pnlBookingDetails.Controls.Add(this.dpTo);
            this.pnlBookingDetails.Controls.Add(this.label4);
            this.pnlBookingDetails.Controls.Add(this.dpFrom);
            this.pnlBookingDetails.Controls.Add(this.label3);
            this.pnlBookingDetails.Controls.Add(this.cmbCustomer);
            this.pnlBookingDetails.Controls.Add(this.label2);
            this.pnlBookingDetails.Controls.Add(this.txtUser);
            this.pnlBookingDetails.Controls.Add(this.label1);
            this.pnlBookingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookingDetails.Location = new System.Drawing.Point(2, 15);
            this.pnlBookingDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBookingDetails.Name = "pnlBookingDetails";
            this.pnlBookingDetails.Size = new System.Drawing.Size(354, 244);
            this.pnlBookingDetails.TabIndex = 0;
            // 
            // dpTo
            // 
            this.dpTo.Location = new System.Drawing.Point(71, 208);
            this.dpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(177, 20);
            this.dpTo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(71, 152);
            this.dpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(177, 20);
            this.dpFrom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(2, 93);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(347, 21);
            this.cmbCustomer.TabIndex = 9;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.Click += new System.EventHandler(this.cmbCustomer_Click);
            this.cmbCustomer.Enter += new System.EventHandler(this.cmbCustomer_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(2, 36);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(347, 20);
            this.txtUser.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pnlavailibleAccommodation);
            this.groupBox2.Location = new System.Drawing.Point(6, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(356, 223);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Accommodation";
            // 
            // pnlavailibleAccommodation
            // 
            this.pnlavailibleAccommodation.Controls.Add(this.lstAccommodation);
            this.pnlavailibleAccommodation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlavailibleAccommodation.Location = new System.Drawing.Point(2, 15);
            this.pnlavailibleAccommodation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlavailibleAccommodation.Name = "pnlavailibleAccommodation";
            this.pnlavailibleAccommodation.Size = new System.Drawing.Size(352, 206);
            this.pnlavailibleAccommodation.TabIndex = 0;
            // 
            // lstAccommodation
            // 
            this.lstAccommodation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAccommodation.FormattingEnabled = true;
            this.lstAccommodation.Location = new System.Drawing.Point(0, 0);
            this.lstAccommodation.Margin = new System.Windows.Forms.Padding(2);
            this.lstAccommodation.Name = "lstAccommodation";
            this.lstAccommodation.Size = new System.Drawing.Size(352, 206);
            this.lstAccommodation.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.pictureBox1.Location = new System.Drawing.Point(888, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuotation";
            this.Text = "frmQuotation";
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlBookingDetails.ResumeLayout(false);
            this.pnlBookingDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlavailibleAccommodation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlavailibleAccommodation;
        private System.Windows.Forms.ListBox lstAccommodation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBookingDetails;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbAccommodation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeneratQuote;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearLst;
    }
}