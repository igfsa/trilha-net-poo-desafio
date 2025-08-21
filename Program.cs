using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO

// Testes iPhone
Iphone i = new Iphone("9 1234-5678", "iPhone 15", "123456789012345", 8);

Console.WriteLine($"Modelo iPhone: {i.Modelo}");
Console.WriteLine($"Numero iPhone: {i.Numero}");
Console.WriteLine($"Imei iPhone: {i.IMEI}");
Console.WriteLine($"Memoria iPhone: {i.Memoria}");

i.InstalarAplicativo("WhatsApp");
i.Ligar();
i.ReceberLigacao();

Console.WriteLine($"/-/-/-/-/-/-/-/-/-/-/-/-/");

// Testes Nokia 
Nokia n = new Nokia("9 8765-4321", "Nokia X", "543210987654321", 6);

Console.WriteLine($"Modelo Nokia: {n.Modelo}");
Console.WriteLine($"Numero Nokia: {n.Numero}");
Console.WriteLine($"Imei Nokia: {n.IMEI}");
Console.WriteLine($"Memoria Nokia: {n.Memoria}");

n.InstalarAplicativo("WhatsApp");
n.Ligar();
n.ReceberLigacao();
