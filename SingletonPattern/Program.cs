class Program
{
    static void Main()
    {
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;
        
        logger1.Log("First message");
        logger2.Log("Second message");
        
        Console.WriteLine($"Same instance? {ReferenceEquals(logger1, logger2)}");
    }
}