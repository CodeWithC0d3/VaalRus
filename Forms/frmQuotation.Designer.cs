
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuotation));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnQuote = new System.Windows.Forms.Button();
            this.lstAccommodation = new System.Windows.Forms.ListBox();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.btnClearLst = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccommodation = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnGeneratQuote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_grid = new System.Windows.Forms.Panel();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grid_main = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.ch_to = new System.Windows.Forms.CheckBox();
            this.rb_booking = new System.Windows.Forms.RadioButton();
            this.rb_quote = new System.Windows.Forms.RadioButton();
            this.dp_filterTo = new System.Windows.Forms.DateTimePicker();
            this.dp_filterFrom = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_accSet = new System.Windows.Forms.Panel();
            this.grid_accSet = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pn_grid.SuspendLayout();
            this.pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvider)).BeginInit();
            this.pnl_accSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_accSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.pnlMain.Controls.Add(this.btnQuote);
            this.pnlMain.Controls.Add(this.lstAccommodation);
            this.pnlMain.Controls.Add(this.dpTo);
            this.pnlMain.Controls.Add(this.btnClearLst);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.cmbFilter);
            this.pnlMain.Controls.Add(this.dpFrom);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.cmbAccommodation);
            this.pnlMain.Controls.Add(this.cmbCustomer);
            this.pnlMain.Controls.Add(this.btnGeneratQuote);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtUser);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(315, 510);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Visible = false;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnQuote
            // 
            this.btnQuote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuote.Enabled = false;
            this.btnQuote.Location = new System.Drawing.Point(218, 442);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(87, 53);
            this.btnQuote.TabIndex = 21;
            this.btnQuote.Text = "GetQuote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // lstAccommodation
            // 
            this.lstAccommodation.FormattingEnabled = true;
            this.lstAccommodation.Location = new System.Drawing.Point(15, 302);
            this.lstAccommodation.Margin = new System.Windows.Forms.Padding(2);
            this.lstAccommodation.Name = "lstAccommodation";
            this.lstAccommodation.Size = new System.Drawing.Size(290, 121);
            this.lstAccommodation.TabIndex = 30;
            // 
            // dpTo
            // 
            this.dpTo.Location = new System.Drawing.Point(90, 150);
            this.dpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(177, 20);
            this.dpTo.TabIndex = 13;
            // 
            // btnClearLst
            // 
            this.btnClearLst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearLst.Location = new System.Drawing.Point(15, 442);
            this.btnClearLst.Name = "btnClearLst";
            this.btnClearLst.Size = new System.Drawing.Size(87, 53);
            this.btnClearLst.TabIndex = 19;
            this.btnClearLst.Text = "Clear List";
            this.btnClearLst.UseVisualStyleBackColor = true;
            this.btnClearLst.Click += new System.EventHandler(this.btnClearLst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All"});
            this.cmbFilter.Location = new System.Drawing.Point(90, 193);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(72, 21);
            this.cmbFilter.TabIndex = 17;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(90, 107);
            this.dpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(177, 20);
            this.dpFrom.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // cmbAccommodation
            // 
            this.cmbAccommodation.Enabled = false;
            this.cmbAccommodation.FormattingEnabled = true;
            this.cmbAccommodation.Location = new System.Drawing.Point(15, 276);
            this.cmbAccommodation.Name = "cmbAccommodation";
            this.cmbAccommodation.Size = new System.Drawing.Size(290, 21);
            this.cmbAccommodation.TabIndex = 18;
            this.cmbAccommodation.DropDown += new System.EventHandler(this.cmbAccommodation_DropDown);
            this.cmbAccommodation.SelectedIndexChanged += new System.EventHandler(this.cmbAccommodation_SelectedIndexChanged);
            this.cmbAccommodation.DropDownClosed += new System.EventHandler(this.cmbAccommodation_DropDownClosed);
            this.cmbAccommodation.Enter += new System.EventHandler(this.cmbAccommodation_Enter);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(90, 65);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(199, 21);
            this.cmbCustomer.TabIndex = 9;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.Click += new System.EventHandler(this.cmbCustomer_Click);
            this.cmbCustomer.Enter += new System.EventHandler(this.cmbCustomer_Enter);
            this.cmbCustomer.Validated += new System.EventHandler(this.cmbCustomer_Validated);
            // 
            // btnGeneratQuote
            // 
            this.btnGeneratQuote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGeneratQuote.Location = new System.Drawing.Point(108, 442);
            this.btnGeneratQuote.Name = "btnGeneratQuote";
            this.btnGeneratQuote.Size = new System.Drawing.Size(104, 53);
            this.btnGeneratQuote.TabIndex = 20;
            this.btnGeneratQuote.Text = "Create Quote";
            this.btnGeneratQuote.UseVisualStyleBackColor = true;
            this.btnGeneratQuote.Click += new System.EventHandler(this.btnGeneratQuote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Add Accommodation";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(90, 27);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(199, 20);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Validated += new System.EventHandler(this.txtUser_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // pn_grid
            // 
            this.pn_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_grid.Controls.Add(this.pnlReport);
            this.pn_grid.Controls.Add(this.grid_main);
            this.pn_grid.Controls.Add(this.pnlFilter);
            this.pn_grid.Location = new System.Drawing.Point(333, 12);
            this.pn_grid.Name = "pn_grid";
            this.pn_grid.Size = new System.Drawing.Size(634, 304);
            this.pn_grid.TabIndex = 9;
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.button1);
            this.pnlReport.Controls.Add(this.reportViewer1);
            this.pnlReport.Location = new System.Drawing.Point(155, 68);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(346, 236);
            this.pnlReport.TabIndex = 12;
            this.pnlReport.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(3, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "CloseReport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(346, 236);
            this.reportViewer1.TabIndex = 2;
            // 
            // grid_main
            // 
            this.grid_main.AllowUserToAddRows = false;
            this.grid_main.AllowUserToDeleteRows = false;
            this.grid_main.AllowUserToResizeRows = false;
            this.grid_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(95)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_main.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_main.EnableHeadersVisualStyles = false;
            this.grid_main.Location = new System.Drawing.Point(0, 57);
            this.grid_main.MultiSelect = false;
            this.grid_main.Name = "grid_main";
            this.grid_main.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_main.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_main.RowHeadersVisible = false;
            this.grid_main.RowTemplate.ReadOnly = true;
            this.grid_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_main.Size = new System.Drawing.Size(634, 247);
            this.grid_main.TabIndex = 10;
            this.grid_main.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_main_CellMouseClick);
            this.grid_main.SelectionChanged += new System.EventHandler(this.grid_main_SelectionChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.ch_to);
            this.pnlFilter.Controls.Add(this.rb_booking);
            this.pnlFilter.Controls.Add(this.rb_quote);
            this.pnlFilter.Controls.Add(this.dp_filterTo);
            this.pnlFilter.Controls.Add(this.dp_filterFrom);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(634, 57);
            this.pnlFilter.TabIndex = 9;
            // 
            // ch_to
            // 
            this.ch_to.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ch_to.AutoSize = true;
            this.ch_to.Location = new System.Drawing.Point(267, 28);
            this.ch_to.Name = "ch_to";
            this.ch_to.Size = new System.Drawing.Size(41, 17);
            this.ch_to.TabIndex = 7;
            this.ch_to.Text = "TO";
            this.ch_to.UseVisualStyleBackColor = true;
            this.ch_to.CheckedChanged += new System.EventHandler(this.ch_to_CheckedChanged);
            // 
            // rb_booking
            // 
            this.rb_booking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_booking.AutoSize = true;
            this.rb_booking.Location = new System.Drawing.Point(81, 32);
            this.rb_booking.Name = "rb_booking";
            this.rb_booking.Size = new System.Drawing.Size(106, 17);
            this.rb_booking.TabIndex = 6;
            this.rb_booking.TabStop = true;
            this.rb_booking.Text = "Current Bookings";
            this.rb_booking.UseVisualStyleBackColor = true;
            this.rb_booking.CheckedChanged += new System.EventHandler(this.rb_booking_CheckedChanged);
            // 
            // rb_quote
            // 
            this.rb_quote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_quote.AutoSize = true;
            this.rb_quote.Location = new System.Drawing.Point(81, 8);
            this.rb_quote.Name = "rb_quote";
            this.rb_quote.Size = new System.Drawing.Size(59, 17);
            this.rb_quote.TabIndex = 5;
            this.rb_quote.TabStop = true;
            this.rb_quote.Text = "Quotes";
            this.rb_quote.UseVisualStyleBackColor = true;
            this.rb_quote.CheckedChanged += new System.EventHandler(this.rb_quote_CheckedChanged);
            // 
            // dp_filterTo
            // 
            this.dp_filterTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dp_filterTo.Enabled = false;
            this.dp_filterTo.Location = new System.Drawing.Point(323, 28);
            this.dp_filterTo.Name = "dp_filterTo";
            this.dp_filterTo.Size = new System.Drawing.Size(218, 20);
            this.dp_filterTo.TabIndex = 3;
            this.dp_filterTo.ValueChanged += new System.EventHandler(this.dp_filterTo_ValueChanged);
            // 
            // dp_filterFrom
            // 
            this.dp_filterFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dp_filterFrom.Enabled = false;
            this.dp_filterFrom.Location = new System.Drawing.Point(323, 4);
            this.dp_filterFrom.Name = "dp_filterFrom";
            this.dp_filterFrom.Size = new System.Drawing.Size(218, 20);
            this.dp_filterFrom.TabIndex = 1;
            this.dp_filterFrom.ValueChanged += new System.EventHandler(this.dp_filterFrom_ValueChanged);
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
            this.pictureBox1.Location = new System.Drawing.Point(909, 606);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // erProvider
            // 
            this.erProvider.ContainerControl = this;
            // 
            // pnl_accSet
            // 
            this.pnl_accSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_accSet.Controls.Add(this.grid_accSet);
            this.pnl_accSet.Controls.Add(this.groupBox1);
            this.pnl_accSet.Location = new System.Drawing.Point(333, 350);
            this.pnl_accSet.Name = "pnl_accSet";
            this.pnl_accSet.Size = new System.Drawing.Size(634, 172);
            this.pnl_accSet.TabIndex = 10;
            // 
            // grid_accSet
            // 
            this.grid_accSet.AllowUserToAddRows = false;
            this.grid_accSet.AllowUserToDeleteRows = false;
            this.grid_accSet.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_accSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_accSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_accSet.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_accSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_accSet.EnableHeadersVisualStyles = false;
            this.grid_accSet.Location = new System.Drawing.Point(0, 0);
            this.grid_accSet.MultiSelect = false;
            this.grid_accSet.Name = "grid_accSet";
            this.grid_accSet.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_accSet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_accSet.RowHeadersVisible = false;
            this.grid_accSet.RowTemplate.ReadOnly = true;
            this.grid_accSet.Size = new System.Drawing.Size(634, 172);
            this.grid_accSet.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(270, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Accommodation Set";
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnl_accSet);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pn_grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuotation";
            this.Text = "frmQuotation";
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pn_grid.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erProvider)).EndInit();
            this.pnl_accSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_accSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAccommodation;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pn_grid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbAccommodation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeneratQuote;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearLst;
        private System.Windows.Forms.DataGridView grid_main;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.DateTimePicker dp_filterTo;
        private System.Windows.Forms.DateTimePicker dp_filterFrom;
        private System.Windows.Forms.ErrorProvider erProvider;
        private System.Windows.Forms.RadioButton rb_booking;
        private System.Windows.Forms.RadioButton rb_quote;
        private System.Windows.Forms.CheckBox ch_to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_accSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_accSet;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuote;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}