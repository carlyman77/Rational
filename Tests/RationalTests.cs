#region Using References

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Numerics;

#endregion

namespace Tests
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void Add_BigInteger_001()
        {
            BigInteger aNumerator = 1;
            BigInteger aDenominator = 4;
            BigInteger bNumerator = 1;
            BigInteger bDenominator = 4;
            BigInteger expectedNumerator = 1;
            BigInteger expectedDenominator = 2;

            Rational<BigInteger> a = new Rational<BigInteger>(aNumerator, aDenominator);
            Rational<BigInteger> b = new Rational<BigInteger>(bNumerator, bDenominator);
            Rational<BigInteger> result = a + b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Add_BigInteger_002()
        {
            BigInteger aNumerator = 1;
            BigInteger aDenominator = 4;
            BigInteger bNumerator = 1;
            BigInteger bDenominator = 2;
            BigInteger expectedNumerator = 3;
            BigInteger expectedDenominator = 4;

            Rational<BigInteger> a = new Rational<BigInteger>(aNumerator, aDenominator);
            Rational<BigInteger> b = new Rational<BigInteger>(bNumerator, bDenominator);
            Rational<BigInteger> result = a + b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Add_Int32_001()
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
        public void Add_Int32_002()
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
        public void Add_Int64_001()
        {
            long aNumerator = 1;
            long aDenominator = 4;
            long bNumerator = 1;
            long bDenominator = 4;
            long expectedNumerator = 1;
            long expectedDenominator = 2;

            Rational<long> a = new Rational<long>(aNumerator, aDenominator);
            Rational<long> b = new Rational<long>(bNumerator, bDenominator);
            Rational<long> result = a + b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void AddInt64_002()
        {
            long aNumerator = 1;
            long aDenominator = 4;
            long bNumerator = 1;
            long bDenominator = 2;
            long expectedNumerator = 3;
            long expectedDenominator = 4;

            Rational<long> a = new Rational<long>(aNumerator, aDenominator);
            Rational<long> b = new Rational<long>(bNumerator, bDenominator);
            Rational<long> result = a + b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Divide_BigInteger_001()
        {
            BigInteger aNumerator = 1;
            BigInteger aDenominator = 4;
            BigInteger bNumerator = 1;
            BigInteger bDenominator = 4;
            BigInteger expectedNumerator = 1;
            BigInteger expectedDenominator = 1;

            Rational<BigInteger> a = new Rational<BigInteger>(aNumerator, aDenominator);
            Rational<BigInteger> b = new Rational<BigInteger>(bNumerator, bDenominator);
            Rational<BigInteger> result = a / b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Divide_Int32_001()
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
        public void Divide_Int64_001()
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
        public void HighestCommonFactor001()
        {
            int a = 12;
            int b = 30;
            int expectedHighestCommonFactor = 6;
            int highestCommonFactor = Rational<int>.GetHighestCommonFactor(a, b);

            Assert.AreEqual(expectedHighestCommonFactor, highestCommonFactor);
        }

        [TestMethod]
        public void HighestCommonFactor002()
        {
            int a = 7;
            int b = 21;
            int expectedHighestCommonFactor = 7;
            int highestCommonFactor = Rational<int>.GetHighestCommonFactor(a, b);

            Assert.AreEqual(expectedHighestCommonFactor, highestCommonFactor);
        }

        [TestMethod]
        public void HighestCommonFactor003()
        {
            int a = 7;
            int b = 23;
            int expectedHighestCommonFactor = 1;
            int highestCommonFactor = Rational<int>.GetHighestCommonFactor(a, b);

            Assert.AreEqual(expectedHighestCommonFactor, highestCommonFactor);
        }

        [TestMethod]
        public void Multiply_BigInteger_001()
        {
            BigInteger aNumerator = 1;
            BigInteger aDenominator = 4;
            BigInteger bNumerator = 1;
            BigInteger bDenominator = 4;
            BigInteger expectedNumerator = 1;
            BigInteger expectedDenominator = 16;

            Rational<BigInteger> a = new Rational<BigInteger>(aNumerator, aDenominator);
            Rational<BigInteger> b = new Rational<BigInteger>(bNumerator, bDenominator);
            Rational<BigInteger> result = a * b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Multiply_BigInteger_002()
        {
            BigInteger aNumerator = 1;
            BigInteger aDenominator = 4;
            BigInteger bNumerator = 1;
            BigInteger bDenominator = 2;
            BigInteger expectedNumerator = 1;
            BigInteger expectedDenominator = 8;

            Rational<BigInteger> a = new Rational<BigInteger>(aNumerator, aDenominator);
            Rational<BigInteger> b = new Rational<BigInteger>(bNumerator, bDenominator);
            Rational<BigInteger> result = a * b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Multiply_Int32_001()
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
        public void Multiply_Int32_002()
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
        public void Multiply_Int64_001()
        {
            long aNumerator = 1;
            long aDenominator = 4;
            long bNumerator = 1;
            long bDenominator = 4;
            long expectedNumerator = 1;
            long expectedDenominator = 16;

            Rational<long> a = new Rational<long>(aNumerator, aDenominator);
            Rational<long> b = new Rational<long>(bNumerator, bDenominator);
            Rational<long> result = a * b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Multiply_Int64_002()
        {
            long aNumerator = 1;
            long aDenominator = 4;
            long bNumerator = 1;
            long bDenominator = 2;
            long expectedNumerator = 1;
            long expectedDenominator = 8;

            Rational<long> a = new Rational<long>(aNumerator, aDenominator);
            Rational<long> b = new Rational<long>(bNumerator, bDenominator);
            Rational<long> result = a * b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Subtract_BigInteger_001()
        {
            BigInteger aNumerator = 1;
            BigInteger aDenominator = 3;
            BigInteger bNumerator = 1;
            BigInteger bDenominator = 4;
            BigInteger expectedNumerator = 1;
            BigInteger expectedDenominator = 12;

            Rational<BigInteger> a = new Rational<BigInteger>(aNumerator, aDenominator);
            Rational<BigInteger> b = new Rational<BigInteger>(bNumerator, bDenominator);
            Rational<BigInteger> result = a - b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Subtract_BigInteger_002()
        {
            BigInteger aNumerator = 63;
            BigInteger aDenominator = 4;
            BigInteger bNumerator = 53;
            BigInteger bDenominator = 6;
            BigInteger expectedNumerator = 83;
            BigInteger expectedDenominator = 12;

            Rational<BigInteger> a = new Rational<BigInteger>(aNumerator, aDenominator);
            Rational<BigInteger> b = new Rational<BigInteger>(bNumerator, bDenominator);
            Rational<BigInteger> result = a - b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Subtract_Int32_001()
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
        public void Subtract_Int32_002()
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

        [TestMethod]
        public void Subtract_Int64_001()
        {
            long aNumerator = 1;
            long aDenominator = 3;
            long bNumerator = 1;
            long bDenominator = 4;
            long expectedNumerator = 1;
            long expectedDenominator = 12;

            Rational<long> a = new Rational<long>(aNumerator, aDenominator);
            Rational<long> b = new Rational<long>(bNumerator, bDenominator);
            Rational<long> result = a - b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }

        [TestMethod]
        public void Subtract_Int64_002()
        {
            long aNumerator = 63;
            long aDenominator = 4;
            long bNumerator = 53;
            long bDenominator = 6;
            long expectedNumerator = 83;
            long expectedDenominator = 12;

            Rational<long> a = new Rational<long>(aNumerator, aDenominator);
            Rational<long> b = new Rational<long>(bNumerator, bDenominator);
            Rational<long> result = a - b;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumerator, result.Numerator);
            Assert.AreEqual(expectedDenominator, result.Denominator);
        }
    }
}
