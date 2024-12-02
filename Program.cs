using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando instância do Nokia
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111111111", memoria: 64);
        Console.WriteLine("Usando Nokia:");
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando instância do iPhone
        Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone 14", imei: "222222222222222", memoria: 128);
        Console.WriteLine("Usando iPhone:");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
