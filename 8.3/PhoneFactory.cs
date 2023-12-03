// Concrete factory implementations
public class PhoneFactory : ITechnologicalProductFactory
{
    public IScreen CreateScreen()
    {
        return new PhoneScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new PhoneProcessor();
    }

    public ICamera CreateCamera()
    {
        return new PhoneCamera();
    }
}

public class LaptopFactory : ITechnologicalProductFactory
{
    public IScreen CreateScreen()
    {
        return new LaptopScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new LaptopProcessor();
    }

    public ICamera CreateCamera()
    {
        return new LaptopCamera();
    }
}

public class TabletFactory : ITechnologicalProductFactory
{
    public IScreen CreateScreen()
    {
        return new TabletScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new TabletProcessor();
    }

    public ICamera CreateCamera()
    {
        return new TabletCamera();
    }
}
