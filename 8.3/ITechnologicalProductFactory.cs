// Abstract factory interface
public interface ITechnologicalProductFactory
{
    IScreen CreateScreen();
    IProcessor CreateProcessor();
    ICamera CreateCamera();
}