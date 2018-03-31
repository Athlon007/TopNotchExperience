namespace DaNotch
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.notchLeft = new System.Windows.Forms.PictureBox();
            this.notchRight = new System.Windows.Forms.PictureBox();
            this.notchMiddle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.notchLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchRight)).BeginInit();
            this.SuspendLayout();
            // 
            // notchLeft
            // 
            this.notchLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notchLeft.Image = global::DaNotch.Properties.Resources.notch1;
            this.notchLeft.Location = new System.Drawing.Point(0, 0);
            this.notchLeft.Name = "notchLeft";
            this.notchLeft.Size = new System.Drawing.Size(81, 81);
            this.notchLeft.TabIndex = 0;
            this.notchLeft.TabStop = false;
            // 
            // notchRight
            // 
            this.notchRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notchRight.Image = global::DaNotch.Properties.Resources.notch1;
            this.notchRight.Location = new System.Drawing.Point(208, 0);
            this.notchRight.Name = "notchRight";
            this.notchRight.Size = new System.Drawing.Size(81, 81);
            this.notchRight.TabIndex = 1;
            this.notchRight.TabStop = false;
            // 
            // notchMiddle
            // 
            this.notchMiddle.BackColor = System.Drawing.Color.Black;
            this.notchMiddle.Location = new System.Drawing.Point(89, 0);
            this.notchMiddle.Name = "notchMiddle";
            this.notchMiddle.Size = new System.Drawing.Size(113, 81);
            this.notchMiddle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 120);
            this.Controls.Add(this.notchMiddle);
            this.Controls.Add(this.notchRight);
            this.Controls.Add(this.notchLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            ((System.ComponentModel.ISupportInitialize)(this.notchLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notchRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox notchLeft;
        private System.Windows.Forms.PictureBox notchRight;
        private System.Windows.Forms.Panel notchMiddle;
    }
}

