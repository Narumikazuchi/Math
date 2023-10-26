using Narumikazuchi.Math.Formatters;

namespace Formatters;

[TestClass]
public sealed class A_7_adic_integer_formatter
{
    [TestClass]
    public sealed class will_represent_a_signed_8_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(SByte.MinValue);
                Assert.AreEqual("-242", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42);
                Assert.AreEqual("-60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(SByte.MaxValue);
                Assert.AreEqual("241", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(SByte.MinValue);
                Assert.AreEqual("-242", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(-42);
                Assert.AreEqual("-60", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<SByte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(SByte.MaxValue);
                Assert.AreEqual("241", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_8_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Byte.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Byte.MaxValue);
                Assert.AreEqual("513", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Byte.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Byte> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Byte.MaxValue);
                Assert.AreEqual("513", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_signed_16_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int16.MinValue);
                Assert.AreEqual("-164351", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42);
                Assert.AreEqual("-60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int16.MaxValue);
                Assert.AreEqual("164350", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Int16.MinValue);
                Assert.AreEqual("-164351", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(-42);
                Assert.AreEqual("-60", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Int16.MaxValue);
                Assert.AreEqual("164350", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_16_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt16.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt16.MaxValue);
                Assert.AreEqual("362031", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt16.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt16> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt16.MaxValue);
                Assert.AreEqual("362031", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_signed_32_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int32.MinValue);
                Assert.AreEqual("-104134211162", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42);
                Assert.AreEqual("-60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int32.MaxValue);
                Assert.AreEqual("104134211161", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Int32.MinValue);
                Assert.AreEqual("-104134211162", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(-42);
                Assert.AreEqual("-60", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Int32.MaxValue);
                Assert.AreEqual("104134211161", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_32_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt32.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0U);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42U);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt32.MaxValue);
                Assert.AreEqual("211301422353", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt32.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0U);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42U);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt32> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt32.MaxValue);
                Assert.AreEqual("211301422353", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_signed_64_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int64.MinValue);
                Assert.AreEqual("-22341010611245052052301", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42L);
                Assert.AreEqual("-60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0L);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42L);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int64.MaxValue);
                Assert.AreEqual("22341010611245052052300", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Int64.MinValue);
                Assert.AreEqual("-22341010611245052052301", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(-42L);
                Assert.AreEqual("-60", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0L);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42L);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(Int64.MaxValue);
                Assert.AreEqual("22341010611245052052300", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_64_bit_integer_as_a_base_7_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt64.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0UL);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42UL);
                Assert.AreEqual("60", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt64.MaxValue);
                Assert.AreEqual("45012021522523134134601", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt64.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(0UL);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(42UL);
                Assert.AreEqual("60", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt64> formatter = new SevenAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt64.MaxValue);
                Assert.AreEqual("45012021522523134134601", value);
            }
        }
    }
}