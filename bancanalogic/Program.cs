namespace bancanalogic;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new banquer();
        
        banquer.CrearClient("Marc");
        
        
        Console.WriteLine(banquer.PosarDiners("Marc", 100));
        Console.WriteLine(banquer.TreureDiners("Marc", 200));
        Console.WriteLine(banquer.TreureDiners("Marc", 10));

        Console.WriteLine(banquer.TreureDiners("Manel", 20));
        banquer.CrearClient("Manel");
        Console.WriteLine(banquer.PosarDiners("Manel", 5));
        
    }
}