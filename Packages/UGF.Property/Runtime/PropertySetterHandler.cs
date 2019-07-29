namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a delegate to handle property value setter.
    /// </summary>
    /// <param name="value">The value to set.</param>
    public delegate void PropertySetterHandler<in TValue>(TValue value);
}
