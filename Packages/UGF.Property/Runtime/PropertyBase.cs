namespace UGF.Property.Runtime
{
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

        protected abstract TValue GetValueDirect();
        protected abstract void SetValueDirect(TValue value);
    }
}
