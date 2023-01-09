using NTP.Araclar;
using NTP.Araclar.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        IOtomobil togg = new Otomobil("Oltu", "TOGG",5);
        IOtomobil bmw = new Otomobil("Mavi", "BMW",3);

        togg.Hizlan(10);
        bmw.Hizlan(5);

        togg.Hizlan(50);
        bmw.Hizlan(20);

        Console.WriteLine(togg.ToString());
        Console.WriteLine(bmw.ToString());

        Console.ReadKey();
    }
}