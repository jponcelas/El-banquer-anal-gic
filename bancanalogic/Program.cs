namespace bancanalogic;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new banquer();
        string opcio;
        
        Console.WriteLine("Benvinguts al Banc Analogic");

        do
        {
            Console.WriteLine("\nOpcions disponible en aquest banc.");
            Console.WriteLine("\n1. Crear nou client");
            Console.WriteLine("\n2. Afegir diners");
            Console.WriteLine("\n3. Retirar diners");
            Console.WriteLine("\n4. Gestionar diners");
            Console.WriteLine("\n5. Salir");
            Console.WriteLine("Tria una opció:");
            opcio = Console.ReadLine();

            switch (opcio)
            {
                case "1":
                    Console.WriteLine("Escriu el nou usuari que vols afegir");
                    string nouClient = Console.ReadLine();
                    banquer.CrearClient(nouClient);
                    break;
                
                case "2":
                    Console.WriteLine("Escriu el nom del client ");
                    string clientIngressar = Console.ReadLine();
                    Console.WriteLine("Quants diners vols ingressar?");
                    int quantitatIngressar = int.Parse(Console.ReadLine());
                    Console.WriteLine(banquer.PosarDiners(clientIngressar, quantitatIngressar));
                    break;
                
                case "3":
                    Console.WriteLine("Escriu el nom del client ");
                    string clientRetirar = Console.ReadLine();
                    Console.WriteLine("Quants diners vols retirar?");
                    int quantitatRetirar = int.Parse(Console.ReadLine());
                    Console.WriteLine(banquer.TreureDiners(clientRetirar, quantitatRetirar));
                    break;
                
                case "4":
                    Console.WriteLine("Escriu el nom del client ");
                    string ConsultarSaldo = Console.ReadLine();
                    Console.WriteLine(banquer.ConsultarSaldo(ConsultarSaldo));
                    break;
                
                case "5":
                    Console.WriteLine("Gràcies per utilitzar el nostre programa");
                    break;
                
                default:
                    Console.WriteLine("Opció no valida");
                    break;
            }
        } while (opcio != "5");
            
    }
}