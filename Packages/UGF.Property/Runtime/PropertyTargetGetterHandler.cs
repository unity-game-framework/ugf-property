namespace UGF.Property.Runtime
{
    /// <summary>
    /// Represents a delegate to handle property value getter from specific target.
    /// </summary>
    /// <param name="target">The target to get value from.</param>
    public delegate TValue PropertyTargetGetterHandler<in TTarget, out TValue>(TTarget target);
}
