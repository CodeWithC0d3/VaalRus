
namespace vaalrusGUIPrototype.Forms
{
    partial class frmNewBooking
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.txtRecievedAmount = new System.Windows.Forms.TextBox();
            this.dpRecieved = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlBookDetail = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtQuotenr = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lsAcc = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCusInformation = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.ch_dateRange = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.ch_to = new System.Windows.Forms.CheckBox();
            this.dp_filterTo = new System.Windows.Forms.DateTimePicker();
            this.dp_filterFrom = new System.Windows.Forms.DateTimePicker();
            this.txtFilterQuote = new System.Windows.Forms.TextBox();
            this.txtFilterID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlBookDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlCusInformation.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(16, 7);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(432, 718);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCreate);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 574);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(432, 144);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(141, 4);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlPayment);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 453);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(432, 121);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirm Payment";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.txtRecievedAmount);
            this.pnlPayment.Controls.Add(this.dpRecieved);
            this.pnlPayment.Controls.Add(this.label14);
            this.pnlPayment.Controls.Add(this.label15);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPayment.Location = new System.Drawing.Point(4, 19);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(424, 98);
            this.pnlPayment.TabIndex = 6;
            this.pnlPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPayment_Paint);
            // 
            // txtRecievedAmount
            // 
            this.txtRecievedAmount.Location = new System.Drawing.Point(153, 66);
            this.txtRecievedAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecievedAmount.Name = "txtRecievedAmount";
            this.txtRecievedAmount.Size = new System.Drawing.Size(115, 22);
            this.txtRecievedAmount.TabIndex = 13;
            this.txtRecievedAmount.TextChanged += new System.EventHandler(this.txtRecievedAmount_TextChanged);
            // 
            // dpRecieved
            // 
            this.dpRecieved.Location = new System.Drawing.Point(153, 31);
            this.dpRecieved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpRecieved.Name = "dpRecieved";
            this.dpRecieved.Size = new System.Drawing.Size(265, 22);
            this.dpRecieved.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 70);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Recieved Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Date Recieved";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlBookDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(432, 249);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quote Details";
            // 
            // pnlBookDetail
            // 
            this.pnlBookDetail.Controls.Add(this.txtAmount);
            this.pnlBookDetail.Controls.Add(this.txtEndDate);
            this.pnlBookDetail.Controls.Add(this.txtStartDate);
            this.pnlBookDetail.Controls.Add(this.txtQuotenr);
            this.pnlBookDetail.Controls.Add(this.label16);
            this.pnlBookDetail.Controls.Add(this.label12);
            this.pnlBookDetail.Controls.Add(this.lsAcc);
            this.pnlBookDetail.Controls.Add(this.label11);
            this.pnlBookDetail.Controls.Add(this.label10);
            this.pnlBookDetail.Controls.Add(this.label9);
            this.pnlBookDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookDetail.Location = new System.Drawing.Point(4, 19);
            this.pnlBookDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBookDetail.Name = "pnlBookDetail";
            this.pnlBookDetail.Size = new System.Drawing.Size(424, 226);
            this.pnlBookDetail.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(153, 113);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(115, 22);
            this.txtAmount.TabIndex = 9;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Enabled = false;
            this.txtEndDate.Location = new System.Drawing.Point(153, 79);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(191, 22);
            this.txtEndDate.TabIndex = 8;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Location = new System.Drawing.Point(153, 42);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(191, 22);
            this.txtStartDate.TabIndex = 7;
            // 
            // txtQuotenr
            // 
            this.txtQuotenr.Enabled = false;
            this.txtQuotenr.Location = new System.Drawing.Point(153, 4);
            this.txtQuotenr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuotenr.Name = "txtQuotenr";
            this.txtQuotenr.Size = new System.Drawing.Size(73, 22);
            this.txtQuotenr.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 117);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Amount Required";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Accommodation";
            // 
            // lsAcc
            // 
            this.lsAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsAcc.FormattingEnabled = true;
            this.lsAcc.ItemHeight = 16;
            this.lsAcc.Location = new System.Drawing.Point(4, 164);
            this.lsAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsAcc.Name = "lsAcc";
            this.lsAcc.Size = new System.Drawing.Size(415, 36);
            this.lsAcc.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "End date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Start date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quote Nr";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlCusInformation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(432, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // pnlCusInformation
            // 
            this.pnlCusInformation.Controls.Add(this.txtemail);
            this.pnlCusInformation.Controls.Add(this.txtCell);
            this.pnlCusInformation.Controls.Add(this.txtIdNumber);
            this.pnlCusInformation.Controls.Add(this.txtlastName);
            this.pnlCusInformation.Controls.Add(this.txtname);
            this.pnlCusInformation.Controls.Add(this.label8);
            this.pnlCusInformation.Controls.Add(this.label7);
            this.pnlCusInformation.Controls.Add(this.label6);
            this.pnlCusInformation.Controls.Add(this.label5);
            this.pnlCusInformation.Controls.Add(this.label4);
            this.pnlCusInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCusInformation.Location = new System.Drawing.Point(4, 19);
            this.pnlCusInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCusInformation.Name = "pnlCusInformation";
            this.pnlCusInformation.Size = new System.Drawing.Size(424, 181);
            this.pnlCusInformation.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(153, 149);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(243, 22);
            this.txtemail.TabIndex = 9;
            // 
            // txtCell
            // 
            this.txtCell.Enabled = false;
            this.txtCell.Location = new System.Drawing.Point(153, 113);
            this.txtCell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(173, 22);
            this.txtCell.TabIndex = 8;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Enabled = false;
            this.txtIdNumber.Location = new System.Drawing.Point(153, 78);
            this.txtIdNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(173, 22);
            this.txtIdNumber.TabIndex = 7;
            // 
            // txtlastName
            // 
            this.txtlastName.Enabled = false;
            this.txtlastName.Location = new System.Drawing.Point(153, 42);
            this.txtlastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(224, 22);
            this.txtlastName.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(153, 6);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(224, 22);
            this.txtname.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cell";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID nr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Controls.Add(this.grid);
            this.pnlGrid.Controls.Add(this.pnlFilter);
            this.pnlGrid.Location = new System.Drawing.Point(456, 7);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1136, 718);
            this.pnlGrid.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 149);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.Size = new System.Drawing.Size(1136, 569);
            this.grid.TabIndex = 1;
            this.grid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grid_ColumnAdded);
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.ch_dateRange);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.ch_to);
            this.pnlFilter.Controls.Add(this.dp_filterTo);
            this.pnlFilter.Controls.Add(this.dp_filterFrom);
            this.pnlFilter.Controls.Add(this.txtFilterQuote);
            this.pnlFilter.Controls.Add(this.txtFilterID);
            this.pnlFilter.Controls.Add(this.label19);
            this.pnlFilter.Controls.Add(this.label18);
            this.pnlFilter.Controls.Add(this.panel4);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1136, 149);
            this.pnlFilter.TabIndex = 0;
            // 
            // ch_dateRange
            // 
            this.ch_dateRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ch_dateRange.AutoSize = true;
            this.ch_dateRange.Location = new System.Drawing.Point(4, 50);
            this.ch_dateRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ch_dateRange.Name = "ch_dateRange";
            this.ch_dateRange.Size = new System.Drawing.Size(130, 21);
            this.ch_dateRange.TabIndex = 12;
            this.ch_dateRange.Text = "Add Date range";
            this.ch_dateRange.UseVisualStyleBackColor = true;
            this.ch_dateRange.CheckedChanged += new System.EventHandler(this.ch_dateRange_CheckedChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(517, 47);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 86);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ch_to
            // 
            this.ch_to.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ch_to.AutoSize = true;
            this.ch_to.Location = new System.Drawing.Point(4, 82);
            this.ch_to.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ch_to.Name = "ch_to";
            this.ch_to.Size = new System.Drawing.Size(50, 21);
            this.ch_to.TabIndex = 10;
            this.ch_to.Text = "TO";
            this.ch_to.UseVisualStyleBackColor = true;
            this.ch_to.CheckedChanged += new System.EventHandler(this.ch_to_CheckedChanged);
            // 
            // dp_filterTo
            // 
            this.dp_filterTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dp_filterTo.Enabled = false;
            this.dp_filterTo.Location = new System.Drawing.Point(172, 76);
            this.dp_filterTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dp_filterTo.Name = "dp_filterTo";
            this.dp_filterTo.Size = new System.Drawing.Size(316, 22);
            this.dp_filterTo.TabIndex = 9;
            this.dp_filterTo.ValueChanged += new System.EventHandler(this.dp_filterTo_ValueChanged);
            // 
            // dp_filterFrom
            // 
            this.dp_filterFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dp_filterFrom.Enabled = false;
            this.dp_filterFrom.Location = new System.Drawing.Point(172, 47);
            this.dp_filterFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dp_filterFrom.Name = "dp_filterFrom";
            this.dp_filterFrom.Size = new System.Drawing.Size(316, 22);
            this.dp_filterFrom.TabIndex = 8;
            this.dp_filterFrom.ValueChanged += new System.EventHandler(this.dp_filterFrom_ValueChanged);
            this.dp_filterFrom.Validated += new System.EventHandler(this.dp_filterFrom_Validated);
            // 
            // txtFilterQuote
            // 
            this.txtFilterQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterQuote.Location = new System.Drawing.Point(356, 108);
            this.txtFilterQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterQuote.Name = "txtFilterQuote";
            this.txtFilterQuote.Size = new System.Drawing.Size(132, 22);
            this.txtFilterQuote.TabIndex = 4;
            this.txtFilterQuote.TextChanged += new System.EventHandler(this.txtFilterQuote_TextChanged);
            this.txtFilterQuote.Validated += new System.EventHandler(this.txtFilterQuote_Validated);
            // 
            // txtFilterID
            // 
            this.txtFilterID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterID.Location = new System.Drawing.Point(113, 108);
            this.txtFilterID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterID.Name = "txtFilterID";
            this.txtFilterID.Size = new System.Drawing.Size(132, 22);
            this.txtFilterID.TabIndex = 3;
            this.txtFilterID.TextChanged += new System.EventHandler(this.txtFilterID_TextChanged);
            this.txtFilterID.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterID_Validating);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(268, 112);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 17);
            this.label19.TabIndex = 2;
            this.label19.Text = "Quote Nr";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 114);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Customer ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1136, 43);
            this.panel4.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(21, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "Filter Options";
            // 
            // frmNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1608, 747);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNewBooking";
            this.Text = "frmNewBooking";
            this.Load += new System.EventHandler(this.frmNewBooking_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlBookDetail.ResumeLayout(false);
            this.pnlBookDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlCusInformation.ResumeLayout(false);
            this.pnlCusInformation.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Panel pnlBookDetail;
        private System.Windows.Forms.Panel pnlCusInformation;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lsAcc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TextBox txtRecievedAmount;
        private System.Windows.Forms.DateTimePicker dpRecieved;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtQuotenr;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox ch_to;
        private System.Windows.Forms.DateTimePicker dp_filterTo;
        private System.Windows.Forms.DateTimePicker dp_filterFrom;
        private System.Windows.Forms.TextBox txtFilterQuote;
        private System.Windows.Forms.TextBox txtFilterID;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox ch_dateRange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}