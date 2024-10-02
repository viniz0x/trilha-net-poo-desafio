using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", iMEI: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Whatssap");

Console.WriteLine("\n");

Console.WriteLine("Smarphone Iphone");
Smartphone iphone = new Iphone(numero: "789012", modelo: "Modelo2", iMEI: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo(nomeApp: "Instagram");