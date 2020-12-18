namespace LotteriaNatale
{
    partial class FrmNumeri
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
            this.flpLotteria = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVittoria = new System.Windows.Forms.Button();
            this.txtNumeriScelti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flpLotteria
            // 
            this.flpLotteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLotteria.Location = new System.Drawing.Point(12, 38);
            this.flpLotteria.Name = "flpLotteria";
            this.flpLotteria.Size = new System.Drawing.Size(384, 384);
            this.flpLotteria.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome giocatore:";
            // 
            // btnVittoria
            // 
            this.btnVittoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVittoria.Location = new System.Drawing.Point(280, 9);
            this.btnVittoria.Name = "btnVittoria";
            this.btnVittoria.Size = new System.Drawing.Size(116, 23);
            this.btnVittoria.TabIndex = 2;
            this.btnVittoria.Text = "Controlla se hai vinto";
            this.btnVittoria.UseVisualStyleBackColor = true;
            this.btnVittoria.Click += new System.EventHandler(this.btnCompleta_Click);
            // 
            // txtNumeriScelti
            // 
            this.txtNumeriScelti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeriScelti.Location = new System.Drawing.Point(12, 386);
            this.txtNumeriScelti.Name = "txtNumeriScelti";
            this.txtNumeriScelti.ReadOnly = true;
            this.txtNumeriScelti.Size = new System.Drawing.Size(384, 20);
            this.txtNumeriScelti.TabIndex = 3;
            // 
            // FrmNumeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 423);
            this.Controls.Add(this.txtNumeriScelti);
            this.Controls.Add(this.btnVittoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.flpLotteria);
            this.Name = "FrmNumeri";
            this.Text = "Numeri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLotteria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVittoria;
        private System.Windows.Forms.TextBox txtNumeriScelti;
    }
}