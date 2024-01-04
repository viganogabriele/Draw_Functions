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
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnDisegna = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
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
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(631, 276);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(77, 13);
            this.lbl0.TabIndex = 4;
            this.lbl0.Text = "Zero Bisezione";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(631, 307);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Zero Tangente";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(631, 337);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(72, 13);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Zero Secante";
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
            this.pictureBox.Location = new System.Drawing.Point(57, 48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(480, 350);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnDisegna);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
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
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnDisegna;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

