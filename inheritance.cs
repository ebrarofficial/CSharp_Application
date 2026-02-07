using System;
public class Inheritance
{
    static void Main(string[] args)
    {
        Araba mahsun = new Araba();
        mahsun.Calistir();

        mahsun.Durdur();

    }
}

public class Arac
{
    public void Calistir()
    {
        Console.WriteLine("Araba çalıştı");
    }
}

public class Araba : Arac
{
    public void Durdur()
    {
        Console.WriteLine("Araba durdu");
    }
}
