namespace Videoteca
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtVecchia = new System.Windows.Forms.TextBox();
            this.txtNuova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuovaVideoteca = new System.Windows.Forms.Button();
            this.lbxVideoteca = new System.Windows.Forms.ListBox();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.btnNumeroFilm = new System.Windows.Forms.Button();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.btnVisualizzaPass = new System.Windows.Forms.Button();
            this.btnModificaPass = new System.Windows.Forms.Button();
            this.pnlVideoteca = new System.Windows.Forms.Panel();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumeroFilm = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.pnlRicerca = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslNumeroClienti = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConferma = new System.Windows.Forms.TextBox();
            this.pnlVideoteca.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFilm)).BeginInit();
            this.pnlRicerca.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crea nuovo cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVecchia
            // 
            this.txtVecchia.Location = new System.Drawing.Point(73, 54);
            this.txtVecchia.Name = "txtVecchia";
            this.txtVecchia.Size = new System.Drawing.Size(100, 20);
            this.txtVecchia.TabIndex = 3;
            // 
            // txtNuova
            // 
            this.txtNuova.Location = new System.Drawing.Point(73, 91);
            this.txtNuova.Name = "txtNuova";
            this.txtNuova.Size = new System.Drawing.Size(100, 20);
            this.txtNuova.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vecchia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nuova";
            // 
            // btnNuovaVideoteca
            // 
            this.btnNuovaVideoteca.Location = new System.Drawing.Point(21, 12);
            this.btnNuovaVideoteca.Name = "btnNuovaVideoteca";
            this.btnNuovaVideoteca.Size = new System.Drawing.Size(106, 44);
            this.btnNuovaVideoteca.TabIndex = 10;
            this.btnNuovaVideoteca.Text = "Crea nuova videoteca";
            this.btnNuovaVideoteca.UseVisualStyleBackColor = true;
            this.btnNuovaVideoteca.Click += new System.EventHandler(this.btnNuovaVideoteca_Click);
            // 
            // lbxVideoteca
            // 
            this.lbxVideoteca.FormattingEnabled = true;
            this.lbxVideoteca.Location = new System.Drawing.Point(8, 69);
            this.lbxVideoteca.Name = "lbxVideoteca";
            this.lbxVideoteca.Size = new System.Drawing.Size(540, 316);
            this.lbxVideoteca.TabIndex = 11;
            this.lbxVideoteca.SelectedIndexChanged += new System.EventHandler(this.lbxVideoteca_SelectedIndexChanged);
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(123, 9);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(106, 44);
            this.btnOrdina.TabIndex = 12;
            this.btnOrdina.Text = "Ordina la lista";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // btnNumeroFilm
            // 
            this.btnNumeroFilm.Location = new System.Drawing.Point(235, 9);
            this.btnNumeroFilm.Name = "btnNumeroFilm";
            this.btnNumeroFilm.Size = new System.Drawing.Size(106, 44);
            this.btnNumeroFilm.TabIndex = 13;
            this.btnNumeroFilm.Text = "Ricerca per numero film";
            this.btnNumeroFilm.UseVisualStyleBackColor = true;
            this.btnNumeroFilm.Click += new System.EventHandler(this.btnNumeroFilm_Click);
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.Location = new System.Drawing.Point(0, 9);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(106, 44);
            this.btnRimuovi.TabIndex = 14;
            this.btnRimuovi.Text = "Rimuovi cliente";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // btnVisualizzaPass
            // 
            this.btnVisualizzaPass.Location = new System.Drawing.Point(112, 9);
            this.btnVisualizzaPass.Name = "btnVisualizzaPass";
            this.btnVisualizzaPass.Size = new System.Drawing.Size(106, 44);
            this.btnVisualizzaPass.TabIndex = 15;
            this.btnVisualizzaPass.Text = "Visualizza password";
            this.btnVisualizzaPass.UseVisualStyleBackColor = true;
            this.btnVisualizzaPass.Click += new System.EventHandler(this.btnVisualizzaPass_Click);
            // 
            // btnModificaPass
            // 
            this.btnModificaPass.Location = new System.Drawing.Point(224, 9);
            this.btnModificaPass.Name = "btnModificaPass";
            this.btnModificaPass.Size = new System.Drawing.Size(106, 44);
            this.btnModificaPass.TabIndex = 16;
            this.btnModificaPass.Text = "Modifica password";
            this.btnModificaPass.UseVisualStyleBackColor = true;
            this.btnModificaPass.Click += new System.EventHandler(this.btnModificaPass_Click);
            // 
            // pnlVideoteca
            // 
            this.pnlVideoteca.Controls.Add(this.btnOrdina);
            this.pnlVideoteca.Controls.Add(this.button1);
            this.pnlVideoteca.Controls.Add(this.btnNumeroFilm);
            this.pnlVideoteca.Location = new System.Drawing.Point(158, 3);
            this.pnlVideoteca.Name = "pnlVideoteca";
            this.pnlVideoteca.Size = new System.Drawing.Size(350, 60);
            this.pnlVideoteca.TabIndex = 17;
            this.pnlVideoteca.Visible = false;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btnModificaPass);
            this.pnlCliente.Controls.Add(this.btnVisualizzaPass);
            this.pnlCliente.Controls.Add(this.btnRimuovi);
            this.pnlCliente.Location = new System.Drawing.Point(536, 3);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(337, 60);
            this.pnlCliente.TabIndex = 18;
            this.pnlCliente.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Modifica password";
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.txtConferma);
            this.pnlPassword.Controls.Add(this.label6);
            this.pnlPassword.Controls.Add(this.btnModifica);
            this.pnlPassword.Controls.Add(this.label3);
            this.pnlPassword.Controls.Add(this.label2);
            this.pnlPassword.Controls.Add(this.label1);
            this.pnlPassword.Controls.Add(this.txtNuova);
            this.pnlPassword.Controls.Add(this.txtVecchia);
            this.pnlPassword.Location = new System.Drawing.Point(555, 95);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(270, 171);
            this.pnlPassword.TabIndex = 20;
            this.pnlPassword.Visible = false;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(181, 117);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(65, 27);
            this.btnModifica.TabIndex = 20;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ricerca per numero film";
            // 
            // nudNumeroFilm
            // 
            this.nudNumeroFilm.Location = new System.Drawing.Point(87, 49);
            this.nudNumeroFilm.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudNumeroFilm.Name = "nudNumeroFilm";
            this.nudNumeroFilm.Size = new System.Drawing.Size(69, 20);
            this.nudNumeroFilm.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Numero film";
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(181, 49);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(63, 20);
            this.btnRicerca.TabIndex = 24;
            this.btnRicerca.Text = "Ricerca";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // pnlRicerca
            // 
            this.pnlRicerca.Controls.Add(this.btnRicerca);
            this.pnlRicerca.Controls.Add(this.label5);
            this.pnlRicerca.Controls.Add(this.nudNumeroFilm);
            this.pnlRicerca.Controls.Add(this.label4);
            this.pnlRicerca.Location = new System.Drawing.Point(555, 272);
            this.pnlRicerca.Name = "pnlRicerca";
            this.pnlRicerca.Size = new System.Drawing.Size(267, 82);
            this.pnlRicerca.TabIndex = 25;
            this.pnlRicerca.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslNumeroClienti});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslNumeroClienti
            // 
            this.tslNumeroClienti.Name = "tslNumeroClienti";
            this.tslNumeroClienti.Size = new System.Drawing.Size(98, 17);
            this.tslNumeroClienti.Text = "Numero clienti: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Conferma";
            // 
            // txtConferma
            // 
            this.txtConferma.Location = new System.Drawing.Point(73, 121);
            this.txtConferma.Name = "txtConferma";
            this.txtConferma.Size = new System.Drawing.Size(100, 20);
            this.txtConferma.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlRicerca);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlVideoteca);
            this.Controls.Add(this.lbxVideoteca);
            this.Controls.Add(this.btnNuovaVideoteca);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlVideoteca.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFilm)).EndInit();
            this.pnlRicerca.ResumeLayout(false);
            this.pnlRicerca.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVecchia;
        private System.Windows.Forms.TextBox txtNuova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuovaVideoteca;
        private System.Windows.Forms.ListBox lbxVideoteca;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.Button btnNumeroFilm;
        private System.Windows.Forms.Button btnRimuovi;
        private System.Windows.Forms.Button btnVisualizzaPass;
        private System.Windows.Forms.Button btnModificaPass;
        private System.Windows.Forms.Panel pnlVideoteca;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumeroFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Panel pnlRicerca;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslNumeroClienti;
        private System.Windows.Forms.TextBox txtConferma;
        private System.Windows.Forms.Label label6;
    }
}

