using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp3
{
    class MyMathTest
    {
        [TestFixture]

        class Test_Add
        {
            [TestCase]

            public void TestAddPositives()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(30, math.Add(10, 20));
            }

            [TestCase]

            public void TestAdddNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(30, math.Add(10, 20));
            }

            [TestCase]

            public void TestAddMultiply()
            {
                MyMath math = new MyMath();
                Assert.Greater(math.Add(10, 30), 30);

            }












        }
    }
}
