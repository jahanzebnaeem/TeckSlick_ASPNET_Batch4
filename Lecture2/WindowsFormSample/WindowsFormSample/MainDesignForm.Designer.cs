namespace WindowsFormSample
{
    partial class MainDesignForm
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
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.Image = global::WindowsFormSample.Properties.Resources.self;
            this.pbMainLogo.Location = new System.Drawing.Point(0, 0);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(574, 50);
            this.pbMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainLogo.TabIndex = 0;
            this.pbMainLogo.TabStop = false;
            // 
            // MainDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 274);
            this.Controls.Add(this.pbMainLogo);
            this.Name = "MainDesignForm";
            this.Text = "Main Design Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainLogo;
    }
}