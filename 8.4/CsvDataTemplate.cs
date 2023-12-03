// Concrete Prototype: CSV Data Template
public class CsvDataTemplate : IDataConversion
{
    private Dictionary<string, string> data;

    public CsvDataTemplate()
    {
        data = new Dictionary<string, string>();
    }

    public void SetData(string key, string value)
    {
        data[key] = value;
    }

    public string GetData(string key)
    {
        return data.ContainsKey(key) ? data[key] : null;
    }

    public IDataConversion Clone()
    {
        CsvDataTemplate clone = new CsvDataTemplate();
        foreach (var entry in data)
        {
            clone.SetData(entry.Key, entry.Value);
        }
        return clone;
    }
}
