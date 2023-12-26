using DesafioPOO.Models;

Console.WriteLine("Bem vindo ao nosso sistema de simulação de celulares");

Console.WriteLine("Escolha uma marca celular");
Console.WriteLine("1 - IPHONE");
Console.WriteLine("2 - NOKIA");

var option = Console.ReadLine();

Console.WriteLine("Digite um número para o celular ex:(81 98559 8077):");
var numero = Console.ReadLine();

Console.WriteLine("Digite o modelo:");
var modelo = Console.ReadLine();

Console.WriteLine("Digite o imei com letra e números:");
var imei = Console.ReadLine();

Console.WriteLine("Digite quantidade de memória:");
var memoria = Convert.ToInt16(Console.ReadLine());

Smartphone phone;

switch (option)
{
    case "1":
        phone = new Iphone(numero, modelo, imei, memoria);
        break;
    case "2":
        phone = new Nokia(numero, modelo, imei, memoria);
        break;
    default:
        return;
}

bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Fazer ligaçao");
    Console.WriteLine("2 - Receber ligação");
    Console.WriteLine("3 - Instalar aplicativo");
    Console.WriteLine("4 - Exibir informações do celular");
    Console.WriteLine("5 - Parar programa");
    option = Console.ReadLine();

    switch (option)
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
            Console.WriteLine(phone.ToString());
            break;
        case "5":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }  
}
Console.WriteLine("programa finalizado...");