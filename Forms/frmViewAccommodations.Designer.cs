
namespace vaalrusGUIPrototype
{
    partial class frmViewAccommodations
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
            this.dtgViewAcc = new System.Windows.Forms.DataGridView();
            this.pnlView = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBooked = new System.Windows.Forms.Button();
            this.dpto = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fromDateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewAcc)).BeginInit();
            this.pnlView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgViewAcc
            // 
            this.dtgViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgViewAcc.Location = new System.Drawing.Point(0, 0);
            this.dtgViewAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgViewAcc.Name = "dtgViewAcc";
            this.dtgViewAcc.RowHeadersWidth = 51;
            this.dtgViewAcc.RowTemplate.Height = 24;
            this.dtgViewAcc.Size = new System.Drawing.Size(464, 433);
            this.dtgViewAcc.TabIndex = 0;
            this.dtgViewAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.groupBox1);
            this.pnlView.Controls.Add(this.panel2);
            this.pnlView.Controls.Add(this.button1);
            this.pnlView.Location = new System.Drawing.Point(9, 10);
            this.pnlView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(324, 349);
            this.pnlView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(300, 193);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Details:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dpFrom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnBooked);
            this.panel3.Controls.Add(this.dpto);
            this.panel3.Location = new System.Drawing.Point(4, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 171);
            this.panel3.TabIndex = 9;
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(61, 2);
            this.dpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(219, 20);
            this.dpFrom.TabIndex = 7;
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 89);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Available Accommodation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBooked
            // 
            this.btnBooked.Location = new System.Drawing.Point(154, 89);
            this.btnBooked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBooked.Name = "btnBooked";
            this.btnBooked.Size = new System.Drawing.Size(124, 69);
            this.btnBooked.TabIndex = 1;
            this.btnBooked.Text = "Booked Accommodation";
            this.btnBooked.UseVisualStyleBackColor = true;
            this.btnBooked.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dpto
            // 
            this.dpto.Location = new System.Drawing.Point(61, 51);
            this.dpto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpto.Name = "dpto";
            this.dpto.Size = new System.Drawing.Size(219, 20);
            this.dpto.TabIndex = 8;
            this.dpto.ValueChanged += new System.EventHandler(this.dpto_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(308, 332);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 81);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display All Accommodations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgViewAcc);
            this.panel1.Location = new System.Drawing.Point(338, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 433);
            this.panel1.TabIndex = 2;
            // 
            // fromDateErrorProvider
            // 
            this.fromDateErrorProvider.ContainerControl = this;
            // 
            // frmViewAccommodations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(117)))));
            this.BackgroundImage = global::vaalrusGUIPrototype.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 491);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewAccommodations";
            this.Text = "frmViewAccommodations";
            this.Load += new System.EventHandler(this.frmViewAccommodations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewAcc)).EndInit();
            this.pnlView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fromDateErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViewAcc;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBooked;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpto;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider fromDateErrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
    }
}