using Narumikazuchi.Math.Formatters;

namespace Formatters;

[TestClass]
public sealed class A_5_adic_floating_point_formatter
{
    [TestClass]
    public sealed class will_represent_a_16_bit_floating_point_as_a_base_5_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_floating_point_is_negative()
            {
                IFloatingPointFormatter<Half> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan((Half)(-42.69f), 4);
                Assert.AreEqual("-132.3204", value.ToString());
            }

            [TestMethod]
            public void when_the_floating_point_is_zero()
            {
                IFloatingPointFormatter<Half> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan((Half)0f, 4);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_floating_point_is_positive()
            {
                IFloatingPointFormatter<Half> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan((Half)42.69f, 4);
                Assert.AreEqual("132.3204", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_floating_point_is_negative()
            {
                IFloatingPointFormatter<Half> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString((Half)(-42.69f), 4);
                Assert.AreEqual("-132.3204", value);
            }

            [TestMethod]
            public void when_the_floating_point_is_zero()
            {
                IFloatingPointFormatter<Half> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString((Half)0f, 4);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_floating_point_is_positive()
            {
                IFloatingPointFormatter<Half> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString((Half)42.69f, 4);
                Assert.AreEqual("132.3204", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_32_bit_floating_point_as_a_base_5_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_floating_point_is_negative()
            {
                IFloatingPointFormatter<Single> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42.69f, 4);
                Assert.AreEqual("-132.3211", value.ToString());
            }

            [TestMethod]
            public void when_the_floating_point_is_zero()
            {
                IFloatingPointFormatter<Single> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0f, 4);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_floating_point_is_positive()
            {
                IFloatingPointFormatter<Single> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42.69f, 4);
                Assert.AreEqual("132.3211", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_floating_point_is_negative()
            {
                IFloatingPointFormatter<Single> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString(-42.69f, 4);
                Assert.AreEqual("-132.3211", value);
            }

            [TestMethod]
            public void when_the_floating_point_is_zero()
            {
                IFloatingPointFormatter<Single> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString(0f, 4);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_floating_point_is_positive()
            {
                IFloatingPointFormatter<Single> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString(42.69f, 4);
                Assert.AreEqual("132.3211", value);
            }
        }
    }

    [TestClass]
    public sealed class will_represent_a_64_bit_floating_point_as_a_base_5_number
    {
        [TestClass]
        public sealed class as_readonly_span
        {
            [TestMethod]
            public void when_the_floating_point_is_negative()
            {
                IFloatingPointFormatter<Double> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(-42.69d, 4);
                Assert.AreEqual("-132.3211", value.ToString());
            }

            [TestMethod]
            public void when_the_floating_point_is_zero()
            {
                IFloatingPointFormatter<Double> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(0d, 4);
                Assert.AreEqual("0", value.ToString());
            }

            [TestMethod]
            public void when_the_floating_point_is_positive()
            {
                IFloatingPointFormatter<Double> formatter = new FiveAdicFloatingPointFormatter();
                ReadOnlySpan<Char> value = formatter.FormatToSpan(42.69d, 4);
                Assert.AreEqual("132.3211", value.ToString());
            }
        }

        [TestClass]
        public sealed class as_string
        {
            [TestMethod]
            public void when_the_floating_point_is_negative()
            {
                IFloatingPointFormatter<Double> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString(-42.69d, 4);
                Assert.AreEqual("-132.3211", value);
            }

            [TestMethod]
            public void when_the_floating_point_is_zero()
            {
                IFloatingPointFormatter<Double> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString(0d, 4);
                Assert.AreEqual("0", value);
            }

            [TestMethod]
            public void when_the_floating_point_is_positive()
            {
                IFloatingPointFormatter<Double> formatter = new FiveAdicFloatingPointFormatter();
                String value = formatter.FormatToString(42.69d, 4);
                Assert.AreEqual("132.3211", value);
            }
        }
    }
}