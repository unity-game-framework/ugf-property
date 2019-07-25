namespace UGF.Property.Runtime
{
    public delegate void PropertyChangeHandler<in TValue>(TValue previous, TValue current);
}
