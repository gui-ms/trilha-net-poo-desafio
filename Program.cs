using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testes Nokia");
Nokia n1 = new Nokia("123456789", "Tijolo", "abcd", 64);
n1.InstalarAplicativo("Netflix");
n1.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Testes Iphone");
Iphone i1 = new Iphone("123456789", "Iphone 8000", "abcd", 32);
i1.InstalarAplicativo("IPhood");
i1.Ligar();