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
        public double xA;
        public double xB;
        public double epsilon;
        public Funzione() 
        {
        }
        public double Y (double x)
        {
            y = (x*x)-4; // Funzione
            return y;
        }
        public bool Parse(TextBox txtXa, TextBox txtXb, TextBox txtEpsilon) // Controllo Input
        {
            return double.TryParse(txtXa.Text, out xA) && double.TryParse(txtXb.Text, out xB) && double.TryParse(txtEpsilon.Text, out epsilon);
        }
        public double Bisezione()
        {
            double x0 = xA;
            double x1 = xB;
            double m = (xA + xB) / 2;
            while (Math.Abs(x0 - x1) >= epsilon && passaggi[0] < maxPassaggi)
            {
                if (Y(m) < 0 && Y(xA) < 0)
                {
                    x0 = m;
                }
                else if (Y(m) > 0 && Y(xA) > 0)
                {
                    x0 = m;
                }
                else
                {
                    x1 = m;
                }
                m = (x0 + x1) / 2;
                passaggi[0]++;
            } 
            return m;
        }
        public double Tangente()
        {
            double x0 = xB;
            double x1 = xA;
            double m;
            double q;
            double h = 0.0000000000001;
            while (Math.Abs(x0 - x1) >= epsilon && passaggi[1] < maxPassaggi)
            {
                if (passaggi[1] == 0)
                {
                    x0 = (x0 + x1) / 2;
                }
                x0 = x1;
                m = (Y(x0 + h) - Y(x0)) / h;
                q = Y(x0) - m * x0;
                x1 = - q / m;
                passaggi[1]++;
            }
            return x1;
        }
        public double Secante()
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
    }
}
