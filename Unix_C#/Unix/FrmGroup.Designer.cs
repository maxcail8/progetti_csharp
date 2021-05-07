namespace Unix
{
    partial class FrmGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxGruppi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordGruppo = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleziona gruppo";
            // 
            // lbxGruppi
            // 
            this.lbxGruppi.FormattingEnabled = true;
            this.lbxGruppi.ItemHeight = 16;
            this.lbxGruppi.Location = new System.Drawing.Point(138, 11);
            this.lbxGruppi.Margin = new System.Windows.Forms.Padding(4);
            this.lbxGruppi.Name = "lbxGruppi";
            this.lbxGruppi.Size = new System.Drawing.Size(303, 388);
            this.lbxGruppi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserisci password";
            // 
            // txtPasswordGruppo
            // 
            this.txtPasswordGruppo.Location = new System.Drawing.Point(138, 430);
            this.txtPasswordGruppo.Name = "txtPasswordGruppo";
            this.txtPasswordGruppo.PasswordChar = '*';
            this.txtPasswordGruppo.Size = new System.Drawing.Size(303, 22);
            this.txtPasswordGruppo.TabIndex = 3;
            // 
            // btnInvia
            // 
            this.btnInvia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInvia.Location = new System.Drawing.Point(465, 422);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(97, 38);
            this.btnInvia.TabIndex = 4;
            this.btnInvia.Text = "Invia dati";
            this.btnInvia.UseVisualStyleBackColor = true;
            // 
            // FrmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 486);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtPasswordGruppo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxGruppi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtPasswordGruppo;
        public System.Windows.Forms.ListBox lbxGruppi;
    }
}