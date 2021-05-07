namespace AbitazioniQuartieri
{
    partial class FrmAbitazione
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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.nudVani = new System.Windows.Forms.NumericUpDown();
            this.txtMq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudVani)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAggiungi.Location = new System.Drawing.Point(101, 156);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indirizzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero vani";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mq";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(63, 28);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(209, 20);
            this.txtIndirizzo.TabIndex = 4;
            // 
            // nudVani
            // 
            this.nudVani.Location = new System.Drawing.Point(83, 64);
            this.nudVani.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudVani.Name = "nudVani";
            this.nudVani.Size = new System.Drawing.Size(62, 20);
            this.nudVani.TabIndex = 5;
            // 
            // txtMq
            // 
            this.txtMq.Location = new System.Drawing.Point(40, 99);
            this.txtMq.Name = "txtMq";
            this.txtMq.Size = new System.Drawing.Size(105, 20);
            this.txtMq.TabIndex = 6;
            // 
            // FrmAbitazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.txtMq);
            this.Controls.Add(this.nudVani);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggiungi);
            this.Name = "FrmAbitazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbitazione";
            this.Load += new System.EventHandler(this.FrmAbitazione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.NumericUpDown nudVani;
        private System.Windows.Forms.TextBox txtMq;
    }
}