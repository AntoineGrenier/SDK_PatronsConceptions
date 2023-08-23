// Attempting to create multiple instances of the Singleton
Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;

Console.WriteLine("Are the instances the same?");
Console.WriteLine(instance1 == instance2); // Should output: True

instance1.PrintMessage("Hello from instance 1!");
instance2.PrintMessage("Hello from instance 2!");

class Singleton
{
    private static Singleton instance;

    private Singleton() { } // Private constructor to prevent external instantiation

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine($"Singleton says: {message}");
    }
}