using NUnit.Framework;
using System;
using System.Collections.Generic;
using Lib;

namespace Tester
{
    public class Tests
    {
        [Test]
        public void Problem1Test1()
        {
            List<object> input = new List<object>() { 1, 2, 'a', 'b'};
            List<object> output = new List<object>() { 1, 2 };
            List<object> result = Class1.GetIntegersFromList(input);
            Assert.AreEqual(output, result, "Test failed");
        }

        [Test]
        public void Problem1Test2()
        {
            List<object> input = new List<object>() { };
            List<object> output = new List<object>() { };
            List<object> result = Class1.GetIntegersFromList(input);
            Assert.AreEqual(output, result, "Test failed");
        }


        [TestCase("sTreSS", "T")]
        [TestCase("","")]
        public void Problem2Tests(string input, string output)
        {
            string result = Class1.FirstNonRepeatingLetter(input);
            Assert.AreEqual(output, result, "Test failed");
        }

        [TestCase(16, 7)]
        [TestCase(132189, 6)]
        public void Problem3Tests(int input, int output)
        {
            int result = Class1.FindDigitalRoot(input);
            Assert.AreEqual(output, result, "Test failed");
        }

        [Test]
        public void Problem4Test1()
        {
            int[] input = new int[] { 1, 3, 6, 2, 2, 0, 4, 5};
            int inputTarget = 5;
            int output = 4;
            int result = Class1.FindSumCount(input, inputTarget);
            Assert.AreEqual(output, result, "Test failed");
        }

        [Test]
        public void Problem4Test2()
        {
            int[] input = new int[] { };
            int inputTarget = 7;
            int output = 0;
            int result = Class1.FindSumCount(input, inputTarget);
            Assert.AreEqual(output, result, "Test failed");
        }

        [TestCase("Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill",
            "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        [TestCase("", "")]
        public void Problem5Tests(string input, string output)
        {
            string result = Class1.SortByLast(input);
            Assert.AreEqual(output, result, "Test failed");
        }

        [TestCase(513, 531)]
        [TestCase(531, -1)]
        public void BonusProblem1Tests(int input, int output)
        {
            int result = Class1.FindNextBiggerNum(input);
            Assert.AreEqual(output, result, "Test failed");
        }

        [TestCase(2149583361, "128.32.10.1")]
        [TestCase((uint)32, "0.0.0.32")]
        public void BonusProblem2Tests(uint input, string output)
        {
            string result = Class1.IntegerToIP(input);
            Assert.AreEqual(output, result, "Test failed");
        }


    }
}
