// Adapter: Json to CSV Adapter
using Newtonsoft.Json;

public class JsonToCsvAdapter : IDataConversion
{
    private CsvDataTemplate csvTemplate;

    public JsonToCsvAdapter(string jsonData)
    {
        // Convert JSON to CSV format (for simplicity, just extract keys and values)
        var jsonDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);
        csvTemplate = new CsvDataTemplate();

        foreach (var entry in jsonDict)
        {
            csvTemplate.SetData(entry.Key, entry.Value);
        }
    }

    public void SetData(string key, string value)
    {
        csvTemplate.SetData(key, value);
    }

    public string GetData(string key)
    {
        return csvTemplate.GetData(key);
    }

    public IDataConversion Clone()
    {
        return new JsonToCsvAdapter(JsonConvert.SerializeObject(csvTemplate));
    }
}
