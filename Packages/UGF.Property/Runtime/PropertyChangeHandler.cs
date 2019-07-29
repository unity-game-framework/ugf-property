namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a delegate to handle property value changes.
    /// </summary>
    /// <param name="property">The changed property.</param>
    /// <param name="previous">The previous value of the property.</param>
    /// <param name="current">The current value of the property.</param>
    public delegate void PropertyChangeHandler<TValue>(IProperty<TValue> property, TValue previous, TValue current);
}
