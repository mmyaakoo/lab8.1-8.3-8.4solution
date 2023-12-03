using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Demonstration of Singleton ConfigurationManager

        // Access the ConfigurationManager instance
        ConfigurationManager configManager = ConfigurationManager.Instance;

        // Set and display configuration settings
        configManager.SetSetting("LogLevel", "Info");
        configManager.SetSetting("DatabaseConnection", "ConnectionString123");
        configManager.DisplaySettings();

        // Access the same ConfigurationManager instance from another part of the program
        ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;

        // Display the configuration settings to show that changes are reflected in the same instance
        anotherConfigManager.DisplaySettings();
    }
}
