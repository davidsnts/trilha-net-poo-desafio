using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone iPhone:");

            
            Smartphone iphone = new Nokia("123456", "Modelo 1", "111111111", 64);

            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");

        }
    }
}