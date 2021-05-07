namespace Unix
{
    partial class FrmPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtVp = new System.Windows.Forms.TextBox();
            this.txtNp = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vecchia password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuova password";
            // 
            // txtVp
            // 
            this.txtVp.Location = new System.Drawing.Point(112, 36);
            this.txtVp.Name = "txtVp";
            this.txtVp.Size = new System.Drawing.Size(160, 20);
            this.txtVp.TabIndex = 2;
            // 
            // txtNp
            // 
            this.txtNp.Location = new System.Drawing.Point(112, 84);
            this.txtNp.Name = "txtNp";
            this.txtNp.Size = new System.Drawing.Size(160, 20);
            this.txtNp.TabIndex = 3;
            // 
            // btnInvia
            // 
            this.btnInvia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInvia.Location = new System.Drawing.Point(47, 143);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(178, 65);
            this.btnInvia.TabIndex = 4;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            // 
            // FrmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtNp);
            this.Controls.Add(this.txtVp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtVp;
        public System.Windows.Forms.TextBox txtNp;
        private System.Windows.Forms.Button btnInvia;
    }
}