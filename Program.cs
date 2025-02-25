using DesafioCelular.Models;

Smartphone nokia = new Nokia("123456879", "Nokia", "012345", 512);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");


Smartphone iphone = new Iphone("987654321", "Nokia", "543210", 256);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Clash Royale");