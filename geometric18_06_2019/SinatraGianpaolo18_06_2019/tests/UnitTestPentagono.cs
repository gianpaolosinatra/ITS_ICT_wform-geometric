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
    class UnitTestPentagono
    {


        [TestCase]
        public void Test_CalcoloPerimetro()
        {
            Pentagono p = new Pentagono(5);
            double perimetro = p.CalcoloPerimetro();
            Assert.AreEqual(25, perimetro);
        }


        [TestCase]
        public void Test_CalcoloArea()
        {
            Pentagono p = new Pentagono(5);
            double area = p.CalcoloArea();
            Assert.AreEqual(43, area);
        }

    }

}
