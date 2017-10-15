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
            this.label1 = new System.Windows.Forms.Label();
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
            this.BacIm.Image = global::MihirHundreds.Properties.Resources.maxresdefault;
            this.BacIm.Location = new System.Drawing.Point(0, 0);
            this.BacIm.Name = "BacIm";
            this.BacIm.Size = new System.Drawing.Size(724, 501);
            this.BacIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BacIm.TabIndex = 0;
            this.BacIm.TabStop = false;
            this.BacIm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BacIm_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pericles", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MihirHundreds.Properties.Resources.html_color_codes_color_tutorials_hero_00e10b1f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BacIm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BacIm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoTi;
        private System.Windows.Forms.PictureBox BacIm;
        private System.Windows.Forms.Label label1;
    }
}

