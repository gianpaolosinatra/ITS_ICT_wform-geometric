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
    class UnitTestTriangoloIso
    {


        [TestCase]
        public void Test_CalcoloPerimetro()
        {
            TriangoloIso t = new TriangoloIso(5, 4);
            double perimetro = t.CalcoloPerimetro();
            Assert.AreEqual(15, perimetro);
        }


        [TestCase]
        public void Test_CalcoloArea()
        {
            TriangoloIso t = new TriangoloIso(5, 4);
            double area = t.CalcoloArea();
            Assert.AreEqual(10, area);
        }

    }

}
