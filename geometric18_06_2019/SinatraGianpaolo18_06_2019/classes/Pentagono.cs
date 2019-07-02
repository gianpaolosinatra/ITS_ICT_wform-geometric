﻿using SinatraGianpaolo18_06_2019.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinatraGianpaolo18_06_2019.classes
{
    public class Pentagono : IGeometria
    {

        private double _lato { get; set; }

        private double _apotema { get; set; }
        

        public Pentagono(double lato)
        {
            _lato = lato;
            _apotema = _lato * 0.688;
        }
        


        public double CalcoloArea()
        {
            return Math.Round(_apotema * CalcoloPerimetro()/2, 2);
        }

        public double CalcoloPerimetro()
        {
            return Math.Round(_lato * 5, 2);
        }
        public override string ToString()
        {
            string aloa = "";
            aloa += "CARATTERISTICHE FIGURA: Pentagono \n";
            aloa += "\n Lato: " + _lato.ToString();
            aloa += "\n Area: " + CalcoloArea().ToString();
            aloa += "\n Perimetro: " + CalcoloPerimetro().ToString();
            return aloa;
        }

    }
}