
namespace vaalrusGUIPrototype
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnConString = new System.Windows.Forms.Button();
            this.pnlConnetionControls = new System.Windows.Forms.Panel();
            this.btnCreateDatabAse = new System.Windows.Forms.Button();
            this.txtConString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.btnTestData = new System.Windows.Forms.Button();
            this.pnlConnetionControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConString
            // 
            this.btnConString.Location = new System.Drawing.Point(285, 3);
            this.btnConString.Name = "btnConString";
            this.btnConString.Size = new System.Drawing.Size(165, 35);
            this.btnConString.TabIndex = 1;
            this.btnConString.Text = "Build";
            this.btnConString.UseVisualStyleBackColor = true;
            this.btnConString.Click += new System.EventHandler(this.btnConString_Click);
            // 
            // pnlConnetionControls
            // 
            this.pnlConnetionControls.Controls.Add(this.btnTestData);
            this.pnlConnetionControls.Controls.Add(this.btnCreateDatabAse);
            this.pnlConnetionControls.Controls.Add(this.txtConString);
            this.pnlConnetionControls.Controls.Add(this.label1);
            this.pnlConnetionControls.Controls.Add(this.btnConString);
            this.pnlConnetionControls.Location = new System.Drawing.Point(6, 37);
            this.pnlConnetionControls.Name = "pnlConnetionControls";
            this.pnlConnetionControls.Size = new System.Drawing.Size(794, 221);
            this.pnlConnetionControls.TabIndex = 2;
            // 
            // btnCreateDatabAse
            // 
            this.btnCreateDatabAse.Location = new System.Drawing.Point(114, 34);
            this.btnCreateDatabAse.Name = "btnCreateDatabAse";
            this.btnCreateDatabAse.Size = new System.Drawing.Size(129, 38);
            this.btnCreateDatabAse.TabIndex = 4;
            this.btnCreateDatabAse.Text = "Delete String";
            this.btnCreateDatabAse.UseVisualStyleBackColor = true;
            this.btnCreateDatabAse.Click += new System.EventHandler(this.btnCreateDatabAse_Click);
            // 
            // txtConString
            // 
            this.txtConString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConString.Location = new System.Drawing.Point(6, 83);
            this.txtConString.Multiline = true;
            this.txtConString.Name = "txtConString";
            this.txtConString.Size = new System.Drawing.Size(725, 135);
            this.txtConString.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ConString";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection string";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(800, 450);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 5;
            this.picBackground.TabStop = false;
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(487, 34);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(139, 38);
            this.btnTestData.TabIndex = 5;
            this.btnTestData.Text = "Add Test Data";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlConnetionControls);
            this.Controls.Add(this.picBackground);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlConnetionControls.ResumeLayout(false);
            this.pnlConnetionControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConString;
        private System.Windows.Forms.Panel pnlConnetionControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.TextBox txtConString;
        private System.Windows.Forms.Button btnCreateDatabAse;
        private System.Windows.Forms.Button btnTestData;
    }
}