namespace UGF.Property.Runtime
{
    public delegate void PropertyChangeHandler<TValue>(IProperty<TValue> property, TValue previous, TValue current);
}
