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
    class UnitTestQuadrato
    {


        [TestCase]
        public void Test_CalcoloPerimetro()
        {
            Quadrato q = new Quadrato(5);
            double perimetro = q.CalcoloPerimetro();
            Assert.AreEqual(20, perimetro);
        }


        [TestCase]
        public void Test_CalcoloArea()
        {
            Quadrato q = new Quadrato(5);
            double area = q.CalcoloArea();
            Assert.AreEqual(25, area);
        }

    }

}
