namespace Videoteca
{
    partial class frmCliente
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
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudFilm = new System.Windows.Forms.NumericUpDown();
            this.btnClient = new System.Windows.Forms.Button();
            this.dtpNascita = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(86, 29);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(147, 20);
            this.txtCognome.TabIndex = 1;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Num film";
            // 
            // nudFilm
            // 
            this.nudFilm.Location = new System.Drawing.Point(86, 164);
            this.nudFilm.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudFilm.Name = "nudFilm";
            this.nudFilm.Size = new System.Drawing.Size(75, 20);
            this.nudFilm.TabIndex = 7;
            // 
            // btnClient
            // 
            this.btnClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClient.Enabled = false;
            this.btnClient.Location = new System.Drawing.Point(208, 175);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(94, 42);
            this.btnClient.TabIndex = 9;
            this.btnClient.Text = "Crea cliente";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // dtpNascita
            // 
            this.dtpNascita.Location = new System.Drawing.Point(86, 114);
            this.dtpNascita.Name = "dtpNascita";
            this.dtpNascita.Size = new System.Drawing.Size(184, 20);
            this.dtpNascita.TabIndex = 10;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 267);
            this.Controls.Add(this.dtpNascita);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.nudFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudFilm;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.DateTimePicker dtpNascita;
    }
}