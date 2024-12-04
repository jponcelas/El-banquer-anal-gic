namespace bancanalogic;

public class Client
{

    public Client(string nomClient)
    {
        nom = nomClient;
        saldo = 0;
    }
    public string nom { get; set; } 
    public int saldo { get; set; }
}