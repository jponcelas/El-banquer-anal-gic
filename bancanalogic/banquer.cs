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
        clients.Add(nomClient, new Client(nomClient));    
    }
    
    
    public string PosarDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            client.saldo += quantitat;
            return nomClient  + " ha ingresat " + quantitat + "€";
        }
        
        return "Tu no et client " + nomClient;
    }

    public string TreureDiners(string nomClient,int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = (int)quantitat / 100;
            if (quantitat > client.saldo)
            {
                return nomClient + ": No tens prous diners";
            }
            client.saldo -= quantitat - comissio;
            return nomClient + ": Tens " + quantitat + "€"  + ", et queda " + client.saldo;
        }
        return "Tu no et client " + nomClient;
        
    }
    
}