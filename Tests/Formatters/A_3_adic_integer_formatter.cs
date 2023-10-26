using Narumikazuchi.Math.Formatters;

namespace Formatters;

[TestClass]
public sealed class A_3_adic_integer_formatter
{
    [TestClass]
    public sealed class will_represent_a_signed_8_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(SByte.MinValue);
                Assert.AreEqual("-11202", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42);
                Assert.AreEqual("-1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(SByte.MaxValue);
                Assert.AreEqual("11201", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(SByte.MinValue);
                Assert.AreEqual("-11202", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(-42);
                Assert.AreEqual("-1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<SByte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(SByte.MaxValue);
                Assert.AreEqual("11201", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_8_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Byte.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Byte.MaxValue);
                Assert.AreEqual("100110", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Byte.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Byte> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Byte.MaxValue);
                Assert.AreEqual("100110", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_signed_16_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int16.MinValue);
                Assert.AreEqual("-1122221122", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42);
                Assert.AreEqual("-1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int16.MaxValue);
                Assert.AreEqual("1122221121", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Int16.MinValue);
                Assert.AreEqual("-1122221122", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(-42);
                Assert.AreEqual("-1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Int16.MaxValue);
                Assert.AreEqual("1122221121", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_16_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt16.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt16.MaxValue);
                Assert.AreEqual("10022220020", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt16.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt16> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt16.MaxValue);
                Assert.AreEqual("10022220020", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_signed_32_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int32.MinValue);
                Assert.AreEqual("-12112122212110202102", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42);
                Assert.AreEqual("-1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int32.MaxValue);
                Assert.AreEqual("12112122212110202101", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Int32.MinValue);
                Assert.AreEqual("-12112122212110202102", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(-42);
                Assert.AreEqual("-1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Int32.MaxValue);
                Assert.AreEqual("12112122212110202101", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_32_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt32.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0U);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42U);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt32.MaxValue);
                Assert.AreEqual("102002022201221111210", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt32.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0U);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42U);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt32> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt32.MaxValue);
                Assert.AreEqual("102002022201221111210", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_signed_64_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int64.MinValue);
                Assert.AreEqual("-2021110011022210012102010021220101220222", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42L);
                Assert.AreEqual("-1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0L);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42L);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(Int64.MaxValue);
                Assert.AreEqual("2021110011022210012102010021220101220221", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Int64.MinValue);
                Assert.AreEqual("-2021110011022210012102010021220101220222", value);
            }

            [TestMethod]
            public void when_the_integer_is_negative()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(-42L);
                Assert.AreEqual("-1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0L);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42L);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<Int64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(Int64.MaxValue);
                Assert.AreEqual("2021110011022210012102010021220101220221", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_an_unsigned_64_bit_integer_as_a_base_3_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt64.MinValue);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0UL);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42UL);
                Assert.AreEqual("1120", value.ToString());
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(UInt64.MaxValue);
                Assert.AreEqual("11112220022122120101211020120210210211220", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_integer_is_its_minimum()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt64.MinValue);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_zero()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(0UL);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_integer_is_positive()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(42UL);
                Assert.AreEqual("1120", value);
            }

            [TestMethod]
            public void when_the_integer_is_its_maximum()
            {
                IIntegerFormatter<UInt64> formatter = new ThreeAdicIntegerFormatter();
                String value = formatter.FormatToString(UInt64.MaxValue);
                Assert.AreEqual("11112220022122120101211020120210210211220", value);
            }
        }
    }
}