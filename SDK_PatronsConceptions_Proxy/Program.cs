IImage image1 = new ProxyImage("image1.jpg");
IImage image2 = new ProxyImage("image2.jpg");

image1.Display(); // The real image will be loaded and displayed
image1.Display(); // The real image will be displayed directly (no reload)
image2.Display(); // The real image will be loaded and displayed

// Subject
interface IImage
{
    void Display();
}

// Real Subject
class RealImage : IImage
{
    private string filename;

    public RealImage(string filename)
    {
        this.filename = filename;
        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        Console.WriteLine($"Loading image: {filename}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {filename}");
    }
}

// Proxy
class ProxyImage : IImage
{
    private RealImage realImage;
    private string filename;

    public ProxyImage(string filename)
    {
        this.filename = filename;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(filename);
        }
        realImage.Display();
    }
}