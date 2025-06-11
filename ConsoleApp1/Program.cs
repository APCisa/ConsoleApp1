// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Joris;

Console.WriteLine("Bonjour !");

IJoris joris = new Joris();
joris.DireBonjour();

joris = null;
joris.DireAuRevoir();

Console.WriteLine("Hello, Corentin!"); // test///
Console.WriteLine("Bonjour, Corentin!");
