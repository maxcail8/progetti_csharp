namespace TryToCatchMe
{
    partial class formPrendimi
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrendimi = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrendimi
            // 
            this.btnPrendimi.Location = new System.Drawing.Point(207, 168);
            this.btnPrendimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrendimi.Name = "btnPrendimi";
            this.btnPrendimi.Size = new System.Drawing.Size(136, 67);
            this.btnPrendimi.TabIndex = 0;
            this.btnPrendimi.TabStop = false;
            this.btnPrendimi.Text = "Prendimi";
            this.btnPrendimi.UseVisualStyleBackColor = true;
            this.btnPrendimi.Click += new System.EventHandler(this.btnPrendimi_Click);
            this.btnPrendimi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPrendimi_MouseMove);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(7, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 20);
            this.lbl.TabIndex = 1;
            // 
            // formPrendimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnPrendimi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(140, 100);
            this.Name = "formPrendimi";
            this.Text = "Finestra";
            this.Load += new System.EventHandler(this.formPrendimi_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formPrendimi_MouseMove);
            this.Resize += new System.EventHandler(this.formPrendimi_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrendimi;
        private System.Windows.Forms.Label lbl;
    }
}

