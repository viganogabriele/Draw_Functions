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
        public float y;
        public List <float> passaggi = new List <float>();
        public Funzione() 
        {
        }
        // y = x*5 - 2
        public float Y (float x)
        {
            y = x * 5 - 2; // Funzione
            return y;
        }
        public float Bisezione(float xA, float xB, float epsilon)
        {
            float m = (xA + xB) / 2;
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
    }
}
