namespace Unix
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCommento = new System.Windows.Forms.TextBox();
            this.txtHomeD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShell = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeG = new System.Windows.Forms.TextBox();
            this.txtPasswordG = new System.Windows.Forms.TextBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnCreaG = new System.Windows.Forms.Button();
            this.lbxUser = new System.Windows.Forms.ListBox();
            this.lbxGroup = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPasswordP = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnInfoG = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnCambia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "User";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(143, 22);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtCommento
            // 
            this.txtCommento.Location = new System.Drawing.Point(119, 109);
            this.txtCommento.Multiline = true;
            this.txtCommento.Name = "txtCommento";
            this.txtCommento.Size = new System.Drawing.Size(143, 61);
            this.txtCommento.TabIndex = 5;
            // 
            // txtHomeD
            // 
            this.txtHomeD.Location = new System.Drawing.Point(119, 176);
            this.txtHomeD.Name = "txtHomeD";
            this.txtHomeD.Size = new System.Drawing.Size(143, 22);
            this.txtHomeD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Commento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Home directory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shell";
            // 
            // txtShell
            // 
            this.txtShell.Location = new System.Drawing.Point(119, 204);
            this.txtShell.Name = "txtShell";
            this.txtShell.Size = new System.Drawing.Size(143, 22);
            this.txtShell.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 374);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Group";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Groupname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // txtNomeG
            // 
            this.txtNomeG.Location = new System.Drawing.Point(119, 417);
            this.txtNomeG.Name = "txtNomeG";
            this.txtNomeG.Size = new System.Drawing.Size(143, 22);
            this.txtNomeG.TabIndex = 14;
            // 
            // txtPasswordG
            // 
            this.txtPasswordG.Location = new System.Drawing.Point(119, 445);
            this.txtPasswordG.Name = "txtPasswordG";
            this.txtPasswordG.PasswordChar = '*';
            this.txtPasswordG.Size = new System.Drawing.Size(143, 22);
            this.txtPasswordG.TabIndex = 15;
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(16, 285);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(246, 46);
            this.btnCrea.TabIndex = 16;
            this.btnCrea.Text = "Crea user";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnCreaG
            // 
            this.btnCreaG.Location = new System.Drawing.Point(16, 473);
            this.btnCreaG.Name = "btnCreaG";
            this.btnCreaG.Size = new System.Drawing.Size(246, 46);
            this.btnCreaG.TabIndex = 17;
            this.btnCreaG.Text = "Crea gruppo";
            this.btnCreaG.UseVisualStyleBackColor = true;
            this.btnCreaG.Click += new System.EventHandler(this.btnCreaG_Click);
            // 
            // lbxUser
            // 
            this.lbxUser.FormattingEnabled = true;
            this.lbxUser.ItemHeight = 16;
            this.lbxUser.Location = new System.Drawing.Point(302, 53);
            this.lbxUser.Name = "lbxUser";
            this.lbxUser.Size = new System.Drawing.Size(350, 468);
            this.lbxUser.TabIndex = 18;
            this.lbxUser.Click += new System.EventHandler(this.lbxUser_Click);
            this.lbxUser.SelectedIndexChanged += new System.EventHandler(this.lbxUser_SelectedIndexChanged);
            // 
            // lbxGroup
            // 
            this.lbxGroup.FormattingEnabled = true;
            this.lbxGroup.ItemHeight = 16;
            this.lbxGroup.Location = new System.Drawing.Point(658, 53);
            this.lbxGroup.Name = "lbxGroup";
            this.lbxGroup.Size = new System.Drawing.Size(350, 468);
            this.lbxGroup.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Lista utenti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(655, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Lista gruppi utente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Password per gruppo primario";
            // 
            // txtPasswordP
            // 
            this.txtPasswordP.Location = new System.Drawing.Point(16, 257);
            this.txtPasswordP.Name = "txtPasswordP";
            this.txtPasswordP.PasswordChar = '*';
            this.txtPasswordP.Size = new System.Drawing.Size(186, 22);
            this.txtPasswordP.TabIndex = 23;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(302, 527);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 56);
            this.btnInfo.TabIndex = 24;
            this.btnInfo.Text = "Informazioni";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnInfoG
            // 
            this.btnInfoG.Location = new System.Drawing.Point(747, 527);
            this.btnInfoG.Name = "btnInfoG";
            this.btnInfoG.Size = new System.Drawing.Size(149, 56);
            this.btnInfoG.TabIndex = 25;
            this.btnInfoG.Text = "Informazioni";
            this.btnInfoG.UseVisualStyleBackColor = true;
            this.btnInfoG.Click += new System.EventHandler(this.btnInfoG_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(552, 527);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 56);
            this.btnAggiungi.TabIndex = 27;
            this.btnAggiungi.Text = "Aggiungi un gruppo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(377, 13);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(187, 22);
            this.txtUser.TabIndex = 28;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCambia
            // 
            this.btnCambia.Location = new System.Drawing.Point(425, 527);
            this.btnCambia.Name = "btnCambia";
            this.btnCambia.Size = new System.Drawing.Size(100, 56);
            this.btnCambia.TabIndex = 29;
            this.btnCambia.Text = "Cambia password";
            this.btnCambia.UseVisualStyleBackColor = true;
            this.btnCambia.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 614);
            this.Controls.Add(this.btnCambia);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnInfoG);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtPasswordP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbxGroup);
            this.Controls.Add(this.lbxUser);
            this.Controls.Add(this.btnCreaG);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.txtPasswordG);
            this.Controls.Add(this.txtNomeG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtShell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHomeD);
            this.Controls.Add(this.txtCommento);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCommento;
        private System.Windows.Forms.TextBox txtHomeD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShell;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeG;
        private System.Windows.Forms.TextBox txtPasswordG;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnCreaG;
        private System.Windows.Forms.ListBox lbxUser;
        private System.Windows.Forms.ListBox lbxGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPasswordP;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnInfoG;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnCambia;
    }
}

