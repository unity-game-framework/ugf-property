using System;
using System.Collections.Generic;

namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a property with specified target, getter and setter.
    /// </summary>
    public class PropertyTarget<TTarget, TValue> : Property<TValue>
    {
        /// <summary>
        /// Gets target used to get and set value.
        /// </summary>
        public TTarget Target { get; }

        /// <summary>
        /// Gets the getter of the property, if specified.
        /// </summary>
        public PropertyTargetGetterHandler<TTarget, TValue> Getter { get { return m_getter ?? throw new InvalidOperationException("The property getter not specified."); } }

        /// <summary>
        /// Gets the setter of the property, if specified.
        /// </summary>
        public PropertyTargetSetterHandler<TTarget, TValue> Setter { get { return m_setter ?? throw new InvalidOperationException("The property setter not specified."); } }

        public override bool CanRead { get { return m_getter != null; } }
        public override bool CanWrite { get { return m_setter != null; } }

        private readonly PropertyTargetGetterHandler<TTarget, TValue> m_getter;
        private readonly PropertyTargetSetterHandler<TTarget, TValue> m_setter;

        public PropertyTarget(TTarget target, PropertyTargetSetterHandler<TTarget, TValue> setter) : this(target)
        {
            m_setter = setter;
        }

        public PropertyTarget(TTarget target, PropertyTargetGetterHandler<TTarget, TValue> getter) : this(target)
        {
            m_getter = getter;
        }

        public PropertyTarget(TTarget target, PropertyTargetGetterHandler<TTarget, TValue> getter, PropertyTargetSetterHandler<TTarget, TValue> setter) : this(target)
        {
            m_getter = getter ?? throw new ArgumentNullException(nameof(getter));
            m_setter = setter ?? throw new ArgumentNullException(nameof(setter));
        }

        private PropertyTarget(TTarget target)
        {
            if (typeof(TTarget).IsClass && EqualityComparer<TTarget>.Default.Equals(target, default)) throw new ArgumentNullException(nameof(target));

            Target = target;
        }

        protected override TValue GetValueDirect()
        {
            return Getter(Target);
        }

        protected override void SetValueDirect(TValue value)
        {
            Setter(Target, value);
        }
    }
}
