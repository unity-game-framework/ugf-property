namespace UGF.Property.Runtime
{
    public interface IProperty
    {
        bool CanRead { get; }
        bool CanWrite { get; }

        event PropertyHandler Changed;

        object GetValue();
        void SetValue(object value);
    }
}
