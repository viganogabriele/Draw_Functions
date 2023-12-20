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
            return (xB - xA) < epsilon;
        }
        public double Bisezione(double xA, double xB, double epsilon)
        {
            double m = (xA + xB) / 2;
            while (Math.Abs(Y(m)) < epsilon)
            {
                m = (xA + xB) / 2;
                if (Y(m) > 0)
                {
                    xB = m;
                }
                else
                {
                    xA = m;
                }
                passaggi[0]++;
            }  
            return m;
        }
        public double Tangente(double xA, double xB, double epsilon)
        {

        }
    }
}
