namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a delegate to handle property value setter to specific target.
    /// </summary>
    /// <param name="target">The target to set value to.</param>
    /// <param name="value">The value to set.</param>
    public delegate void PropertyTargetSetterHandler<in TTarget, in TValue>(TTarget target, TValue value);
}
