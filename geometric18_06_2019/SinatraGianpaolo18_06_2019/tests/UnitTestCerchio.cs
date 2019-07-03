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
    class UnitTestCerchio
    {


        [TestCase]
        public void Test_CalcoloPerimetro()
        {
            Cerchio c = new Cerchio(5);
            double circonferenza = c.CalcoloPerimetro();
            Assert.AreEqual(31.42, circonferenza);
        }


        [TestCase]
        public void Test_CalcoloArea()
        {
            Cerchio c = new Cerchio(1);
            double area = c.CalcoloArea();
            Assert.AreEqual(3.14, area);
        }

    }
    
}
