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
        double xA;
        double xB;
        double epsilon;
        bool stop = false;
        Funzione f = new Funzione();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnZeri_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtXa.Text, out xA) || !double.TryParse(txtXb.Text, out xB) || !double.TryParse(txtEpsilon.Text, out epsilon))
            {
                stop = true;
                MessageBox.Show("Input non valido");
            } 
            if (stop == false)
            {
                if (f.Y(xA) * f.Y(xB) < 0)
                {
                    if (xB > xA)
                    {
                        double temp = xB;
                        xB = xA;
                        xA = temp;
                    }
                    f.passaggi[0] = 0;
                    f.passaggi[1] = 0;
                    f.passaggi[2] = 0;
                    f.zeri[0] = f.Bisezione(xA, xB, epsilon);
                    lblBisezione.Text = f.zeri[0].ToString();
                    lblPassaggiB.Text = f.passaggi[0].ToString();
                    /*
                    f.zeri[1] = f.Tangente(xA, xB, epsilon);
                    f.zeri[2] = f.Secante(xA, xB, epsilon);    
                    
                    lblTangente.Text = f.zeri[1].ToString();
                    lblSecante.Text = f.zeri[2].ToString();
                    
                    lblPassaggiT.Text = f.passaggi[0].ToString();
                    lblPassaggiS.Text = f.passaggi[0].ToString();
                    */
                }
                else
                {
                    MessageBox.Show("La funzione non presenta uno zero!");
                }
            }
        }
        private void btnDisegna_Click(object sender, EventArgs e)
        {
            f.Disegna(pictureBox);
        }
    }
}