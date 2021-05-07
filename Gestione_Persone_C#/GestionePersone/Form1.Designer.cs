namespace GestionePersone
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnCreaPersona = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroPersone = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCreaStudente = new System.Windows.Forms.Button();
            this.lbxPersone = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreaPersona
            // 
            this.btnCreaPersona.Location = new System.Drawing.Point(12, 12);
            this.btnCreaPersona.Name = "btnCreaPersona";
            this.btnCreaPersona.Size = new System.Drawing.Size(115, 54);
            this.btnCreaPersona.TabIndex = 0;
            this.btnCreaPersona.Text = "Crea persona";
            this.btnCreaPersona.UseVisualStyleBackColor = true;
            this.btnCreaPersona.Click += new System.EventHandler(this.btnCreaPersona_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroPersone});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(414, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroPersone
            // 
            this.lblNumeroPersone.Name = "lblNumeroPersone";
            this.lblNumeroPersone.Size = new System.Drawing.Size(99, 17);
            this.lblNumeroPersone.Text = "Numero persone:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCreaStudente
            // 
            this.btnCreaStudente.Location = new System.Drawing.Point(133, 12);
            this.btnCreaStudente.Name = "btnCreaStudente";
            this.btnCreaStudente.Size = new System.Drawing.Size(115, 54);
            this.btnCreaStudente.TabIndex = 2;
            this.btnCreaStudente.Text = "Crea studente";
            this.btnCreaStudente.UseVisualStyleBackColor = true;
            // 
            // lbxPersone
            // 
            this.lbxPersone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxPersone.FormattingEnabled = true;
            this.lbxPersone.Location = new System.Drawing.Point(12, 72);
            this.lbxPersone.Name = "lbxPersone";
            this.lbxPersone.Size = new System.Drawing.Size(390, 264);
            this.lbxPersone.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 379);
            this.Controls.Add(this.lbxPersone);
            this.Controls.Add(this.btnCreaStudente);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCreaPersona);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione persone e studentti";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaPersona;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroPersone;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCreaStudente;
        private System.Windows.Forms.ListBox lbxPersone;
    }
}

