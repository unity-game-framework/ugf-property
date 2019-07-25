namespace UGF.Property.Runtime
{
    public interface IProperty<TValue> : IProperty
    {
        TValue Value { get; set; }

        event PropertyGetterHandler<TValue> ValueGetter;
        event PropertySetterHandler<TValue> ValueSetter;
        event PropertyChangeHandler<TValue> ValueChanged;
    }
}
