using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinatraGianpaolo18_06_2019.classes
{
    public static class G3D
    {
        public static double CalcoloVolume(double area, double altezza)
        {
            return Math.Round((area * altezza), 2);
        }

        public static double GetDouble(string dato)
        {
            return (Double.TryParse(dato, out double prop)) ? prop : 0;
        }


        public static bool IsNegative(double prop)
        {
            return prop <= 0 ? true : false;
        }

        public static bool IsNegative(double prop, double prop2)
        {
            return prop <= 0 || prop2 <= 0 ? true : false;
        }

    }
}
