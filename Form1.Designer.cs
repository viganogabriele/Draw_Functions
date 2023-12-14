namespace DisegnoFunzione
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
            this.txtXa = new System.Windows.Forms.TextBox();
            this.txtXb = new System.Windows.Forms.TextBox();
            this.btnZeri = new System.Windows.Forms.Button();
            this.txtEpsilon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtXa
            // 
            this.txtXa.Location = new System.Drawing.Point(597, 74);
            this.txtXa.Name = "txtXa";
            this.txtXa.Size = new System.Drawing.Size(72, 20);
            this.txtXa.TabIndex = 0;
            // 
            // txtXb
            // 
            this.txtXb.Location = new System.Drawing.Point(699, 74);
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(72, 20);
            this.txtXb.TabIndex = 1;
            // 
            // btnZeri
            // 
            this.btnZeri.Location = new System.Drawing.Point(623, 138);
            this.btnZeri.Name = "btnZeri";
            this.btnZeri.Size = new System.Drawing.Size(122, 23);
            this.btnZeri.TabIndex = 2;
            this.btnZeri.Text = "Calcola zeri";
            this.btnZeri.UseVisualStyleBackColor = true;
            this.btnZeri.Click += new System.EventHandler(this.btnZeri_Click);
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Location = new System.Drawing.Point(649, 100);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.Size = new System.Drawing.Size(72, 20);
            this.txtEpsilon.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEpsilon);
            this.Controls.Add(this.btnZeri);
            this.Controls.Add(this.txtXb);
            this.Controls.Add(this.txtXa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXa;
        private System.Windows.Forms.TextBox txtXb;
        private System.Windows.Forms.Button btnZeri;
        private System.Windows.Forms.TextBox txtEpsilon;
    }
}

