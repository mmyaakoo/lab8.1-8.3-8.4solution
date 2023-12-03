// Prototype: Data Template
public interface IDataConversion
{
    void SetData(string key, string value);
    string GetData(string key);
    IDataConversion Clone();
}
