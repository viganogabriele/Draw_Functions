using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DisegnoFunzione
{
    public partial class Form1 : Form
    {
        Funzione f = new Funzione();
        float scala = 20f;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnZeri_Click(object sender, EventArgs e)
        {
            // Controllo input
            if (f.Parse(txtXa, txtXb, txtEpsilon))
            {
                // Verifica del teorema di Bolzano
                if (f.Y(f.xA) * f.Y(f.xB) < 0) 
                {
                    // Assegnazione del valore più piccolo a xA
                    if (f.xB > f.xA) 
                    {
                        double temp = f.xB;
                        f.xB = f.xA;
                        f.xA = temp;
                    }

                    // Riazzera i passaggi al click
                    f.passaggi[0] = 0;
                    f.passaggi[1] = 0;
                    f.passaggi[2] = 0;

                    // Stampa Bisezione
                    f.zeri[0] = f.Bisezione();
                    lblBisezione.Text = f.zeri[0].ToString();
                    lblPassaggiB.Text = f.passaggi[0].ToString();

                    // Stampa Tangente
                    f.zeri[1] = f.Tangente();
                    lblTangente.Text = f.zeri[1].ToString();
                    lblPassaggiT.Text = f.passaggi[1].ToString();

                    // Stampa Secante
                    f.zeri[2] = f.Secante();
                    lblSecante.Text = f.zeri[2].ToString();
                    lblPassaggiS.Text = f.passaggi[2].ToString();
                }
                else
                {
                    MessageBox.Show("Non è valido il teorema di Bolzano, non è garantito uno zero!");
                }
            }
            else
            {
                MessageBox.Show("Input inserito non valido");
            }
        }
        private void btnDisegna_Click(object sender, EventArgs e)
        {
            Disegna();
        }
        private void Disegna ()
        {
            float centroX = pictureBox.Width / 2;
            float centroY = pictureBox.Height / 2;
            using (Graphics g = pictureBox.CreateGraphics())
            {
                // Cancella il contenuto precedente
                g.Clear(Color.White);
                Pen pen = new Pen(Color.Black);
                // Disegna gli assi cartesiani
                g.DrawLine(pen, 0, centroY, pictureBox.Width, centroY);
                g.DrawLine(pen, centroX, 0, centroX, pictureBox.Height);
                // Rende visibili gli oggetti grafici
                lblY.Visible = true;
                lblArrow.Visible = true;
                lblX.Visible = true;
                lblZoom.Visible = true;
                btnZoomIn.Visible = true;
                btnZoomOut.Visible = true;
                // Disegna la funzione
                for (double i = -pictureBox.Width / 2; i < pictureBox.Width / 2; i += 0.02)
                {
                    double x = i / scala;
                    double y = f.Y(x);
                    g.DrawEllipse(pen, (float)(x * scala) + centroX, (float)(-y * scala) + centroY, 1, 1);
                }
            }
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            scala *= 2;
            Disegna();
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            scala /= 2;
            Disegna();
        }
    }
}