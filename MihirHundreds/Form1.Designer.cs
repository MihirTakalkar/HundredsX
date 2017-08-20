namespace MihirHundreds
{
    partial class Form1
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
            this.MoTi = new System.Windows.Forms.Timer(this.components);
            this.BacIm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BacIm)).BeginInit();
            this.SuspendLayout();
            // 
            // MoTi
            // 
            this.MoTi.Enabled = true;
            this.MoTi.Interval = 30;
            this.MoTi.Tick += new System.EventHandler(this.MoTi_Tick);
            // 
            // BacIm
            // 
            this.BacIm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BacIm.Location = new System.Drawing.Point(0, 0);
            this.BacIm.Name = "BacIm";
            this.BacIm.Size = new System.Drawing.Size(724, 501);
            this.BacIm.TabIndex = 0;
            this.BacIm.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.BacIm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BacIm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MoTi;
        private System.Windows.Forms.PictureBox BacIm;
    }
}

