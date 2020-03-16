#region Using References

using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Numerics;

#endregion

namespace Tests
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void Add001()
        {
            int aNumerator = 1;
            int aDenominator = 4;
            int bNumerator = 1;
            int bDenominator = 4;
            int expectedNumerator = 1;
            int expectedDenominator = 2;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a + b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Add002()
        {
            int aNumerator = 1;
            int aDenominator = 4;
            int bNumerator = 1;
            int bDenominator = 2;
            int expectedNumerator = 3;
            int expectedDenominator = 4;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a + b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Divide001()
        {
            int aNumerator = 1;
            int aDenominator = 4;
            int bNumerator = 1;
            int bDenominator = 4;
            int expectedNumerator = 1;
            int expectedDenominator = 1;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a / b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Divide002()
        {
            int aNumerator = 1;
            int aDenominator = 4;
            int bNumerator = 1;
            int bDenominator = 2;
            int expectedNumerator = 1;
            int expectedDenominator = 2;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a / b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Factors001()
        {
            List<int> factors = Rational<int>.GetFactors(12).ToList();
            int factorCount = 6;

            Assert.AreEqual(factors.Count, factorCount);
            Assert.AreEqual(factors[0], 1);
            Assert.AreEqual(factors[1], 2);
            Assert.AreEqual(factors[2], 3);
            Assert.AreEqual(factors[3], 4);
            Assert.AreEqual(factors[4], 6);
            Assert.AreEqual(factors[5], 12);
        }

        [TestMethod]
        public void Factors002()
        {
            List<int> factors = Rational<int>.GetFactors(30).ToList();
            int factorCount = 8;

            Assert.AreEqual(factors.Count, factorCount);
            Assert.AreEqual(factors[0], 1);
            Assert.AreEqual(factors[1], 2);
            Assert.AreEqual(factors[2], 3);
            Assert.AreEqual(factors[3], 5);
            Assert.AreEqual(factors[4], 6);
            Assert.AreEqual(factors[5], 10);
            Assert.AreEqual(factors[6], 15);
            Assert.AreEqual(factors[7], 30);
        }

        [TestMethod]
        public void HighestCommonFactor001()
        {
            List<int> a = Rational<int>.GetFactors(12).ToList();
            List<int> b = Rational<int>.GetFactors(30).ToList();
            int expectedHighestCommonFactor = 6;
            int highestCommonFactor = Rational<int>.GetHighestCommonFactor(a, b);

            Assert.AreEqual(expectedHighestCommonFactor, highestCommonFactor);
        }

        [TestMethod]
        public void HighestCommonFactor002()
        {
            List<int> a = Rational<int>.GetFactors(7).ToList();
            List<int> b = Rational<int>.GetFactors(21).ToList();
            int expectedHighestCommonFactor = 7;
            int highestCommonFactor = Rational<int>.GetHighestCommonFactor(a, b);

            Assert.AreEqual(expectedHighestCommonFactor, highestCommonFactor);
        }

        [TestMethod]
        public void HighestCommonFactor003()
        {
            List<int> a = Rational<int>.GetFactors(7).ToList();
            List<int> b = Rational<int>.GetFactors(23).ToList();
            int expectedHighestCommonFactor = 1;
            int highestCommonFactor = Rational<int>.GetHighestCommonFactor(a, b);

            Assert.AreEqual(expectedHighestCommonFactor, highestCommonFactor);
        }

        [TestMethod]
        public void Multiply001()
        {
            int aNumerator = 1;
            int aDenominator = 4;
            int bNumerator = 1;
            int bDenominator = 4;
            int expectedNumerator = 1;
            int expectedDenominator = 16;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a * b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Multiply002()
        {
            int aNumerator = 1;
            int aDenominator = 4;
            int bNumerator = 1;
            int bDenominator = 2;
            int expectedNumerator = 1;
            int expectedDenominator = 8;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a * b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Subtract001()
        {
            int aNumerator = 1;
            int aDenominator = 3;
            int bNumerator = 1;
            int bDenominator = 4;
            int expectedNumerator = 1;
            int expectedDenominator = 12;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a - b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Subtract002()
        {
            int aNumerator = 63;
            int aDenominator = 4;
            int bNumerator = 53;
            int bDenominator = 6;
            int expectedNumerator = 83;
            int expectedDenominator = 12;

            Rational<int> a = new Rational<int>(aNumerator, aDenominator);
            Rational<int> b = new Rational<int>(bNumerator, bDenominator);
            Rational<int> result = a - b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }
    }
}
