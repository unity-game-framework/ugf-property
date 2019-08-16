namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents an abstract implementation of property with explicit value type.
    /// </summary>
    public abstract class PropertyBase<TValue> : IProperty<TValue>
    {
        public TValue Value
        {
            get
            {
                TValue current = GetValueDirect();

                return current;
            }
            set
            {
                TValue current = GetValueDirect();

                SetValueDirect(value);

                Changed?.Invoke(this);
                ValueChanged?.Invoke(this, current, value);
            }
        }

        public abstract bool CanRead { get; }
        public abstract bool CanWrite { get; }

        public event PropertyHandler Changed;
        public event PropertyChangeHandler<TValue> ValueChanged;

        public object GetValue()
        {
            return Value;
        }

        public void SetValue(object value)
        {
            Value = (TValue)value;
        }

        /// <summary>
        /// Gets value directly.
        /// </summary>
        protected abstract TValue GetValueDirect();

        /// <summary>
        /// Sets value directly.
        /// </summary>
        /// <param name="value">The value to set.</param>
        protected abstract void SetValueDirect(TValue value);

        public static implicit operator TValue(PropertyBase<TValue> property)
        {
            return property.Value;
        }

        public override string ToString()
        {
            return CanRead ? Value.ToString() : base.ToString();
        }
    }
}
