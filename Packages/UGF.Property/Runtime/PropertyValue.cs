namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a property with value.
    /// </summary>
    public class PropertyValue<TValue> : PropertyBase<TValue>
    {
        public override bool CanRead { get; } = true;
        public override bool CanWrite { get; } = true;

        private TValue m_value;

        /// <summary>
        /// Creates property with specified value.
        /// </summary>
        /// <param name="value">The value of the property.</param>
        public PropertyValue(TValue value)
        {
            m_value = value;
        }

        protected override TValue GetValueDirect()
        {
            return m_value;
        }

        protected override void SetValueDirect(TValue value)
        {
            m_value = value;
        }
    }
}
