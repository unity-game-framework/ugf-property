namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a property with explicit value type.
    /// </summary>
    public interface IProperty<TValue> : IProperty
    {
        /// <summary>
        /// Gets or sets a value of the property.
        /// </summary>
        TValue Value { get; set; }

        /// <summary>
        /// Occurs when value of the property changes.
        /// </summary>
        event PropertyChangeHandler<TValue> ValueChanged;
    }
}
