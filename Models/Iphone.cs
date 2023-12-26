using System.Security.Cryptography;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(){}
        public Iphone(string numero,
                    string modelo,
                    string imei,
                    int memoria) : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {

            Console.Write($"Preparando para instalar aplicativo ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(nomeApp);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" no modelo ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Modelo);
            Console.ForegroundColor = ConsoleColor.White;

            ProgressStatus();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Descompactando arquivos do aplicativo ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{nomeApp.ToUpper()}");
            Console.ForegroundColor = ConsoleColor.White;
            ProgressStatus();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Instalando o aplicativo ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(nomeApp.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            ProgressStatus();

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Aplicativo {nomeApp.ToUpper()} instalado com sucesso!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ProgressStatus()
        {
            var rand = new Random();
            for (int i = 0; i < 60; i++)
            {
                Console.Write("#");
                Thread.Sleep(rand.Next(200));
            }
        }
    }
}