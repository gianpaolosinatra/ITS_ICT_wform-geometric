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
    class UnitTestRettangolo
    {


        [TestCase]
        public void Test_CalcoloPerimetro()
        {
            Rettangolo r = new Rettangolo(5,4);
            double perimetro = r.CalcoloPerimetro();
            Assert.AreEqual(18, perimetro);
        }


        [TestCase]
        public void Test_CalcoloArea()
        {
            Rettangolo r = new Rettangolo(5,4);
            double area = r.CalcoloArea();
            Assert.AreEqual(20, area);
        }

    }

}
