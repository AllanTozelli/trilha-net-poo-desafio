using DesafioPOO.Models;


// Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ExibirInformacoes();

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 1", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.ExibirInformacoes();
