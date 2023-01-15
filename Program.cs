using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone.
// Implementado.

Console.WriteLine($"Smart phone Nokia");
Smartphone nokia = new Nokia(numero: "123456 ", modelo: "Modelo 01 ", imei: "2365678 ", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatszap");

Console.WriteLine("---------------------------------------------------------------");

Console.WriteLine($"Smart phone Iphone");
Smartphone Iphone = new Nokia(numero: "4987 ", modelo: "Modelo 02 ", imei: "22222", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegran");
