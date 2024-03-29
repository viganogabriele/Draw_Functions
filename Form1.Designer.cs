﻿namespace DisegnoFunzione
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXa
            // 
            this.txtXa.Location = new System.Drawing.Point(584, 64);
            this.txtXa.Name = "txtXa";
            this.txtXa.Size = new System.Drawing.Size(72, 20);
            this.txtXa.TabIndex = 0;
            // 
            // txtXb
            // 
            this.txtXb.Location = new System.Drawing.Point(677, 64);
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(72, 20);
            this.txtXb.TabIndex = 1;
            // 
            // btnZeri
            // 
            this.btnZeri.Location = new System.Drawing.Point(584, 148);
            this.btnZeri.Name = "btnZeri";
            this.btnZeri.Size = new System.Drawing.Size(165, 23);
            this.btnZeri.TabIndex = 2;
            this.btnZeri.Text = "Calcola zeri";
            this.btnZeri.UseVisualStyleBackColor = true;
            this.btnZeri.Click += new System.EventHandler(this.btnZeri_Click);
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Location = new System.Drawing.Point(677, 110);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.Size = new System.Drawing.Size(72, 20);
            this.txtEpsilon.TabIndex = 3;
            // 
            // lblBisezione
            // 
            this.lblBisezione.AutoSize = true;
            this.lblBisezione.Location = new System.Drawing.Point(582, 221);
            this.lblBisezione.Name = "lblBisezione";
            this.lblBisezione.Size = new System.Drawing.Size(77, 13);
            this.lblBisezione.TabIndex = 4;
            this.lblBisezione.Text = "Zero Bisezione";
            // 
            // lblTangente
            // 
            this.lblTangente.AutoSize = true;
            this.lblTangente.Location = new System.Drawing.Point(582, 252);
            this.lblTangente.Name = "lblTangente";
            this.lblTangente.Size = new System.Drawing.Size(78, 13);
            this.lblTangente.TabIndex = 5;
            this.lblTangente.Text = "Zero Tangente";
            // 
            // lblSecante
            // 
            this.lblSecante.AutoSize = true;
            this.lblSecante.Location = new System.Drawing.Point(582, 284);
            this.lblSecante.Name = "lblSecante";
            this.lblSecante.Size = new System.Drawing.Size(72, 13);
            this.lblSecante.TabIndex = 6;
            this.lblSecante.Text = "Zero Secante";
            // 
            // btnDisegna
            // 
            this.btnDisegna.Location = new System.Drawing.Point(584, 320);
            this.btnDisegna.Name = "btnDisegna";
            this.btnDisegna.Size = new System.Drawing.Size(165, 23);
            this.btnDisegna.TabIndex = 7;
            this.btnDisegna.Text = "Disegna funzione";
            this.btnDisegna.UseVisualStyleBackColor = true;
            this.btnDisegna.Click += new System.EventHandler(this.btnDisegna_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(39, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(509, 378);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // lblPassaggiB
            // 
            this.lblPassaggiB.AutoSize = true;
            this.lblPassaggiB.Location = new System.Drawing.Point(700, 221);
            this.lblPassaggiB.Name = "lblPassaggiB";
            this.lblPassaggiB.Size = new System.Drawing.Size(50, 13);
            this.lblPassaggiB.TabIndex = 9;
            this.lblPassaggiB.Text = "Passaggi";
            // 
            // lblPassaggiT
            // 
            this.lblPassaggiT.AutoSize = true;
            this.lblPassaggiT.Location = new System.Drawing.Point(700, 252);
            this.lblPassaggiT.Name = "lblPassaggiT";
            this.lblPassaggiT.Size = new System.Drawing.Size(50, 13);
            this.lblPassaggiT.TabIndex = 10;
            this.lblPassaggiT.Text = "Passaggi";
            // 
            // lblPassaggiS
            // 
            this.lblPassaggiS.AutoSize = true;
            this.lblPassaggiS.Location = new System.Drawing.Point(700, 284);
            this.lblPassaggiS.Name = "lblPassaggiS";
            this.lblPassaggiS.Size = new System.Drawing.Size(50, 13);
            this.lblPassaggiS.TabIndex = 11;
            this.lblPassaggiS.Text = "Passaggi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Intervallo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Epsilon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Risultati";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(21, 214);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(12, 13);
            this.lblX.TabIndex = 15;
            this.lblX.Text = "x";
            this.lblX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(290, 9);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(12, 13);
            this.lblY.TabIndex = 16;
            this.lblY.Text = "y";
            this.lblY.Visible = false;
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Location = new System.Drawing.Point(535, 214);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(13, 13);
            this.lblArrow.TabIndex = 17;
            this.lblArrow.Text = ">";
            this.lblArrow.Visible = false;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(579, 387);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(80, 23);
            this.btnZoomIn.TabIndex = 18;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Visible = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(664, 387);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(80, 23);
            this.btnZoomOut.TabIndex = 19;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Visible = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(639, 355);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(50, 20);
            this.lblZoom.TabIndex = 20;
            this.lblZoom.Text = "Zoom";
            this.lblZoom.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 466);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label lblZoom;
    }
}

