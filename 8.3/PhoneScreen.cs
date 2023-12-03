// Concrete product implementations
public class PhoneScreen : IScreen
{
    public string GetDescription()
    {
        return "Phone Screen";
    }
}

public class LaptopScreen : IScreen
{
    public string GetDescription()
    {
        return "Laptop Screen";
    }
}

public class TabletScreen : IScreen
{
    public string GetDescription()
    {
        return "Tablet Screen";
    }
}

public class PhoneProcessor : IProcessor
{
    public string GetDescription()
    {
        return "Phone Processor";
    }
}

public class LaptopProcessor : IProcessor
{
    public string GetDescription()
    {
        return "Laptop Processor";
    }
}

public class TabletProcessor : IProcessor
{
    public string GetDescription()
    {
        return "Tablet Processor";
    }
}

public class PhoneCamera : ICamera
{
    public string GetDescription()
    {
        return "Phone Camera";
    }
}

public class LaptopCamera : ICamera
{
    public string GetDescription()
    {
        return "Laptop Camera";
    }
}

public class TabletCamera : ICamera
{
    public string GetDescription()
    {
        return "Tablet Camera";
    }
}
