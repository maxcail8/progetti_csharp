namespace ContoCorrenteBancario
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
            this.btnCrea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoA = new System.Windows.Forms.TextBox();
            this.btnVersamento = new System.Windows.Forms.Button();
            this.btnPrelievo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrelievo = new System.Windows.Forms.TextBox();
            this.txtVersamento = new System.Windows.Forms.TextBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.pnlM = new System.Windows.Forms.Panel();
            this.btnMovR = new System.Windows.Forms.Button();
            this.pnlM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(301, 18);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(101, 56);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea conto corrente";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci numero del conto";
            // 
            // txtNumC
            // 
            this.txtNumC.Location = new System.Drawing.Point(200, 12);
            this.txtNumC.Name = "txtNumC";
            this.txtNumC.Size = new System.Drawing.Size(71, 24);
            this.txtNumC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserisci il saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(200, 54);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(71, 24);
            this.txtSaldo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Il saldo attuale vale:";
            // 
            // txtSaldoA
            // 
            this.txtSaldoA.Location = new System.Drawing.Point(575, 34);
            this.txtSaldoA.Name = "txtSaldoA";
            this.txtSaldoA.ReadOnly = true;
            this.txtSaldoA.Size = new System.Drawing.Size(197, 24);
            this.txtSaldoA.TabIndex = 6;
            // 
            // btnVersamento
            // 
            this.btnVersamento.Location = new System.Drawing.Point(432, 92);
            this.btnVersamento.Name = "btnVersamento";
            this.btnVersamento.Size = new System.Drawing.Size(112, 56);
            this.btnVersamento.TabIndex = 7;
            this.btnVersamento.Text = "Esegui versamento";
            this.btnVersamento.UseVisualStyleBackColor = true;
            this.btnVersamento.Click += new System.EventHandler(this.btnVersamento_Click);
            // 
            // btnPrelievo
            // 
            this.btnPrelievo.Location = new System.Drawing.Point(432, 30);
            this.btnPrelievo.Name = "btnPrelievo";
            this.btnPrelievo.Size = new System.Drawing.Size(112, 56);
            this.btnPrelievo.TabIndex = 8;
            this.btnPrelievo.Text = "Esegui prelevamento";
            this.btnPrelievo.UseVisualStyleBackColor = true;
            this.btnPrelievo.Click += new System.EventHandler(this.btnPrelievo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inserisci il valore da prelevare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inserisci il valore da versare";
            // 
            // txtPrelievo
            // 
            this.txtPrelievo.Location = new System.Drawing.Point(213, 46);
            this.txtPrelievo.Name = "txtPrelievo";
            this.txtPrelievo.Size = new System.Drawing.Size(126, 24);
            this.txtPrelievo.TabIndex = 11;
            // 
            // txtVersamento
            // 
            this.txtVersamento.Location = new System.Drawing.Point(213, 108);
            this.txtVersamento.Name = "txtVersamento";
            this.txtVersamento.Size = new System.Drawing.Size(126, 24);
            this.txtVersamento.TabIndex = 12;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(7, 158);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(138, 56);
            this.btnLista.TabIndex = 13;
            this.btnLista.Text = "Mostra lista movimenti";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // pnlM
            // 
            this.pnlM.Controls.Add(this.btnMovR);
            this.pnlM.Controls.Add(this.btnLista);
            this.pnlM.Controls.Add(this.txtVersamento);
            this.pnlM.Controls.Add(this.txtPrelievo);
            this.pnlM.Controls.Add(this.label5);
            this.pnlM.Controls.Add(this.label4);
            this.pnlM.Controls.Add(this.btnVersamento);
            this.pnlM.Controls.Add(this.btnPrelievo);
            this.pnlM.Location = new System.Drawing.Point(5, 94);
            this.pnlM.Name = "pnlM";
            this.pnlM.Size = new System.Drawing.Size(564, 314);
            this.pnlM.TabIndex = 16;
            this.pnlM.Visible = false;
            // 
            // btnMovR
            // 
            this.btnMovR.Location = new System.Drawing.Point(7, 231);
            this.btnMovR.Name = "btnMovR";
            this.btnMovR.Size = new System.Drawing.Size(138, 56);
            this.btnMovR.TabIndex = 16;
            this.btnMovR.Text = "Movimento piu\' recente";
            this.btnMovR.UseVisualStyleBackColor = true;
            this.btnMovR.Click += new System.EventHandler(this.btnMovR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlM);
            this.Controls.Add(this.txtSaldoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlM.ResumeLayout(false);
            this.pnlM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldoA;
        private System.Windows.Forms.Button btnVersamento;
        private System.Windows.Forms.Button btnPrelievo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrelievo;
        private System.Windows.Forms.TextBox txtVersamento;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Panel pnlM;
        private System.Windows.Forms.Button btnMovR;
    }
}

