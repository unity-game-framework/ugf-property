using System;

namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a property with value.
    /// </summary>
    public class PropertyValue<TValue> : Property<TValue>
    {
        public override bool CanRead { get; }
        public override bool CanWrite { get; }

        private TValue m_value;

        public PropertyValue(TValue value = default, PropertyValueAccess access = PropertyValueAccess.All)
        {
            m_value = value;

            CanRead = access == PropertyValueAccess.All || access == PropertyValueAccess.ReadOnly;
            CanWrite = access == PropertyValueAccess.All || access == PropertyValueAccess.WriteOnly;
        }

        protected override TValue GetValueDirect()
        {
            return CanRead ? m_value : throw new InvalidOperationException("Property can not be read.");
        }

        protected override void SetValueDirect(TValue value)
        {
            m_value = CanWrite ? value : throw new InvalidOperationException("Property can not be written.");
        }
    }
}
