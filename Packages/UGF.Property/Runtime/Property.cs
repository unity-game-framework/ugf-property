using System;

namespace UGF.Property.Runtime
{
    public class Property<TValue> : PropertyBase<TValue>
    {
        public PropertyGetterHandler<TValue> Getter { get; }
        public PropertySetterHandler<TValue> Setter { get; }
        public override bool CanRead { get { return Getter != null; } }
        public override bool CanWrite { get { return Setter != null; } }

        public Property(PropertyGetterHandler<TValue> getter = null, PropertySetterHandler<TValue> setter = null)
        {
            Getter = getter;
            Setter = setter;
        }

        protected override TValue GetValueDirect()
        {
            if (Getter == null) throw new InvalidOperationException("The property can't be read.");

            return Getter();
        }

        protected override void SetValueDirect(TValue value)
        {
            if (Setter == null) throw new InvalidOperationException("The property can't be write.");

            Setter(value);
        }
    }
}
