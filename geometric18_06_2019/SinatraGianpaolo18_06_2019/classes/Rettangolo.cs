using SinatraGianpaolo18_06_2019.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinatraGianpaolo18_06_2019.classes
{
    public class Rettangolo : IGeometria
	{
 
        private double _base { get; set; }
        private double _altezza { get; set; }

        public double CalcoloPerimetro()
        {
            return Math.Round((_base+_altezza)*2, 2);
        }

        public double CalcoloArea()
        {
            return Math.Round(_base * _altezza, 2);
        }

        public Rettangolo(double ba, double alt)
        {
            _base = Math.Round(ba, 2);
            _altezza = Math.Round(alt, 2);
        }

        public override string ToString()
        {
            string aloa = "";
            aloa += "CARATTERISTICHE FIGURA: Rettangolo\n";
            aloa += "\n Base: " + _base.ToString();
            aloa += "\n Altezza: " + _altezza.ToString();
            aloa += "\n Area: " + CalcoloArea().ToString();
            aloa += "\n Perimetro: " + CalcoloPerimetro().ToString();
            return aloa;
        }
    }
}