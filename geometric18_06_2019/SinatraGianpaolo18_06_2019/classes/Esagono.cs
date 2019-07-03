using SinatraGianpaolo18_06_2019.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinatraGianpaolo18_06_2019.classes
{
    public class Esagono : IGeometria
    {
 
        private double _lato { get; set; }

        private double _apotema { get; set; }


        public Esagono(double lato)
        {
            _lato = Math.Round(lato, 2);
            _apotema = _lato * 0.866;
        }



        public double CalcoloArea()
        {
            return Math.Round( (_apotema * CalcoloPerimetro())/2, 2);
        }

        public double CalcoloPerimetro()
        {
            return Math.Round(_lato * 6, 2);
        }
        public override string ToString()
        {
            string aloa = "";
            aloa += "CARATTERISTICHE FIGURA: Esagono \n";

            aloa += "\n Lato: " + _lato.ToString();
            aloa += "\n Area: " + CalcoloArea().ToString();
            aloa += "\n Perimetro: " + CalcoloPerimetro().ToString();
            return aloa;
        }
    }
}