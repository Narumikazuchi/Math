using Narumikazuchi.Math.Formatters;

namespace Formatters;

[TestClass]
public sealed class A_roman_integer_formatter
{
    [TestClass]
    public sealed class will_represent_an_unsigned_8_bit_integer_as_a_roman_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Byte.MinValue);
                Assert.AreEqual("NULLA", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("NULLA", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("XLII", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Byte.MaxValue);
                Assert.AreEqual("CCLV", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(Byte.MinValue);
                Assert.AreEqual("NULLA", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("NULLA", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("XLII", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Byte> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(Byte.MaxValue);
                Assert.AreEqual("CCLV", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_16_bit_integer_as_a_roman_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt16.MinValue);
                Assert.AreEqual("NULLA", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("NULLA", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("XLII", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt16.MaxValue);
                Assert.AreEqual("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMDXXXV", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(UInt16.MinValue);
                Assert.AreEqual("NULLA", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("NULLA", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("XLII", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt16> formatter = new RomanIntegerFormatter();
                String value = formatter.FormatToString(UInt16.MaxValue);
                Assert.AreEqual("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMDXXXV", value);
            }
        }
    }
}