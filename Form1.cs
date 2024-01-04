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
            // Controllare che f sia continua o lo do per scontato
            if (!double.TryParse(txtXa.Text, out xA) || !double.TryParse(txtXb.Text, out xB) || !double.TryParse(txtEpsilon.Text, out epsilon))
            {
                stop = true;
                MessageBox.Show("Input non valido");
            }
            if (stop == false)
            {
                if (f.Y(xA) * f.Y(xB) < 0)
                {
                    if (f.Y(xA) > f.Y(xB))
                    {
                        double temp = xB;
                        xB = xA;
                        xA = temp;
                    }
                    f.zeri[0] = f.Bisezione(xA, xB, epsilon);
                    f.zeri[1] = f.Tangente(xA, xB, epsilon);
                    f.zeri[2] = f.Secante(xA, xB, epsilon);
                    lbl0.Text = f.zeri[0].ToString();
                    lbl1.Text = f.zeri[1].ToString();
                    lbl2.Text = f.zeri[2].ToString();
                }
                else
                {
                    MessageBox.Show("La funzione non presenta uno zero!");
                }
            }
        }
        private void btnDisegna_Click(object sender, EventArgs e)
        {
            float centroX = pictureBox.Width / 2;
            float centroY = pictureBox.Height / 2;
            float scala = 40.0f;
            using (Graphics g = pictureBox.CreateGraphics())
            {
                g.Clear(Color.White); // Cancella il contenuto precedente
                Pen pen = new Pen(Color.Black);
                for (int i = -pictureBox.Width / 2; i < pictureBox.Width / 2; i++)
                {
                    double x = i / scala; // Adatta la scala
                    double y = f.Y(x);
                    g.DrawEllipse(pen, (float)(x * scala) + centroX, (float)(-y * scala) + centroY, 1, 1);
                }
            }
        }
    }
}