// Singleton ConfigurationManager class
public class ConfigurationManager
{
    private static ConfigurationManager instance;
    private Dictionary<string, string> configSettings;

    // Private constructor to prevent instantiation
    private ConfigurationManager()
    {
        configSettings = new Dictionary<string, string>();
    }

    // Singleton instance property
    public static ConfigurationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
    }

    // Method to get a configuration setting by key
    public string GetSetting(string key)
    {
        if (configSettings.ContainsKey(key))
        {
            return configSettings[key];
        }
        else
        {
            return "Setting not found";
        }
    }

    // Method to set a configuration setting
    public void SetSetting(string key, string value)
    {
        configSettings[key] = value;
        Console.WriteLine($"Setting '{key}' updated to '{value}'");
    }

    // Method to display all configuration settings
    public void DisplaySettings()
    {
        Console.WriteLine("Current Configuration Settings:");
        foreach (var setting in configSettings)
        {
            Console.WriteLine($"{setting.Key}: {setting.Value}");
        }
    }
}
