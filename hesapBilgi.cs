using System;
public class HesapBilgi2
{
    static void Main(string[] args)
    {
        BankaHesabi2 ebrar = new BankaHesabi2("Ebrar", 5000);
        ebrar.ParaCek(6000);
        ebrar.BilgiYazdir();
    }
}
public class BankaHesabi2
{
    public string HesapAdi { get; set; }
    private double bakiye;
    public double Bakiye
    {
        get
        {
            return bakiye;
        }
        set
        {
            if (value < 0)
            {
                bakiye = 0;
            }
            else
            {
                bakiye = value;
            }
        }
    }

    public BankaHesabi2(string hesapAdi, double bakiye)
    {
        this.HesapAdi = hesapAdi;
        this.Bakiye = bakiye;
    }

    public void ParaCek(double miktar)
    {
        if (miktar > bakiye)
        {
            Console.WriteLine("Yetersiz bakiye");
        }

        else
        {
            bakiye -= miktar;
        }
    }

    public void ParaYatir(double miktar)
    {
        bakiye += miktar;
    }

    public void BilgiYazdir()
    {
        Console.WriteLine(bakiye);
    }


}