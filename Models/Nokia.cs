namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(){}
        public Nokia(string numero,
                    string modelo,
                    string imei,
                    int memoria) : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {

            Console.Write($"O aplicativo ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(nomeApp);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" está sendo preparado para instalação no seu ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{Modelo}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" aguarde por favor.....");

            ProgressStatus();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"O sistema do seu {Modelo.ToUpper()} está descompactando arquivos do aplicativo ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{nomeApp.ToUpper()}");
            Console.ForegroundColor = ConsoleColor.White;
            ProgressStatus();

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Terminando instalação do aplicativo ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(nomeApp.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            ProgressStatus();

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Aplicativo {nomeApp.ToUpper()} instalado com exito!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ProgressStatus()
        {
            var rand = new Random();
            for (int i = 0; i < 60; i++)
            {
                Console.Write("=>");
                Thread.Sleep(rand.Next(200));
            }
        }
    }
}