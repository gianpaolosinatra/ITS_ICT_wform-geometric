using NUnit.Framework;
using SinatraGianpaolo18_06_2019.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinatraGianpaolo18_06_2019.tests
{
    [TestFixture]
    class UnitTestEsagono
    {


        [TestCase]
        public void Test_CalcoloPerimetro()
        {
            Esagono e = new Esagono(5);
            double perimetro = e.CalcoloPerimetro();
            Assert.AreEqual(30, perimetro);
        }


        [TestCase]
        public void Test_CalcoloArea()
        {
            Esagono e = new Esagono(5);
            double area = e.CalcoloArea();
            Assert.AreEqual(64.95, area);
        }

    }

}
