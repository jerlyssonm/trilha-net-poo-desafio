using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Executando o Nokia");
Nokia nokia = new Nokia("99999-11111", "1100", "1219219291291921921", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("telegram");

Console.WriteLine("\n");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("\n");

Console.WriteLine("Executando o AiFone");
Iphone iphone = new Iphone("999999-22222", "13", "9291291291299121291", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsapp");