using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DisegnoFunzione
{
    internal class Funzione
    {
        public double y;
        public List <double> passaggi = new List <double>() {0, 0, 0};
        public List<double> zeri = new List<double> { 0.0, 0.0, 0.0};
        public int maxPassaggi = 50;
        public Funzione() 
        {
        }
        public double Y (double x)
        {
            y = (x*x) - 4; // Funzione
            return y;
        }
        public double Bisezione(double xA, double xB, double epsilon)
        {
            double m = (xA + xB) / 2;
            while (Math.Abs(xB - xA) >= epsilon && passaggi[0] < maxPassaggi)
            {
                if (Y(m) < 0 && Y(xA) < 0)
                {
                    xA = m;
                }
                else if (Y(m) > 0 && Y(xA) > 0)
                {
                    xA = m;
                }
                else
                {
                    xB = m;
                }
                m = (xA + xB) / 2;
                passaggi[0]++;
            } 
            return m;
        }
        public double Tangente(double xA, double xB, double epsilon)
        {
            double x0 = xB;
            double x1 = xA;
            double m;
            double q;
            double h = 0.0000000000001;
            while (Math.Abs(x0 - x1) >= epsilon && passaggi[1] < maxPassaggi)
            {
                x0 = (x0 +x1) / 2;
                m = (Y(x0 + h) - Y(x0)) / h;
                q = Y(x0) - m * x0;
                x1 = - q / m;
                passaggi[1]++;
            }
            return x1;
        }
        public double Secante(double xA, double xB, double epsilon)
        {
            double x0 = xB;
            double x1 = xA;
            while (Math.Abs(x0 - x1) >= epsilon && passaggi[2] < maxPassaggi)
            {
                x0 = x1;
                x1 = x0 - (((xB - x0) / (Y(xB) - Y(x0))) * Y(x0));
                passaggi[2]++;
            }
            return x1;
        }
        public void Disegna(PictureBox pictureBox, Label g1, Label g2, Label g3)
        {
            float centroX = pictureBox.Width / 2;
            float centroY = pictureBox.Height / 2;
            float scala = 20f;
            using (Graphics g = pictureBox.CreateGraphics())
            {
                g.Clear(Color.White); // Cancella il contenuto precedente
                Pen pen = new Pen(Color.Black);
                g.DrawLine(pen, 0, centroY, pictureBox.Width, centroY);
                g.DrawLine(pen, centroX, 0, centroX, pictureBox.Height);
                g1.Visible = true;
                g2.Visible = true;
                g3.Visible = true;
                for (double i = -pictureBox.Width / 2; i < pictureBox.Width / 2; i += 0.02)
                {
                    double x = i / scala; // Adatta la scala
                    double y = Y(x);
                    g.DrawEllipse(pen, (float)(x * scala) + centroX, (float)(-y * scala) + centroY, 1, 1);
                }
            }
        }
    }
}
