
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
            this.txtConString = new System.Windows.Forms.TextBox();
            this.btnTestData = new System.Windows.Forms.Button();
            this.btnCreateDatabAse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlConnetionControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConString
            // 
            this.btnConString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConString.Location = new System.Drawing.Point(407, 66);
            this.btnConString.Name = "btnConString";
            this.btnConString.Size = new System.Drawing.Size(301, 56);
            this.btnConString.TabIndex = 1;
            this.btnConString.Text = "Setup";
            this.btnConString.UseVisualStyleBackColor = true;
            this.btnConString.Click += new System.EventHandler(this.btnConString_Click);
            // 
            // pnlConnetionControls
            // 
            this.pnlConnetionControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConnetionControls.Controls.Add(this.txtConString);
            this.pnlConnetionControls.Controls.Add(this.btnConString);
            this.pnlConnetionControls.Controls.Add(this.btnTestData);
            this.pnlConnetionControls.Controls.Add(this.btnCreateDatabAse);
            this.pnlConnetionControls.Location = new System.Drawing.Point(0, 56);
            this.pnlConnetionControls.Name = "pnlConnetionControls";
            this.pnlConnetionControls.Size = new System.Drawing.Size(1099, 423);
            this.pnlConnetionControls.TabIndex = 2;
            // 
            // txtConString
            // 
            this.txtConString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConString.Location = new System.Drawing.Point(113, 4);
            this.txtConString.Multiline = true;
            this.txtConString.Name = "txtConString";
            this.txtConString.Size = new System.Drawing.Size(909, 56);
            this.txtConString.TabIndex = 3;
            // 
            // btnTestData
            // 
            this.btnTestData.Location = new System.Drawing.Point(3, 4);
            this.btnTestData.Name = "btnTestData";
            this.btnTestData.Size = new System.Drawing.Size(104, 38);
            this.btnTestData.TabIndex = 5;
            this.btnTestData.Text = "Add Test Data";
            this.btnTestData.UseVisualStyleBackColor = true;
            this.btnTestData.Click += new System.EventHandler(this.btnTestData_Click);
            // 
            // btnCreateDatabAse
            // 
            this.btnCreateDatabAse.Location = new System.Drawing.Point(3, 51);
            this.btnCreateDatabAse.Name = "btnCreateDatabAse";
            this.btnCreateDatabAse.Size = new System.Drawing.Size(104, 38);
            this.btnCreateDatabAse.TabIndex = 4;
            this.btnCreateDatabAse.Text = "Delete String";
            this.btnCreateDatabAse.UseVisualStyleBackColor = true;
            this.btnCreateDatabAse.Click += new System.EventHandler(this.btnCreateDatabAse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database Setup";
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
            this.picBackground.Size = new System.Drawing.Size(1099, 584);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 5;
            this.picBackground.TabStop = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.TextBox txtConString;
        private System.Windows.Forms.Button btnCreateDatabAse;
        private System.Windows.Forms.Button btnTestData;
    }
}