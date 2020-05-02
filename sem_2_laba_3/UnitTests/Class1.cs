using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using sem_2_laba_3;

namespace UnitTests
{
    [TestFixture]
    public class Class1
    {
        [TestCase(new int[] {1, 2, 3}, 2)]
        [TestCase(new int[] {3, 2, 1}, 2)]
        [TestCase(new int[] {3, 3, 3}, 3)]
        [TestCase(new int[] {1, 3, 5}, 3)]
        [TestCase(new int[] { 7, 10, 5, 0, -2 }, 4)]
        [TestCase(new int[] { 1, 1, 2, 2 }, 1.5)]
        [TestCase(new int[] { 5, 3, 1 }, 3)]
        [TestCase(new int[] { -2, 0, 5, 10, 7}, 4)]
        [TestCase(new int[] { 2, 2, 1, 1 }, 1.5)]
        [TestCase(new int[] { 0 }, 0)]
        public void Test(int[] a, double result)
        {
            Assert.IsTrue(Program1.calculate(a) == result);
        }

        [TestCase(1, 1, "+", 2)]
        [TestCase(1, 1, "-", 0)]
        [TestCase(5, 2, "-", 3)]
        [TestCase(5, 2, "+", 7)]
        [TestCase(0, 0, "+", 0)]
        [TestCase(0, 0, "-", 0)]
        [TestCase(0, -1, "-", 1)]
        [TestCase(0, 1, "-", -1)]
        [TestCase(-10, -1, "+", -11)]
        public void TestForCalculate(int x, int y, string oper, double result)
        {
            Assert.IsTrue(Program2.calculate(x, y, oper) == result);
        }

        [TestCase("_")]
        public void TestForCalulateThrow(string oper)
        {
            Assert.Throws<Exception>(() => Program2.calculate(1, 1, oper));
        }
    }

    
}
