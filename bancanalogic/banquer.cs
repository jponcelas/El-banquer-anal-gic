namespace bancanalogic;

public class banquer
{

    private Dictionary<string, Client> clients;
    
    
    private Client client;

    public banquer()
    {
        clients = new Dictionary<string, Client>();
    }

    public void CrearClient(string nomClient)
    {
        if (clients.ContainsKey(nomClient))
        {
            Console.WriteLine("El client " + nomClient +  " ja existeix.");
            return;
        }
        clients.Add(nomClient, new Client(nomClient));
        Console.WriteLine("Client " + nomClient  + " creat amb èxit.");
    }
    
    
    public string PosarDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            client.saldo += quantitat;
            return nomClient + " ha ingresat " + quantitat + "€.";
        }
        
        return "El client "  + nomClient + " no existeix.";
    }

    public string TreureDiners(string nomClient,int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = (int)quantitat / 100;
            if (quantitat > client.saldo)
            {
                return nomClient + ": No tens prous diners.";
            }
            client.saldo -= quantitat - comissio;
            return nomClient + ": Has retirat" + quantitat + "€. Et queda" + client.saldo + "€.";
        }
        return "El client" + nomClient + " no existeix.";
        
    }
    public string ConsultarSaldo(string nomClient)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            return nomClient + " té un saldo de " + client.saldo + "€.";
        }

        return "El client" + nomClient + "no existeix.";
    }
    
}