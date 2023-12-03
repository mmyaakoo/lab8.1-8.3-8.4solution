using System;
using System.Collections.Generic;
using Newtonsoft.Json;




// Client: Data Conversion Application
class Program
{
    static void Main()
    {
        // User selects the format of source data (JSON, CSV)
        Console.WriteLine("Choose the source data format (1 - JSON, 2 - CSV):");
        int sourceChoice = int.Parse(Console.ReadLine());

        // User selects the format of target data (JSON, CSV)
        Console.WriteLine("Choose the target data format (1 - JSON, 2 - CSV):");
        int targetChoice = int.Parse(Console.ReadLine());

        // Sample data
        string jsonData = "{\"Name\":\"John\",\"Age\":\"25\",\"City\":\"ExampleCity\"}";
        CsvDataTemplate csvDataTemplate = new CsvDataTemplate();
        csvDataTemplate.SetData("Name", "John");
        csvDataTemplate.SetData("Age", "25");
        csvDataTemplate.SetData("City", "ExampleCity");

        // Create an appropriate adapter based on user choices
        IDataConversion sourceDataTemplate = sourceChoice == 1
            ? new JsonToCsvAdapter(jsonData)
            : csvDataTemplate;

        IDataConversion targetDataTemplate = targetChoice == 1
            ? new JsonToCsvAdapter(jsonData)
            : csvDataTemplate;

        // Perform data transformation
        Console.WriteLine("Data Transformation Result:");
        Console.WriteLine($"Source Data Format: {sourceChoice}");
        Console.WriteLine($"Target Data Format: {targetChoice}");
        Console.WriteLine();

        // Demonstrate data transformation
        PerformDataTransformation(sourceDataTemplate, targetDataTemplate);
    }

    static void PerformDataTransformation(IDataConversion source, IDataConversion target)
    {
        // Clone the source data to avoid modifying the original template
        IDataConversion sourceClone = source.Clone();

        // Demonstrate the transformation by setting and getting data
        target.SetData("NewKey", "NewValue");
        Console.WriteLine($"Setting 'NewKey' in Target Template");
        Console.WriteLine($"Result in Source Template: {sourceClone.GetData("NewKey")}");
        Console.WriteLine($"Result in Target Template: {target.GetData("NewKey")}");
    }
}
