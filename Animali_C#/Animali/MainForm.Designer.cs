namespace OOP
{
    partial class MainForm
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
            this.btnVerso = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnControlloTipo = new System.Windows.Forms.Button();
            this.btnToString = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetRazza = new System.Windows.Forms.Button();
            this.btnCreaCane = new System.Windows.Forms.Button();
            this.rbCaneDaGuardiaPiccolo = new System.Windows.Forms.RadioButton();
            this.rbCanePastore = new System.Windows.Forms.RadioButton();
            this.rbCaneDaGuardia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCane = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVersoAnimali = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreaAnimale = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoAnimale = new System.Windows.Forms.ComboBox();
            this.lbxAnimali = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerso
            // 
            this.btnVerso.Location = new System.Drawing.Point(67, 233);
            this.btnVerso.Name = "btnVerso";
            this.btnVerso.Size = new System.Drawing.Size(89, 23);
            this.btnVerso.TabIndex = 0;
            this.btnVerso.Text = "Verso()";
            this.btnVerso.UseVisualStyleBackColor = true;
            this.btnVerso.Click += new System.EventHandler(this.btnVerso_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 306);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnControlloTipo);
            this.tabPage1.Controls.Add(this.btnToString);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnGetRazza);
            this.tabPage1.Controls.Add(this.btnCreaCane);
            this.tabPage1.Controls.Add(this.rbCaneDaGuardiaPiccolo);
            this.tabPage1.Controls.Add(this.rbCanePastore);
            this.tabPage1.Controls.Add(this.rbCaneDaGuardia);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbCane);
            this.tabPage1.Controls.Add(this.btnVerso);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Polimorfismo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnControlloTipo
            // 
            this.btnControlloTipo.Location = new System.Drawing.Point(162, 178);
            this.btnControlloTipo.Name = "btnControlloTipo";
            this.btnControlloTipo.Size = new System.Drawing.Size(89, 23);
            this.btnControlloTipo.TabIndex = 11;
            this.btnControlloTipo.Text = "Controllo tipo";
            this.btnControlloTipo.UseVisualStyleBackColor = true;
            this.btnControlloTipo.Click += new System.EventHandler(this.btnControlloTipo_Click);
            // 
            // btnToString
            // 
            this.btnToString.Location = new System.Drawing.Point(162, 233);
            this.btnToString.Name = "btnToString";
            this.btnToString.Size = new System.Drawing.Size(89, 23);
            this.btnToString.TabIndex = 10;
            this.btnToString.Text = "ToString()";
            this.btnToString.UseVisualStyleBackColor = true;
            this.btnToString.Click += new System.EventHandler(this.btnToString_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(14, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DYNAMIC BINDING (Collegamento dinamico)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(14, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "STATIC BINDING (Collegamento statico)";
            // 
            // btnGetRazza
            // 
            this.btnGetRazza.Location = new System.Drawing.Point(67, 178);
            this.btnGetRazza.Name = "btnGetRazza";
            this.btnGetRazza.Size = new System.Drawing.Size(89, 23);
            this.btnGetRazza.TabIndex = 7;
            this.btnGetRazza.Text = "GetRazza()";
            this.btnGetRazza.UseVisualStyleBackColor = true;
            this.btnGetRazza.Click += new System.EventHandler(this.btnGetRazza_Click);
            // 
            // btnCreaCane
            // 
            this.btnCreaCane.Location = new System.Drawing.Point(67, 107);
            this.btnCreaCane.Name = "btnCreaCane";
            this.btnCreaCane.Size = new System.Drawing.Size(184, 23);
            this.btnCreaCane.TabIndex = 6;
            this.btnCreaCane.Text = "Crea Cane";
            this.btnCreaCane.UseVisualStyleBackColor = true;
            this.btnCreaCane.Click += new System.EventHandler(this.btnCreaCane_Click);
            // 
            // rbCaneDaGuardiaPiccolo
            // 
            this.rbCaneDaGuardiaPiccolo.AutoSize = true;
            this.rbCaneDaGuardiaPiccolo.Location = new System.Drawing.Point(175, 84);
            this.rbCaneDaGuardiaPiccolo.Name = "rbCaneDaGuardiaPiccolo";
            this.rbCaneDaGuardiaPiccolo.Size = new System.Drawing.Size(139, 17);
            this.rbCaneDaGuardiaPiccolo.TabIndex = 5;
            this.rbCaneDaGuardiaPiccolo.Text = "cane da guardia piccolo";
            this.rbCaneDaGuardiaPiccolo.UseVisualStyleBackColor = true;
            // 
            // rbCanePastore
            // 
            this.rbCanePastore.AutoSize = true;
            this.rbCanePastore.Location = new System.Drawing.Point(67, 61);
            this.rbCanePastore.Name = "rbCanePastore";
            this.rbCanePastore.Size = new System.Drawing.Size(87, 17);
            this.rbCanePastore.TabIndex = 4;
            this.rbCanePastore.Text = "cane pastore";
            this.rbCanePastore.UseVisualStyleBackColor = true;
            // 
            // rbCaneDaGuardia
            // 
            this.rbCaneDaGuardia.AutoSize = true;
            this.rbCaneDaGuardia.Location = new System.Drawing.Point(67, 84);
            this.rbCaneDaGuardia.Name = "rbCaneDaGuardia";
            this.rbCaneDaGuardia.Size = new System.Drawing.Size(102, 17);
            this.rbCaneDaGuardia.TabIndex = 3;
            this.rbCaneDaGuardia.Text = "cane da guardia";
            this.rbCaneDaGuardia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cane c\r\ndi tipo:\r\n";
            // 
            // rbCane
            // 
            this.rbCane.AutoSize = true;
            this.rbCane.Checked = true;
            this.rbCane.Location = new System.Drawing.Point(67, 38);
            this.rbCane.Name = "rbCane";
            this.rbCane.Size = new System.Drawing.Size(66, 17);
            this.rbCane.TabIndex = 1;
            this.rbCane.TabStop = true;
            this.rbCane.Text = "generico";
            this.rbCane.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnVersoAnimali);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnCreaAnimale);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbxTipoAnimale);
            this.tabPage2.Controls.Add(this.lbxAnimali);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classi astratte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVersoAnimali
            // 
            this.btnVersoAnimali.Location = new System.Drawing.Point(176, 113);
            this.btnVersoAnimali.Name = "btnVersoAnimali";
            this.btnVersoAnimali.Size = new System.Drawing.Size(120, 23);
            this.btnVersoAnimali.TabIndex = 5;
            this.btnVersoAnimali.Text = "Ascoltiamo i versi";
            this.btnVersoAnimali.UseVisualStyleBackColor = true;
            this.btnVersoAnimali.Click += new System.EventHandler(this.btnVersoAnimali_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lista degli animali creati:";
            // 
            // btnCreaAnimale
            // 
            this.btnCreaAnimale.Location = new System.Drawing.Point(176, 39);
            this.btnCreaAnimale.Name = "btnCreaAnimale";
            this.btnCreaAnimale.Size = new System.Drawing.Size(120, 23);
            this.btnCreaAnimale.TabIndex = 3;
            this.btnCreaAnimale.Text = "Crea Animale";
            this.btnCreaAnimale.UseVisualStyleBackColor = true;
            this.btnCreaAnimale.Click += new System.EventHandler(this.btnCreaAnimale_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo animale:";
            // 
            // cbxTipoAnimale
            // 
            this.cbxTipoAnimale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoAnimale.FormattingEnabled = true;
            this.cbxTipoAnimale.Items.AddRange(new object[] {
            "Asino",
            "Cavallo",
            "Gallo",
            "Gatto",
            "Maiale",
            "Mucca",
            "Papera"});
            this.cbxTipoAnimale.Location = new System.Drawing.Point(22, 41);
            this.cbxTipoAnimale.Name = "cbxTipoAnimale";
            this.cbxTipoAnimale.Size = new System.Drawing.Size(148, 21);
            this.cbxTipoAnimale.TabIndex = 1;
            // 
            // lbxAnimali
            // 
            this.lbxAnimali.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxAnimali.FormattingEnabled = true;
            this.lbxAnimali.Location = new System.Drawing.Point(22, 113);
            this.lbxAnimali.Name = "lbxAnimali";
            this.lbxAnimali.Size = new System.Drawing.Size(148, 147);
            this.lbxAnimali.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "Polimorfismo e classi astratte";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Polimorfismo e classi astratte";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbCaneDaGuardiaPiccolo;
        private System.Windows.Forms.RadioButton rbCanePastore;
        private System.Windows.Forms.RadioButton rbCaneDaGuardia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCane;
        private System.Windows.Forms.Button btnCreaCane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetRazza;
        private System.Windows.Forms.Button btnToString;
        private System.Windows.Forms.Button btnControlloTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoAnimale;
        private System.Windows.Forms.ListBox lbxAnimali;
        private System.Windows.Forms.Button btnCreaAnimale;
        private System.Windows.Forms.Button btnVersoAnimali;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

