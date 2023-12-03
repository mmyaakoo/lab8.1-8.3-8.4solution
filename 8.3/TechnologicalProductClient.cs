// Client class
public class TechnologicalProductClient
{
    private ITechnologicalProductFactory factory;

    public TechnologicalProductClient(ITechnologicalProductFactory factory)
    {
        this.factory = factory;
    }

    public void AssembleProduct()
    {
        IScreen screen = factory.CreateScreen();
        IProcessor processor = factory.CreateProcessor();
        ICamera camera = factory.CreateCamera();

        Console.WriteLine($"Assembled Product: {screen.GetDescription()}, {processor.GetDescription()}, {camera.GetDescription()}");
    }
}