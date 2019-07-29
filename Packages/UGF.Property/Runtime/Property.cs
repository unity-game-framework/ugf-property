using System;

namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a property with specified getter and setter.
    /// </summary>
    public class Property<TValue> : PropertyBase<TValue>
    {
        /// <summary>
        /// Gets the getter of the property, if specified.
        /// </summary>
        public PropertyGetterHandler<TValue> Getter { get { return m_getter ?? throw new InvalidOperationException("The property getter not specified."); } }

        /// <summary>
        /// Gets the setter of the property, if specified.
        /// </summary>
        public PropertySetterHandler<TValue> Setter { get { return m_setter ?? throw new InvalidOperationException("The property setter not specified."); } }

        public override bool CanRead { get { return Getter != null; } }
        public override bool CanWrite { get { return Setter != null; } }

        private readonly PropertyGetterHandler<TValue> m_getter;
        private readonly PropertySetterHandler<TValue> m_setter;

        /// <summary>
        /// Creates property with specified getter and setter.
        /// </summary>
        /// <param name="getter">The getter of the property.</param>
        /// <param name="setter">The setter of the property.</param>
        public Property(PropertyGetterHandler<TValue> getter = null, PropertySetterHandler<TValue> setter = null)
        {
            m_getter = getter;
            m_setter = setter;
        }

        protected override TValue GetValueDirect()
        {
            return Getter();
        }

        protected override void SetValueDirect(TValue value)
        {
            Setter(value);
        }
    }
}
