using NUnit.Framework;

namespace UGF.Property.Runtime.Tests
{
    public class TestProperty
    {
        [Test]
        public void Value()
        {
            var property = new PropertyValue<int>();
            bool changedInvoked = false;
            bool changedValueInvoked = false;

            property.Changed += property1 => { changedInvoked = true; };
            property.ValueChanged += (property1, previous, current) => { changedValueInvoked = true; };
            property.Value = 10;

            Assert.AreEqual(10, property.Value);
            Assert.True(changedInvoked);
            Assert.True(changedValueInvoked);
        }

        [Test]
        public void GetValue()
        {
            var property = new PropertyValue<int>();

            Assert.AreEqual(0, property.GetValue());
        }

        [Test]
        public void SetValue()
        {
            var property = new PropertyValue<int>();

            property.SetValue(15);

            Assert.AreEqual(15, property.Value);
        }

        [Test]
        public void ImplicitConvertToValue()
        {
            var property = new PropertyValue<int>();

            property.Value = 15;

            int value = property;

            Assert.AreEqual(15, value);
        }
    }
}
