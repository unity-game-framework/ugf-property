namespace UGF.Property.Runtime
{
    public class PropertyValue<TValue> : PropertyBase<TValue>
    {
        public override bool CanRead { get; } = true;
        public override bool CanWrite { get; } = true;

        private TValue m_value;

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
