using SinatraGianpaolo18_06_2019.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinatraGianpaolo18_06_2019.classes
{
	public class Cerchio : IGeometria
	{
		private const double pi = Math.PI;
		public double _raggio { get; set; }

		

		public double CalcoloArea()
		{
			return Math.Round(pi * Math.Pow(_raggio, 2),2);
		}

		public double CalcoloPerimetro()
		{
			return Math.Round((2 * pi * _raggio),2);
		}

		public Cerchio(double raggio)
		{
			_raggio = Math.Round(raggio, 2);
		}

		public override string ToString()
		{
			string aloa = "";
            aloa += "CARATTERISTICHE FIGURA: Cerchio\n";
            aloa += "\n Raggio: " + _raggio.ToString();
			aloa += "\n Area: " + CalcoloArea().ToString();
			aloa += "\n Circonferenza: " + CalcoloPerimetro().ToString();
			return aloa;
		}
	}
}
