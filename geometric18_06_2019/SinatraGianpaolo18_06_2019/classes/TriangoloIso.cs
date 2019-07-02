using SinatraGianpaolo18_06_2019.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinatraGianpaolo18_06_2019.classes
{
    public class TriangoloIso : IGeometria
    {
        public double _base { get; set; }
        public double _altezza { get; set; }
        public double _lato { get; set; }

        public TriangoloIso(double ba, double alt)
        {
            _base = ba;
            _altezza = alt;
            _lato = Math.Sqrt(Math.Pow(_base / 2, 2) + Math.Pow(_altezza, 2));
        }


        public double CalcoloArea()
        {
            return Math.Round((_base * _altezza) / 2, 2);
        }

        public double CalcoloPerimetro()
        {
            return Math.Round((_lato * 2) + _base, 2);
        }

        public override string ToString()
        {
            string aloa = "";
            aloa += "CARATTERISTICHE FIGURA: Triangolo\n";
            aloa += "\n Base: " + _base.ToString();
            aloa += "\n Altezza: " + _altezza.ToString();
            aloa += "\n Lato: " + _lato.ToString();
            aloa += "\n Area: " + CalcoloArea().ToString();
            aloa += "\n Perimetro: " + CalcoloPerimetro().ToString();
            return aloa;
        }
    }
}