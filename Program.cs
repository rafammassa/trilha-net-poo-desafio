using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123", "Plus", "11111", 10);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("321", "15", "2222", 15);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");