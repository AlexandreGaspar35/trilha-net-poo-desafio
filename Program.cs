using DesafioPOO.Models;


Console.WriteLine("Smarthphone Nokia...");
Smartphone nokia = new Nokia(numero: "123456", modelo: "3310", imei: "99999987", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone Iphone...");
Smartphone iphone = new Iphone(numero: "123456", modelo: "3310", imei: "99999987", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");