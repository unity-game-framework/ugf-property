namespace UGF.Property.Runtime
{
    public interface IProperty
    {
        event PropertyHandler Changed;

        object GetValue();
        void SetValue(object value);
    }
}
