using System;

namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a property with specified getter and setter.
    /// </summary>
    public class PropertyHandle<TValue> : Property<TValue>
    {
        /// <summary>
        /// Gets the getter of the property, if specified.
        /// </summary>
        public PropertyGetterHandler<TValue> Getter { get { return m_getter ?? throw new InvalidOperationException("The property getter not specified."); } }

        /// <summary>
        /// Gets the setter of the property, if specified.
        /// </summary>
        public PropertySetterHandler<TValue> Setter { get { return m_setter ?? throw new InvalidOperationException("The property setter not specified."); } }

        public override bool CanRead { get { return m_getter != null; } }
        public override bool CanWrite { get { return m_setter != null; } }

        private readonly PropertyGetterHandler<TValue> m_getter;
        private readonly PropertySetterHandler<TValue> m_setter;

        public PropertyHandle(PropertyGetterHandler<TValue> getter)
        {
            m_getter = getter ?? throw new ArgumentNullException(nameof(getter));
        }

        public PropertyHandle(PropertySetterHandler<TValue> setter)
        {
            m_setter = setter ?? throw new ArgumentNullException(nameof(setter));
        }

        public PropertyHandle(PropertyGetterHandler<TValue> getter, PropertySetterHandler<TValue> setter)
        {
            m_getter = getter ?? throw new ArgumentNullException(nameof(getter));
            m_setter = setter ?? throw new ArgumentNullException(nameof(setter));
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
