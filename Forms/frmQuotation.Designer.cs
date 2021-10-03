
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_booking = new System.Windows.Forms.RadioButton();
            this.rb_quote = new System.Windows.Forms.RadioButton();
            this.dp_filterTo = new System.Windows.Forms.DateTimePicker();
            this.dp_filterFrom = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ch_to = new System.Windows.Forms.CheckBox();
            this.pnl_accSet = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_accSet = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pn_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
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
            this.pnlMain.Size = new System.Drawing.Size(315, 642);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Visible = false;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // lstAccommodation
            // 
            this.lstAccommodation.FormattingEnabled = true;
            this.lstAccommodation.Location = new System.Drawing.Point(15, 302);
            this.lstAccommodation.Margin = new System.Windows.Forms.Padding(2);
            this.lstAccommodation.Name = "lstAccommodation";
            this.lstAccommodation.Size = new System.Drawing.Size(290, 134);
            this.lstAccommodation.TabIndex = 0;
            // 
            // dpTo
            // 
            this.dpTo.Location = new System.Drawing.Point(75, 150);
            this.dpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(177, 20);
            this.dpTo.TabIndex = 13;
            // 
            // btnClearLst
            // 
            this.btnClearLst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLst.Location = new System.Drawing.Point(8, 577);
            this.btnClearLst.Name = "btnClearLst";
            this.btnClearLst.Size = new System.Drawing.Size(103, 53);
            this.btnClearLst.TabIndex = 18;
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
            this.cmbFilter.Location = new System.Drawing.Point(75, 193);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(72, 21);
            this.cmbFilter.TabIndex = 17;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(75, 107);
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
            this.cmbAccommodation.TabIndex = 15;
            this.cmbAccommodation.DropDown += new System.EventHandler(this.cmbAccommodation_DropDown);
            this.cmbAccommodation.SelectedIndexChanged += new System.EventHandler(this.cmbAccommodation_SelectedIndexChanged);
            this.cmbAccommodation.DropDownClosed += new System.EventHandler(this.cmbAccommodation_DropDownClosed);
            this.cmbAccommodation.Enter += new System.EventHandler(this.cmbAccommodation_Enter);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(75, 65);
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
            this.btnGeneratQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGeneratQuote.Location = new System.Drawing.Point(213, 577);
            this.btnGeneratQuote.Name = "btnGeneratQuote";
            this.btnGeneratQuote.Size = new System.Drawing.Size(92, 53);
            this.btnGeneratQuote.TabIndex = 1;
            this.btnGeneratQuote.Text = "Generate Quote";
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
            this.txtUser.Location = new System.Drawing.Point(75, 27);
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
            this.pn_grid.Controls.Add(this.dataGridView1);
            this.pn_grid.Controls.Add(this.panel2);
            this.pn_grid.Location = new System.Drawing.Point(333, 12);
            this.pn_grid.Name = "pn_grid";
            this.pn_grid.Size = new System.Drawing.Size(658, 436);
            this.pn_grid.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 379);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(146)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.ch_to);
            this.panel2.Controls.Add(this.rb_booking);
            this.panel2.Controls.Add(this.rb_quote);
            this.panel2.Controls.Add(this.dp_filterTo);
            this.panel2.Controls.Add(this.dp_filterFrom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 57);
            this.panel2.TabIndex = 9;
            // 
            // rb_booking
            // 
            this.rb_booking.AutoSize = true;
            this.rb_booking.Location = new System.Drawing.Point(13, 32);
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
            this.rb_quote.AutoSize = true;
            this.rb_quote.Location = new System.Drawing.Point(13, 8);
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
            this.dp_filterTo.Location = new System.Drawing.Point(242, 28);
            this.dp_filterTo.Name = "dp_filterTo";
            this.dp_filterTo.Size = new System.Drawing.Size(218, 20);
            this.dp_filterTo.TabIndex = 3;
            this.dp_filterTo.ValueChanged += new System.EventHandler(this.dp_filterTo_ValueChanged);
            // 
            // dp_filterFrom
            // 
            this.dp_filterFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dp_filterFrom.Enabled = false;
            this.dp_filterFrom.Location = new System.Drawing.Point(182, 4);
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
            this.pictureBox1.Location = new System.Drawing.Point(982, 641);
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
            // ch_to
            // 
            this.ch_to.AutoSize = true;
            this.ch_to.Location = new System.Drawing.Point(182, 32);
            this.ch_to.Name = "ch_to";
            this.ch_to.Size = new System.Drawing.Size(41, 17);
            this.ch_to.TabIndex = 7;
            this.ch_to.Text = "TO";
            this.ch_to.UseVisualStyleBackColor = true;
            this.ch_to.CheckedChanged += new System.EventHandler(this.ch_to_CheckedChanged);
            // 
            // pnl_accSet
            // 
            this.pnl_accSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_accSet.Controls.Add(this.grid_accSet);
            this.pnl_accSet.Controls.Add(this.groupBox1);
            this.pnl_accSet.Location = new System.Drawing.Point(333, 482);
            this.pnl_accSet.Name = "pnl_accSet";
            this.pnl_accSet.Size = new System.Drawing.Size(658, 172);
            this.pnl_accSet.TabIndex = 10;
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
            // grid_accSet
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_accSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid_accSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_accSet.DefaultCellStyle = dataGridViewCellStyle17;
            this.grid_accSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_accSet.Location = new System.Drawing.Point(0, 0);
            this.grid_accSet.Name = "grid_accSet";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_accSet.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grid_accSet.Size = new System.Drawing.Size(658, 172);
            this.grid_accSet.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Acc Set";
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 666);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnl_accSet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pn_grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuotation";
            this.Text = "frmQuotation";
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pn_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dp_filterTo;
        private System.Windows.Forms.DateTimePicker dp_filterFrom;
        private System.Windows.Forms.ErrorProvider erProvider;
        private System.Windows.Forms.RadioButton rb_booking;
        private System.Windows.Forms.RadioButton rb_quote;
        private System.Windows.Forms.CheckBox ch_to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_accSet;
        private System.Windows.Forms.DataGridView grid_accSet;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}