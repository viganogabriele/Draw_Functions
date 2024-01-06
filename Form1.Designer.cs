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
            this.lblBisezione = new System.Windows.Forms.Label();
            this.lblTangente = new System.Windows.Forms.Label();
            this.lblSecante = new System.Windows.Forms.Label();
            this.btnDisegna = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblPassaggiB = new System.Windows.Forms.Label();
            this.lblPassaggiT = new System.Windows.Forms.Label();
            this.lblPassaggiS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXa
            // 
            this.txtXa.Location = new System.Drawing.Point(582, 76);
            this.txtXa.Name = "txtXa";
            this.txtXa.Size = new System.Drawing.Size(72, 20);
            this.txtXa.TabIndex = 0;
            // 
            // txtXb
            // 
            this.txtXb.Location = new System.Drawing.Point(684, 76);
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(72, 20);
            this.txtXb.TabIndex = 1;
            // 
            // btnZeri
            // 
            this.btnZeri.Location = new System.Drawing.Point(608, 223);
            this.btnZeri.Name = "btnZeri";
            this.btnZeri.Size = new System.Drawing.Size(122, 23);
            this.btnZeri.TabIndex = 2;
            this.btnZeri.Text = "Calcola zeri";
            this.btnZeri.UseVisualStyleBackColor = true;
            this.btnZeri.Click += new System.EventHandler(this.btnZeri_Click);
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Location = new System.Drawing.Point(634, 102);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.Size = new System.Drawing.Size(72, 20);
            this.txtEpsilon.TabIndex = 3;
            // 
            // lblBisezione
            // 
            this.lblBisezione.AutoSize = true;
            this.lblBisezione.Location = new System.Drawing.Point(605, 274);
            this.lblBisezione.Name = "lblBisezione";
            this.lblBisezione.Size = new System.Drawing.Size(77, 13);
            this.lblBisezione.TabIndex = 4;
            this.lblBisezione.Text = "Zero Bisezione";
            // 
            // lblTangente
            // 
            this.lblTangente.AutoSize = true;
            this.lblTangente.Location = new System.Drawing.Point(605, 305);
            this.lblTangente.Name = "lblTangente";
            this.lblTangente.Size = new System.Drawing.Size(78, 13);
            this.lblTangente.TabIndex = 5;
            this.lblTangente.Text = "Zero Tangente";
            // 
            // lblSecante
            // 
            this.lblSecante.AutoSize = true;
            this.lblSecante.Location = new System.Drawing.Point(605, 337);
            this.lblSecante.Name = "lblSecante";
            this.lblSecante.Size = new System.Drawing.Size(72, 13);
            this.lblSecante.TabIndex = 6;
            this.lblSecante.Text = "Zero Secante";
            // 
            // btnDisegna
            // 
            this.btnDisegna.Location = new System.Drawing.Point(608, 167);
            this.btnDisegna.Name = "btnDisegna";
            this.btnDisegna.Size = new System.Drawing.Size(122, 23);
            this.btnDisegna.TabIndex = 7;
            this.btnDisegna.Text = "Disegna funzione";
            this.btnDisegna.UseVisualStyleBackColor = true;
            this.btnDisegna.Click += new System.EventHandler(this.btnDisegna_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(57, 48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(480, 350);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // lblPassaggiB
            // 
            this.lblPassaggiB.AutoSize = true;
            this.lblPassaggiB.Location = new System.Drawing.Point(688, 274);
            this.lblPassaggiB.Name = "lblPassaggiB";
            this.lblPassaggiB.Size = new System.Drawing.Size(50, 13);
            this.lblPassaggiB.TabIndex = 9;
            this.lblPassaggiB.Text = "Passaggi";
            // 
            // lblPassaggiT
            // 
            this.lblPassaggiT.AutoSize = true;
            this.lblPassaggiT.Location = new System.Drawing.Point(688, 305);
            this.lblPassaggiT.Name = "lblPassaggiT";
            this.lblPassaggiT.Size = new System.Drawing.Size(50, 13);
            this.lblPassaggiT.TabIndex = 10;
            this.lblPassaggiT.Text = "Passaggi";
            // 
            // lblPassaggiS
            // 
            this.lblPassaggiS.AutoSize = true;
            this.lblPassaggiS.Location = new System.Drawing.Point(688, 337);
            this.lblPassaggiS.Name = "lblPassaggiS";
            this.lblPassaggiS.Size = new System.Drawing.Size(50, 13);
            this.lblPassaggiS.TabIndex = 11;
            this.lblPassaggiS.Text = "Passaggi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassaggiS);
            this.Controls.Add(this.lblPassaggiT);
            this.Controls.Add(this.lblPassaggiB);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnDisegna);
            this.Controls.Add(this.lblSecante);
            this.Controls.Add(this.lblTangente);
            this.Controls.Add(this.lblBisezione);
            this.Controls.Add(this.txtEpsilon);
            this.Controls.Add(this.btnZeri);
            this.Controls.Add(this.txtXb);
            this.Controls.Add(this.txtXa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXa;
        private System.Windows.Forms.TextBox txtXb;
        private System.Windows.Forms.Button btnZeri;
        private System.Windows.Forms.TextBox txtEpsilon;
        private System.Windows.Forms.Label lblBisezione;
        private System.Windows.Forms.Label lblTangente;
        private System.Windows.Forms.Label lblSecante;
        private System.Windows.Forms.Button btnDisegna;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblPassaggiB;
        private System.Windows.Forms.Label lblPassaggiT;
        private System.Windows.Forms.Label lblPassaggiS;
    }
}

