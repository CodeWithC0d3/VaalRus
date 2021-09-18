
namespace vaalrusGUIPrototype
{
    partial class frmAddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewCustomer));
            this.pictureBoxMainFormBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainFormBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainFormBackground
            // 
            this.pictureBoxMainFormBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainFormBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainFormBackground.Image")));
            this.pictureBoxMainFormBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMainFormBackground.Name = "pictureBoxMainFormBackground";
            this.pictureBoxMainFormBackground.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxMainFormBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainFormBackground.TabIndex = 1;
            this.pictureBoxMainFormBackground.TabStop = false;
            // 
            // frmAddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxMainFormBackground);
            this.Name = "frmAddNewCustomer";
            this.Text = "Add a new customer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainFormBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainFormBackground;
    }
}