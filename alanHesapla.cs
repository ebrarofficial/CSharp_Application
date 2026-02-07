using System;
public class OOPSon1
{
    public static void Main(string[] args)
    {
        Kare a = new Kare();
        a.Kenar = 5;
        Console.WriteLine(a.AlanHesapla());
        Console.WriteLine("--------------------------");
        Daire b = new Daire();
        b.Yaricap = 2.8217;
        Console.WriteLine(b.AlanHesapla());
    }
}

public class Sekil1
{
    public Sekil1()
    {
        Console.WriteLine("Ben bir şekil sınıfıyım.");
    }
}

public class Kare1 : Sekil
{
    private double kenar;
    public double Kenar
    {
        get
        {
            return kenar;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Kenar negatif olamaz");
            }
            else
            {
                kenar = value;
            }
        }
    }

    public double AlanHesapla()
    {
        return kenar * kenar;
    }
}

public class Daire1 : Sekil
{
    private double yaricap;
    public double Yaricap
    {
        get
        {
            return yaricap;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Yarıçap negatif olamaz");
            }
            else
            {
                yaricap = value;
            }
        }
    }

    public double AlanHesapla()
    {
        double pi = 3.14;
        return pi * yaricap * yaricap;
    }
}