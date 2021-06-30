using NUnit.Framework;

namespace UGF.Property.Runtime.Tests
{
    public class TestPropertyBase
    {
        private class Property : Property<int>
        {
            public override bool CanRead { get; } = true;
            public override bool CanWrite { get; } = true;

            private int m_value;

            protected override int GetValueDirect()
            {
                return m_value;
            }

            protected override void SetValueDirect(int value)
            {
                m_value = value;
            }
        }

        [Test]
        public void Value()
        {
            var property = new Property();
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
            var property = new Property();

            Assert.AreEqual(0, property.GetValue());
        }

        [Test]
        public void SetValue()
        {
            var property = new Property();

            property.SetValue(15);

            Assert.AreEqual(15, property.Value);
        }

        [Test]
        public void ImplicitConvertToValue()
        {
            var property = new Property();

            property.Value = 15;

            int value = property;

            Assert.AreEqual(15, value);
        }
    }
}
