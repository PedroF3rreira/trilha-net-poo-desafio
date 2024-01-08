using DesafioPOO.Models;
class Programa
{
    public static void Main()
    {
        int marca = EscolheMarca();
        var phone = CriarSmartphone(marca);
        MenuSmartphone(phone);
    }
    private static int EscolheMarca()
    {
        Console.WriteLine("Bem vindo ao nosso sistema de simulação de celulares");

        bool exibirInicio = true;
        int option = 0;

        while (exibirInicio)
        {
            Console.WriteLine("Escolha uma marca de celular");
            Console.WriteLine("1 - IPHONE");
            Console.WriteLine("2 - NOKIA");

            var validFormat = int.TryParse(Console.ReadLine(), out option);

            if (validFormat && option > 0 && option <= 2)
            {
                exibirInicio = false;
            }
            else
            {
                Console.WriteLine("Opção invalida....\ntecle qualquer tecla para tentar novamente...");
                Console.ReadLine();
            }
        }
        return option;
    }

    private static Smartphone CriarSmartphone(int marca)
    {
        Smartphone phone;
        try
        {

            Console.WriteLine("Digite um número para o celular ex:(81 98559 8077):");
            var numero = Console.ReadLine();

            Console.WriteLine("Digite o modelo:");
            var modelo = Console.ReadLine();

            Console.WriteLine("Digite o imei:");
            var imei = Console.ReadLine();

            Console.WriteLine("Digite quantidade de memória:");
            var memoria = Convert.ToInt16(Console.ReadLine());

            switch (marca)
            {
                case 1:
                    return phone = new Iphone(numero, modelo, imei, memoria);
                case 2:
                    return phone = new Nokia(numero, modelo, imei, memoria);
                default:
                    return null;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("os dados de entrada estão no formato errado");
            return null;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    private static void MenuSmartphone(Smartphone phone)
    {
        bool exibirMenu = true;
        string menuOption;

        if (phone == null)
        {
            Console.WriteLine("Ocorreu um erro...");
            exibirMenu = false;
        }

        while (exibirMenu)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Fazer ligaçao");
            Console.WriteLine("2 - Receber ligação");
            Console.WriteLine("3 - Instalar aplicativo");
            Console.WriteLine("4 - Exibir informações do celular");
            Console.WriteLine("5 - Parar programa");
            menuOption = Console.ReadLine();

            switch (menuOption)
            {
                case "1":
                    Console.Clear();
                    phone.Ligar();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    phone.ReceberLigacao();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Digite um nome de aplicativo:");
                    phone.InstalarAplicativo(Console.ReadLine());
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(phone.ToString());
                    Console.WriteLine();
                    break;
                case "5":
                    exibirMenu = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.....");
                    break;
            }
        }
        Console.WriteLine("programa finalizado...");
    }
}







