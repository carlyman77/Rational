using System;
using System.Diagnostics.CodeAnalysis;

namespace Numerics
{
    public class Rational<T> : IEquatable<T>, IComparable
    {
        public Rational()
            : this(DefaultPrecision)
        {
        }

        public Rational(int precision)
        {
            _precision = precision;
        }

        public Rational(T numerator)
            : this (numerator, DefaultPrecision)
        {
        }

        public Rational(T numerator, int precision)
            : this(numerator, 1, precision)
        {
        }

        public Rational(T numerator, T denominator)
            : this (numerator, denominator, DefaultPrecision)
        {
        }

        public Rational(T numerator, T denominator, int precision)
            : this(precision)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        private T _denominator;
        private T _numerator;
        private readonly int _precision;

        public const int DefaultPrecision = 50;

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

        public int Precision
        {
            get
            {
                return _precision;
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if ((ReferenceEquals(this, obj) == false) && (ReferenceEquals(obj, null) == true))
            {
            }

            return equals;
        }

        public bool Equals([AllowNull] T other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static Rational<T> Parse(string value)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
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
    }
}
