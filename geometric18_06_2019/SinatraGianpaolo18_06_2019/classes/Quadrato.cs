using SinatraGianpaolo18_06_2019.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinatraGianpaolo18_06_2019.classes
{
    public class Quadrato : IGeometria
    {
        private double _lato { get; set; }
        


        public double CalcoloArea()
        {
            return Math.Round(Math.Pow(_lato, 2), 2);
        }

        public double CalcoloPerimetro()
        {
            return Math.Round(_lato * 4, 2);
        }

        public Quadrato(double lato)
        {
            _lato = Math.Round(lato, 2);
        }

        public override string ToString()
        {
            string aloa = "";
            aloa += "CARATTERISTICHE FIGURA: Quadrato\n";
            aloa += "\n Lato: " + _lato.ToString();
            aloa += "\n Area: " + CalcoloArea().ToString();
            aloa += "\n Perimetro: " + CalcoloPerimetro().ToString();
            return aloa;
        }
    }
}