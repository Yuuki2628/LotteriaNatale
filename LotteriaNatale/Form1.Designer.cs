namespace LotteriaNatale
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblScelta = new System.Windows.Forms.Label();
            this.rbdPulsanti = new System.Windows.Forms.RadioButton();
            this.rbtCheckbox = new System.Windows.Forms.RadioButton();
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
            // 
            // rbtCheckbox
            // 
            this.rbtCheckbox.AutoSize = true;
            this.rbtCheckbox.Location = new System.Drawing.Point(83, 90);
            this.rbtCheckbox.Name = "rbtCheckbox";
            this.rbtCheckbox.Size = new System.Drawing.Size(73, 17);
            this.rbtCheckbox.TabIndex = 4;
            this.rbtCheckbox.TabStop = true;
            this.rbtCheckbox.Text = "Checkbox";
            this.rbtCheckbox.UseVisualStyleBackColor = true;
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(15, 113);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(141, 33);
            this.btnGenera.TabIndex = 5;
            this.btnGenera.Text = "GeneraTabellone";
            this.btnGenera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 153);
            this.Controls.Add(this.btnGenera);
            this.Controls.Add(this.rbtCheckbox);
            this.Controls.Add(this.rbdPulsanti);
            this.Controls.Add(this.lblScelta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblScelta;
        private System.Windows.Forms.RadioButton rbdPulsanti;
        private System.Windows.Forms.RadioButton rbtCheckbox;
        private System.Windows.Forms.Button btnGenera;
    }
}

