using System;
class UrunHesapla
{
    public static void Main(string[] args)
    {
        Urun a = new Urun("Bilgisayar", 20000);
        Urun b = new Urun("Telefon", 9000);
        Urun c = new Urun("Fırın", 13000);

        Urun[] urunListesi = { a, b, c };
        Sepet sepet = new Sepet(urunListesi);

        double fatura = sepet.TutarHesapla();

        Console.WriteLine(fatura);
    }
}

class Urun
{
    public string Ad { get; set; } = "";
    public double Fiyat { get; set; }

    public Urun(string ad, double fiyat)
    {
        this.Ad = ad;
        this.Fiyat = fiyat;
    }
}

class Sepet
{
    Urun[] urunler;

    public Sepet(Urun[] urunler)
    {
        this.urunler = urunler;
    }
    
    public double TutarHesapla()
    {
        double toplam = 0;
        foreach (var urun in urunler)
        {
            toplam = toplam + urun.Fiyat;
        }

        if (toplam > 2000)
        {
            toplam = toplam * 0.90;

            return toplam;
        }

        else
        {
            return toplam;
        }
        
    }
}