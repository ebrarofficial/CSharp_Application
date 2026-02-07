using System;

public class HesapBilgi
{
    static void Main(string[] args)
    {
        BankaHesabi a = new BankaHesabi("Ebrar", 5000);
        BankaHesabi b = new BankaHesabi("Ali", 3000);
        BankaHesabi c = new BankaHesabi("Veli", 7000);
        BankaHesabi[] musteriler = { a, b, c };

        Banka bankaGenel = new Banka(musteriler);
        double sonuc = bankaGenel.TumBakiyeToplaminiHesapla();
        Console.WriteLine(sonuc);
    }
}
public class Banka
{
    BankaHesabi[] hesaplar;

    public Banka(BankaHesabi[] hesaplar)
    {
        this.hesaplar = hesaplar;
    }

    public double TumBakiyeToplaminiHesapla()
    {
        
        double toplam = 0;
        foreach (var bakiye in hesaplar)
        {
            toplam += bakiye.Bakiye;
        }

        return toplam;
    }
}

public class BankaHesabi
{
    private string HesapAdi { get; set; }
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

    public BankaHesabi(string hesapAdi, int bakiye)
    {
        this.HesapAdi = hesapAdi;
        this.Bakiye = bakiye;
    }

    public void ParaCek(double miktar)
    {
        if (miktar > bakiye)
        {
            System.Console.WriteLine("Yetersiz bakiye.");
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
    
    public void BilgiGoster()
    {
        System.Console.WriteLine(bakiye);
    }
    
}