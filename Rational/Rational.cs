#region Using References

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;

using Maths = System.Math;

#endregion

namespace Numerics
{
    public class Rational<T> where T : struct, IEquatable<T>, IComparable
    {
        public Rational(T numerator, T denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        private T _denominator;
        private T _numerator;

        public T Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                _denominator = value;
            }
        }

        public T Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }

        private static Rational<BigInteger> Add(Rational<BigInteger> a, Rational<BigInteger> b)
        {
            BigInteger numerator = (a.Numerator * b.Denominator) + (a.Denominator * b.Numerator);
            BigInteger denominator = (a.Denominator * b.Denominator);

            return Simplify(new Rational<BigInteger>(numerator, denominator));
        }

        private static Rational<int> Add(Rational<int> a, Rational<int> b)
        {
            int numerator = (a.Numerator * b.Denominator) + (a.Denominator * b.Numerator);
            int denominator = (a.Denominator * b.Denominator);

            return Simplify(new Rational<int>(numerator, denominator));
        }

        private static Rational<long> Add(Rational<long> a, Rational<long> b)
        {
            long numerator = (a.Numerator * b.Denominator) + (a.Denominator * b.Numerator);
            long denominator = (a.Denominator * b.Denominator);

            return Simplify(new Rational<long>(numerator, denominator));
        }

        public int CompareTo(object value)
        {
            throw new NotImplementedException();
        }

        private static Rational<BigInteger> Divide(Rational<BigInteger> a, Rational<BigInteger> b)
        {
            return Simplify(Multiply(a, new Rational<BigInteger>(b.Denominator, b.Numerator)));
        }

        private static Rational<int> Divide(Rational<int> a, Rational<int> b)
        {
            return Simplify(Multiply(a, new Rational<int>(b.Denominator, b.Numerator)));
        }

        private static Rational<long> Divide(Rational<long> a, Rational<long> b)
        {
            return Simplify(Multiply(a, new Rational<long>(b.Denominator, b.Numerator)));
        }

        public override bool Equals(object value)
        {
            bool equals = false;

            if ((ReferenceEquals(this, value) == false) && (ReferenceEquals(value, null) == true))
            {
                Rational<T> rationalValue = value as Rational<T>;

                if (rationalValue != null)
                {
                    equals =
                    (
                        (_denominator.Equals(rationalValue._denominator) == true) &&
                        (_numerator.Equals(rationalValue._numerator) == true)
                    );
                }
            }

            return equals;
        }

        public bool Equals([AllowNull] T value)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return _numerator.GetHashCode() ^ _denominator.GetHashCode();
        }

        public static Rational<T> FromDecimal()
        {
            throw new NotImplementedException();
        }

        public static Rational<T> FromDouble()
        {
            throw new NotImplementedException();
        }

        public static int GetHighestCommonFactor(int a, int b)
        {
            int highestCommonFactor = 0;

            if (b == 0)
            {
                highestCommonFactor = a;
            }
            else
            {
                int value = a % b;

                highestCommonFactor = GetHighestCommonFactor(b, value);
            }

            return highestCommonFactor;
        }

        public static long GetHighestCommonFactor(long a, long b)
        {
            long highestCommonFactor = 0;

            if (b == 0)
            {
                highestCommonFactor = a;
            }
            else
            {
                long value = a % b;

                highestCommonFactor = GetHighestCommonFactor(b, value);
            }

            return highestCommonFactor;
        }

        private static Rational<BigInteger> Multiply(Rational<BigInteger> a, Rational<BigInteger> b)
        {
            BigInteger numerator = (a.Numerator * b.Numerator);
            BigInteger denominator = (a.Denominator * b.Denominator);

            return new Rational<BigInteger>(numerator, denominator);
        }

        private static Rational<int> Multiply(Rational<int> a, Rational<int> b)
        {
            int numerator = (a.Numerator * b.Numerator);
            int denominator = (a.Denominator * b.Denominator);

            return new Rational<int>(numerator, denominator);
        }

        private static Rational<long> Multiply(Rational<long> a, Rational<long> b)
        {
            long numerator = (a.Numerator * b.Numerator);
            long denominator = (a.Denominator * b.Denominator);

            return new Rational<long>(numerator, denominator);
        }

        public static Rational<T> Parse(string value)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> Simplify(Rational<T> rational)
        {
            Rational<T> simplify = null;

            if ((typeof(int).IsAssignableFrom(typeof(T))) == true)
            {
                simplify = Simplify(rational as Rational<Int32>) as Rational<T>;
            }

            if ((typeof(long).IsAssignableFrom(typeof(T))) == true)
            {
                simplify = Simplify(rational as Rational<Int64>) as Rational<T>;
            }

            return simplify;
        }

        public static Rational<BigInteger> Simplify(Rational<BigInteger> rational)
        {
            BigInteger numerator = rational.Numerator;
            BigInteger denominator = rational.Denominator;
            BigInteger factor = BigInteger.GreatestCommonDivisor(numerator, denominator);

            numerator /= factor;
            denominator /= factor;

            return new Rational<BigInteger>(numerator, denominator);
        }

        public static Rational<int> Simplify(Rational<int> rational)
        {
            int numerator = rational.Numerator;
            int denominator = rational.Denominator;
            int factor = GetHighestCommonFactor(numerator, denominator);

            numerator /= factor;
            denominator /= factor;

            return new Rational<int>(numerator, denominator);
        }

        public static Rational<long> Simplify(Rational<long> rational)
        {
            long numerator = rational.Numerator;
            long denominator = rational.Denominator;
            long factor = GetHighestCommonFactor(numerator, denominator);

            numerator /= factor;
            denominator /= factor;

            return new Rational<long>(numerator, denominator);
        }

        private static Rational<BigInteger> Subtract(Rational<BigInteger> a, Rational<BigInteger> b)
        {
            BigInteger numerator = ((a.Numerator * b.Denominator) - (b.Numerator * a.Denominator));
            BigInteger denominator = (a.Denominator * b.Denominator);

            return Simplify(new Rational<BigInteger>(numerator, denominator));
        }

        private static Rational<int> Subtract(Rational<int> a, Rational<int> b)
        {
            int numerator = ((a.Numerator * b.Denominator) - (b.Numerator * a.Denominator));
            int denominator = (a.Denominator * b.Denominator);

            return Simplify(new Rational<int>(numerator, denominator));
        }

        private static Rational<long> Subtract(Rational<long> a, Rational<long> b)
        {
            long numerator = ((a.Numerator * b.Denominator) - (b.Numerator * a.Denominator));
            long denominator = (a.Denominator * b.Denominator);

            return Simplify(new Rational<long>(numerator, denominator));
        }

        public override string ToString()
        {
            return $"({_numerator} / {_denominator})";
        }

        public static bool TryParse(string value, out Rational<T> result)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Rational<T> left, Rational<T> right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Rational<T> left, Rational<T> right)
        {
            return !(left == right);
        }

        public static bool operator <(Rational<T> left, Rational<T> right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Rational<T> left, Rational<T> right)
        {
            return (ReferenceEquals(left, null) || left.CompareTo(right) <= 0);
        }

        public static bool operator >(Rational<T> left, Rational<T> right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Rational<T> left, Rational<T> right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }

        public static Rational<T> operator *(Rational<T> left, Rational<T> right)
        {
            Rational<T> rational = default;

            if ((typeof(BigInteger).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Multiply((left as Rational<BigInteger>), (right as Rational<BigInteger>)) as Rational<T>;
            }

            if ((typeof(int).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Multiply((left as Rational<int>), (right as Rational<int>)) as Rational<T>;
            }

            if ((typeof(long).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Multiply((left as Rational<long>), (right as Rational<long>)) as Rational<T>;
            }

            return rational;
        }

        public static Rational<T> operator /(Rational<T> left, Rational<T> right)
        {
            Rational<T> rational = default;

            if ((typeof(BigInteger).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Divide((left as Rational<BigInteger>), (right as Rational<BigInteger>)) as Rational<T>;
            }

            if ((typeof(int).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Divide((left as Rational<int>), (right as Rational<int>)) as Rational<T>;
            }

            if ((typeof(long).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Divide((left as Rational<long>), (right as Rational<long>)) as Rational<T>;
            }

            return rational;
        }

        public static Rational<T> operator %(Rational<T> left, Rational<T> right)
        {
            throw new NotImplementedException();
        }

        public static Rational<T> operator +(Rational<T> left, Rational<T> right)
        {
            Rational<T> rational = default;

            if ((typeof(BigInteger).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Add((left as Rational<BigInteger>), (right as Rational<BigInteger>)) as Rational<T>;
            }

            if ((typeof(int).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Add((left as Rational<int>), (right as Rational<int>)) as Rational<T>;
            }

            if ((typeof(long).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Add((left as Rational<long>), (right as Rational<long>)) as Rational<T>;
            }

            return rational;
        }

        public static Rational<T> operator -(Rational<T> left, Rational<T> right)
        {
            Rational<T> rational = default;

            if ((typeof(BigInteger).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Subtract((left as Rational<BigInteger>), (right as Rational<BigInteger>)) as Rational<T>;
            }

            if ((typeof(int).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Subtract((left as Rational<int>), (right as Rational<int>)) as Rational<T>;
            }

            if ((typeof(long).IsAssignableFrom(typeof(T))) == true)
            {
                rational = Subtract((left as Rational<long>), (right as Rational<long>)) as Rational<T>;
            }

            return rational;
        }
    }
}
