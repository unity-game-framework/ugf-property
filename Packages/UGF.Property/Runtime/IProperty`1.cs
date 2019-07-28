namespace UGF.Property.Runtime
{
    public interface IProperty<TValue> : IProperty
    {
        TValue Value { get; set; }

        event PropertyChangeHandler<TValue> ValueChanged;
    }
}
