using System;
class Program3
{
    public static void Main(string[] args)
    {
        Calisan a = new Mudur();
        a.Ad = "Ebrar";
        a.Maas = 5000;
        Console.WriteLine(a.MaasHesapla());

        Calisan b = new Stajyer();
        b.Ad = "Betül";
        b.Maas = 2000;
        Console.WriteLine(b.MaasHesapla());
    }
}
class Calisan
{
    public string Ad { get; set; } = "";
    public double Maas { get; set; }
    public virtual double MaasHesapla()
    {
        return Maas;
    }
}

class Mudur : Calisan
{
    public override double MaasHesapla()
    {
        return Maas + 5000;
    }
}

class Stajyer : Calisan
{
    public override double MaasHesapla()
    {
        return Maas / 2;
    }
}