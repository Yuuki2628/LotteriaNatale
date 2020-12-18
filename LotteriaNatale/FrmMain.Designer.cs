namespace LotteriaNatale
{
    partial class FrmMain
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblScelta = new System.Windows.Forms.Label();
            this.rbdPulsanti = new System.Windows.Forms.RadioButton();
            this.rbdCheckbox = new System.Windows.Forms.RadioButton();
            this.btnGenera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(144, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Inserire il nome del giocatore:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblScelta
            // 
            this.lblScelta.AutoSize = true;
            this.lblScelta.Location = new System.Drawing.Point(12, 74);
            this.lblScelta.Name = "lblScelta";
            this.lblScelta.Size = new System.Drawing.Size(74, 13);
            this.lblScelta.TabIndex = 2;
            this.lblScelta.Text = "Scelta numeri:";
            // 
            // rbdPulsanti
            // 
            this.rbdPulsanti.AutoSize = true;
            this.rbdPulsanti.Location = new System.Drawing.Point(15, 90);
            this.rbdPulsanti.Name = "rbdPulsanti";
            this.rbdPulsanti.Size = new System.Drawing.Size(62, 17);
            this.rbdPulsanti.TabIndex = 3;
            this.rbdPulsanti.TabStop = true;
            this.rbdPulsanti.Text = "Pulsanti";
            this.rbdPulsanti.UseVisualStyleBackColor = true;
            this.rbdPulsanti.CheckedChanged += new System.EventHandler(this.rbdPulsanti_CheckedChanged);
            // 
            // rbdCheckbox
            // 
            this.rbdCheckbox.AutoSize = true;
            this.rbdCheckbox.Location = new System.Drawing.Point(83, 90);
            this.rbdCheckbox.Name = "rbdCheckbox";
            this.rbdCheckbox.Size = new System.Drawing.Size(73, 17);
            this.rbdCheckbox.TabIndex = 4;
            this.rbdCheckbox.TabStop = true;
            this.rbdCheckbox.Text = "Checkbox";
            this.rbdCheckbox.UseVisualStyleBackColor = true;
            this.rbdCheckbox.CheckedChanged += new System.EventHandler(this.rbtCheckbox_CheckedChanged);
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(15, 113);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(141, 33);
            this.btnGenera.TabIndex = 5;
            this.btnGenera.Text = "GeneraTabellone";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 153);
            this.Controls.Add(this.btnGenera);
            this.Controls.Add(this.rbdCheckbox);
            this.Controls.Add(this.rbdPulsanti);
            this.Controls.Add(this.lblScelta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Lotteria di Natale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblScelta;
        private System.Windows.Forms.Button btnGenera;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.RadioButton rbdPulsanti;
        public System.Windows.Forms.RadioButton rbdCheckbox;
    }
}

