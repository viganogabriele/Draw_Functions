using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DisegnoFunzione
{
    internal class Funzione
    {
        public double y;
        public List <double> passaggi = new List <double>();
        public Funzione() 
        {
        }
        // y = x*5 - 2
        public double Y (double x)
        {
            y = x * 5 - 2; // Funzione
            return y;
        }
        public bool Trovato(double xA, double xB, double epsilon)
        {
            return Math.Abs(xB - xA) < epsilon;
        }
        public double Bisezione(double xA, double xB, double epsilon)
        {
            double m = (xA + xB) / 2;
            while (Trovato(xA, xB, epsilon) == true || passaggi[0] > 1000)
            {
                if (m > xA)
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
            double x0;
            double x1 = xA;
            double m;
            double q;
            double h = 0.00000000000001;
            while (Trovato(x0, x1, epsilon) == true || passaggi[1] > 1000)
            {
                x0 = x1;
                m = (Y(x0) - Y(x0+h)) / h;
                q = Y(x0) - m * x0;
                x1 = - q / m;
                passaggi[1]++;
            }
            return x1;
        }
        public double Secante(double xA, double xB, double epsilon)
        {
            double x0 = xA;
            double x1; 
            while (Trovato(x0, x1, epsilon) == true || passaggi[1] > 1000)
            {
                x1 = x0 - ((xB - x0) / (Y(xB) - Y(x0)) * Y(x0);
                passaggi[2]++;
            }
            return x1;
        }
    }
}
