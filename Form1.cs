using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisegnoFunzione
{
    public partial class Form1 : Form
    {
        bool continua = false;
        float xA;
        float xB;
        float epsilon;
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
            // Controllare che f sia continua o lo do per scontato
            if (!float.TryParse(txtXa.Text, out xA))
            {
                MessageBox.Show("Input non valido");
            }
            if (!float.TryParse(txtXa.Text, out xA))
            {
                MessageBox.Show("Input non valido");
            }
            if (!float.TryParse(txtXa.Text, out epsilon))
            {
                MessageBox.Show("Input non valido");
            }
            if (f.Y(xA) * f.Y(xB) < 0)
            {
                continua = true;
                if(f.Y(xA) > f.Y(xB))
                {
                    float temp = xB;
                    xB = xA;
                    xA = temp;
                }
            }
            else
            {
                MessageBox.Show("La funzione non presenta uno zero!");
            }


        }
    }
}
