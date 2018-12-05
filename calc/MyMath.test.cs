using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calc
{
    class MyMathTest
    {
        [TestFixture]

        class test_Add  
        {
            [TestCase]

            public void TestAddPositive()
            {
                MyMaht maht = new MyMaht();
                Assert.AreEqual(30, maht.add(10, 20));
            }
             
                         
            [TestCase]

            public void TestAddLOE()
            {
                MyMaht maht = new MyMaht();
                Assert.LessOrEqual(21, maht.add(10, 20));
            }
            [TestCase]

            public void TestAddLO3()
            {
                MyMaht maht = new MyMaht();
                Assert.AreNotEqual(10, maht.add(10, 20));
            }

        }

     
    }
}
