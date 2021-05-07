namespace AbitazioniQuartieri
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
            this.lbxQuartiere1 = new System.Windows.Forms.ListBox();
            this.lbxQuartiere2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAggiungi1 = new System.Windows.Forms.Button();
            this.btnAggiungi2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbLusso = new System.Windows.Forms.RadioButton();
            this.rdbPopolare = new System.Windows.Forms.RadioButton();
            this.txtAbitazioniDiLusso = new System.Windows.Forms.TextBox();
            this.btnCalcolaAbitazioniDiLusso = new System.Windows.Forms.Button();
            this.btnCalcolaImposte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImposte1 = new System.Windows.Forms.TextBox();
            this.txtImposte2 = new System.Windows.Forms.TextBox();
            this.pnlQuartieri = new System.Windows.Forms.Panel();
            this.pnlQuartieri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(4, 3);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(129, 23);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea i due quartieri";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // lbxQuartiere1
            // 
            this.lbxQuartiere1.FormattingEnabled = true;
            this.lbxQuartiere1.Location = new System.Drawing.Point(195, 18);
            this.lbxQuartiere1.Name = "lbxQuartiere1";
            this.lbxQuartiere1.Size = new System.Drawing.Size(293, 355);
            this.lbxQuartiere1.TabIndex = 1;
            // 
            // lbxQuartiere2
            // 
            this.lbxQuartiere2.FormattingEnabled = true;
            this.lbxQuartiere2.Location = new System.Drawing.Point(494, 17);
            this.lbxQuartiere2.Name = "lbxQuartiere2";
            this.lbxQuartiere2.Size = new System.Drawing.Size(293, 355);
            this.lbxQuartiere2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quartiere1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quartiere2";
            // 
            // btnAggiungi1
            // 
            this.btnAggiungi1.Location = new System.Drawing.Point(195, 379);
            this.btnAggiungi1.Name = "btnAggiungi1";
            this.btnAggiungi1.Size = new System.Drawing.Size(293, 44);
            this.btnAggiungi1.TabIndex = 5;
            this.btnAggiungi1.Text = "Aggiungi un\'abitazione al primo quartiere";
            this.btnAggiungi1.UseVisualStyleBackColor = true;
            this.btnAggiungi1.Click += new System.EventHandler(this.btnAggiungi1_Click);
            // 
            // btnAggiungi2
            // 
            this.btnAggiungi2.Location = new System.Drawing.Point(494, 378);
            this.btnAggiungi2.Name = "btnAggiungi2";
            this.btnAggiungi2.Size = new System.Drawing.Size(293, 44);
            this.btnAggiungi2.TabIndex = 6;
            this.btnAggiungi2.Text = "Aggiungi un\'abitazione al secondo quartiere";
            this.btnAggiungi2.UseVisualStyleBackColor = true;
            this.btnAggiungi2.Click += new System.EventHandler(this.btnAggiungi2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo abitazione";
            // 
            // rdbLusso
            // 
            this.rdbLusso.AutoSize = true;
            this.rdbLusso.Checked = true;
            this.rdbLusso.Location = new System.Drawing.Point(13, 66);
            this.rdbLusso.Name = "rdbLusso";
            this.rdbLusso.Size = new System.Drawing.Size(112, 17);
            this.rdbLusso.TabIndex = 8;
            this.rdbLusso.TabStop = true;
            this.rdbLusso.Text = "Abitazione di lusso";
            this.rdbLusso.UseVisualStyleBackColor = true;
            this.rdbLusso.CheckedChanged += new System.EventHandler(this.rdbLusso_CheckedChanged);
            // 
            // rdbPopolare
            // 
            this.rdbPopolare.AutoSize = true;
            this.rdbPopolare.Location = new System.Drawing.Point(13, 89);
            this.rdbPopolare.Name = "rdbPopolare";
            this.rdbPopolare.Size = new System.Drawing.Size(118, 17);
            this.rdbPopolare.TabIndex = 9;
            this.rdbPopolare.Text = "Abitazione popolare";
            this.rdbPopolare.UseVisualStyleBackColor = true;
            this.rdbPopolare.CheckedChanged += new System.EventHandler(this.rdbLusso_CheckedChanged);
            // 
            // txtAbitazioniDiLusso
            // 
            this.txtAbitazioniDiLusso.Location = new System.Drawing.Point(10, 196);
            this.txtAbitazioniDiLusso.Name = "txtAbitazioniDiLusso";
            this.txtAbitazioniDiLusso.ReadOnly = true;
            this.txtAbitazioniDiLusso.Size = new System.Drawing.Size(129, 20);
            this.txtAbitazioniDiLusso.TabIndex = 10;
            // 
            // btnCalcolaAbitazioniDiLusso
            // 
            this.btnCalcolaAbitazioniDiLusso.Location = new System.Drawing.Point(10, 142);
            this.btnCalcolaAbitazioniDiLusso.Name = "btnCalcolaAbitazioniDiLusso";
            this.btnCalcolaAbitazioniDiLusso.Size = new System.Drawing.Size(129, 48);
            this.btnCalcolaAbitazioniDiLusso.TabIndex = 11;
            this.btnCalcolaAbitazioniDiLusso.Text = "Calcola in quale quartiere ci sono piu abitazioni di lusso";
            this.btnCalcolaAbitazioniDiLusso.UseVisualStyleBackColor = true;
            this.btnCalcolaAbitazioniDiLusso.Click += new System.EventHandler(this.btnCalcolaAbitazioniDiLusso_Click);
            // 
            // btnCalcolaImposte
            // 
            this.btnCalcolaImposte.Location = new System.Drawing.Point(10, 250);
            this.btnCalcolaImposte.Name = "btnCalcolaImposte";
            this.btnCalcolaImposte.Size = new System.Drawing.Size(129, 48);
            this.btnCalcolaImposte.TabIndex = 12;
            this.btnCalcolaImposte.Text = "Calcola le imposte dei due quartieri";
            this.btnCalcolaImposte.UseVisualStyleBackColor = true;
            this.btnCalcolaImposte.Click += new System.EventHandler(this.btnCalcolaImposte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quartiere1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quartiere2:";
            // 
            // txtImposte1
            // 
            this.txtImposte1.Location = new System.Drawing.Point(75, 313);
            this.txtImposte1.Name = "txtImposte1";
            this.txtImposte1.ReadOnly = true;
            this.txtImposte1.Size = new System.Drawing.Size(73, 20);
            this.txtImposte1.TabIndex = 15;
            // 
            // txtImposte2
            // 
            this.txtImposte2.Location = new System.Drawing.Point(75, 338);
            this.txtImposte2.Name = "txtImposte2";
            this.txtImposte2.ReadOnly = true;
            this.txtImposte2.Size = new System.Drawing.Size(73, 20);
            this.txtImposte2.TabIndex = 16;
            // 
            // pnlQuartieri
            // 
            this.pnlQuartieri.Controls.Add(this.label1);
            this.pnlQuartieri.Controls.Add(this.txtImposte2);
            this.pnlQuartieri.Controls.Add(this.lbxQuartiere1);
            this.pnlQuartieri.Controls.Add(this.txtImposte1);
            this.pnlQuartieri.Controls.Add(this.lbxQuartiere2);
            this.pnlQuartieri.Controls.Add(this.label5);
            this.pnlQuartieri.Controls.Add(this.label2);
            this.pnlQuartieri.Controls.Add(this.label4);
            this.pnlQuartieri.Controls.Add(this.btnAggiungi1);
            this.pnlQuartieri.Controls.Add(this.btnCalcolaImposte);
            this.pnlQuartieri.Controls.Add(this.btnAggiungi2);
            this.pnlQuartieri.Controls.Add(this.btnCalcolaAbitazioniDiLusso);
            this.pnlQuartieri.Controls.Add(this.label3);
            this.pnlQuartieri.Controls.Add(this.txtAbitazioniDiLusso);
            this.pnlQuartieri.Controls.Add(this.rdbLusso);
            this.pnlQuartieri.Controls.Add(this.rdbPopolare);
            this.pnlQuartieri.Location = new System.Drawing.Point(4, 30);
            this.pnlQuartieri.Name = "pnlQuartieri";
            this.pnlQuartieri.Size = new System.Drawing.Size(794, 428);
            this.pnlQuartieri.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 464);
            this.Controls.Add(this.pnlQuartieri);
            this.Controls.Add(this.btnCrea);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlQuartieri.ResumeLayout(false);
            this.pnlQuartieri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.ListBox lbxQuartiere1;
        private System.Windows.Forms.ListBox lbxQuartiere2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAggiungi1;
        private System.Windows.Forms.Button btnAggiungi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbLusso;
        private System.Windows.Forms.RadioButton rdbPopolare;
        private System.Windows.Forms.TextBox txtAbitazioniDiLusso;
        private System.Windows.Forms.Button btnCalcolaAbitazioniDiLusso;
        private System.Windows.Forms.Button btnCalcolaImposte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImposte1;
        private System.Windows.Forms.TextBox txtImposte2;
        private System.Windows.Forms.Panel pnlQuartieri;
    }
}

