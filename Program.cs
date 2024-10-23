using DesafioPOO.Models;

// FEITO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia(numero: "19981754632", modelo: "Modelo Nokia 2022", imei: "9999111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");
Console.WriteLine("====================");
Console.WriteLine("\n");

Console.WriteLine("IPHONE");
Smartphone iphone = new Iphone(numero: "19952142631", modelo: "Iphone 15 Pro Max", imei: "88841111", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");