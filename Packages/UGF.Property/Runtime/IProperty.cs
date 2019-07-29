namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a property.
    /// </summary>
    public interface IProperty
    {
        /// <summary>
        /// Gets a value that determines whether this property can be read.
        /// </summary>
        bool CanRead { get; }

        /// <summary>
        /// Gets a value that determines whether this property can be written.
        /// </summary>
        bool CanWrite { get; }

        /// <summary>
        /// Occurs when property changes.
        /// </summary>
        event PropertyHandler Changed;

        /// <summary>
        /// Gets a value from property.
        /// </summary>
        object GetValue();

        /// <summary>
        /// Sets a value to property.
        /// </summary>
        /// <param name="value">The value to set.</param>
        void SetValue(object value);
    }
}
