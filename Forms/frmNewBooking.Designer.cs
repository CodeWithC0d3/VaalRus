﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.txtRecievedAmount = new System.Windows.Forms.TextBox();
            this.dpRecieved = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFilterID = new System.Windows.Forms.TextBox();
            this.txtFilterQuote = new System.Windows.Forms.TextBox();
            this.ch_to = new System.Windows.Forms.CheckBox();
            this.dp_filterTo = new System.Windows.Forms.DateTimePicker();
            this.dp_filterFrom = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ch_dateRange = new System.Windows.Forms.CheckBox();
            this.pnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlBookDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCusInformation.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.pnlPayment);
            this.pnlMain.Controls.Add(this.pnlBookDetail);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.pnlCusInformation);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(12, 6);
            this.pnlMain.MinimumSize = new System.Drawing.Size(354, 489);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(354, 583);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.button1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 455);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(354, 128);
            this.pnlButtons.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.txtRecievedAmount);
            this.pnlPayment.Controls.Add(this.dpRecieved);
            this.pnlPayment.Controls.Add(this.label14);
            this.pnlPayment.Controls.Add(this.label15);
            this.pnlPayment.Controls.Add(this.panel3);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPayment.Location = new System.Drawing.Point(0, 374);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(354, 81);
            this.pnlPayment.TabIndex = 6;
            this.pnlPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPayment_Paint);
            // 
            // txtRecievedAmount
            // 
            this.txtRecievedAmount.Location = new System.Drawing.Point(147, 54);
            this.txtRecievedAmount.Name = "txtRecievedAmount";
            this.txtRecievedAmount.Size = new System.Drawing.Size(87, 20);
            this.txtRecievedAmount.TabIndex = 13;
            // 
            // dpRecieved
            // 
            this.dpRecieved.Location = new System.Drawing.Point(147, 25);
            this.dpRecieved.Name = "dpRecieved";
            this.dpRecieved.Size = new System.Drawing.Size(200, 20);
            this.dpRecieved.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Recieved Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Date Recieved";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 20);
            this.panel3.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Confirm Payment";
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
            this.pnlBookDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBookDetail.Location = new System.Drawing.Point(0, 191);
            this.pnlBookDetail.Name = "pnlBookDetail";
            this.pnlBookDetail.Size = new System.Drawing.Size(354, 183);
            this.pnlBookDetail.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(147, 92);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(87, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(147, 64);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(144, 20);
            this.txtEndDate.TabIndex = 8;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(147, 34);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(144, 20);
            this.txtStartDate.TabIndex = 7;
            // 
            // txtQuotenr
            // 
            this.txtQuotenr.Location = new System.Drawing.Point(147, 3);
            this.txtQuotenr.Name = "txtQuotenr";
            this.txtQuotenr.Size = new System.Drawing.Size(56, 20);
            this.txtQuotenr.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Amount Required";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Accommodation";
            // 
            // lsAcc
            // 
            this.lsAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsAcc.FormattingEnabled = true;
            this.lsAcc.Location = new System.Drawing.Point(3, 133);
            this.lsAcc.Name = "lsAcc";
            this.lsAcc.Size = new System.Drawing.Size(348, 43);
            this.lsAcc.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "End date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Start date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quote Nr";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 21);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quote Details";
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
            this.pnlCusInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCusInformation.Location = new System.Drawing.Point(0, 23);
            this.pnlCusInformation.Name = "pnlCusInformation";
            this.pnlCusInformation.Size = new System.Drawing.Size(354, 147);
            this.pnlCusInformation.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(147, 121);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(204, 20);
            this.txtemail.TabIndex = 9;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(147, 92);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(131, 20);
            this.txtCell.TabIndex = 8;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(147, 63);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(131, 20);
            this.txtIdNumber.TabIndex = 7;
            // 
            // txtlastName
            // 
            this.txtlastName.Location = new System.Drawing.Point(147, 34);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(169, 20);
            this.txtlastName.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(147, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 20);
            this.txtname.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cell";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID nr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 23);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Controls.Add(this.grid);
            this.pnlGrid.Controls.Add(this.pnlFilter);
            this.pnlGrid.Location = new System.Drawing.Point(382, 6);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(812, 583);
            this.pnlGrid.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 177);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(812, 406);
            this.grid.TabIndex = 1;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.ch_dateRange);
            this.pnlFilter.Controls.Add(this.button2);
            this.pnlFilter.Controls.Add(this.label20);
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
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(812, 177);
            this.pnlFilter.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(812, 35);
            this.panel4.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(16, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Filter Options";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Customer ID";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(192, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Quote Nr";
            // 
            // txtFilterID
            // 
            this.txtFilterID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterID.Location = new System.Drawing.Point(86, 35);
            this.txtFilterID.Name = "txtFilterID";
            this.txtFilterID.Size = new System.Drawing.Size(100, 20);
            this.txtFilterID.TabIndex = 3;
            // 
            // txtFilterQuote
            // 
            this.txtFilterQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterQuote.Location = new System.Drawing.Point(275, 34);
            this.txtFilterQuote.Name = "txtFilterQuote";
            this.txtFilterQuote.Size = new System.Drawing.Size(100, 20);
            this.txtFilterQuote.TabIndex = 4;
            // 
            // ch_to
            // 
            this.ch_to.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ch_to.AutoSize = true;
            this.ch_to.Location = new System.Drawing.Point(3, 109);
            this.ch_to.Name = "ch_to";
            this.ch_to.Size = new System.Drawing.Size(41, 17);
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
            this.dp_filterTo.Location = new System.Drawing.Point(50, 106);
            this.dp_filterTo.Name = "dp_filterTo";
            this.dp_filterTo.Size = new System.Drawing.Size(218, 20);
            this.dp_filterTo.TabIndex = 9;
            // 
            // dp_filterFrom
            // 
            this.dp_filterFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dp_filterFrom.Enabled = false;
            this.dp_filterFrom.Location = new System.Drawing.Point(50, 82);
            this.dp_filterFrom.Name = "dp_filterFrom";
            this.dp_filterFrom.Size = new System.Drawing.Size(218, 20);
            this.dp_filterFrom.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(0, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "From";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ch_dateRange
            // 
            this.ch_dateRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ch_dateRange.AutoSize = true;
            this.ch_dateRange.Location = new System.Drawing.Point(3, 61);
            this.ch_dateRange.Name = "ch_dateRange";
            this.ch_dateRange.Size = new System.Drawing.Size(101, 17);
            this.ch_dateRange.TabIndex = 12;
            this.ch_dateRange.Text = "Add Date range";
            this.ch_dateRange.UseVisualStyleBackColor = true;
            this.ch_dateRange.CheckedChanged += new System.EventHandler(this.ch_dateRange_CheckedChanged);
            // 
            // frmNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 607);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmNewBooking";
            this.Text = "frmNewBooking";
            this.Load += new System.EventHandler(this.frmNewBooking_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlBookDetail.ResumeLayout(false);
            this.pnlBookDetail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCusInformation.ResumeLayout(false);
            this.pnlCusInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox ch_to;
        private System.Windows.Forms.DateTimePicker dp_filterTo;
        private System.Windows.Forms.DateTimePicker dp_filterFrom;
        private System.Windows.Forms.TextBox txtFilterQuote;
        private System.Windows.Forms.TextBox txtFilterID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ch_dateRange;
    }
}