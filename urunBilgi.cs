using System;

public class UrunBilgi
{
    static void Main(string[] args)
    {
        Urun1 a = new Urun1("Laptop", -3000);
        a.BilgiYazdir();
    }
}
public class Urun1
{

    public string Isim { get; set; }
    private double fiyat;
    public double Fiyat
    {
        get
        {
            return fiyat;
        }
        set
        {
            if (value < 0)
            {
                fiyat = 0;
            }
            else
            {
                fiyat = value;
            }
        }
    }

    public Urun1(string isim, double fiyat)
    {
        this.Isim = isim;
        this.Fiyat = fiyat;
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Ürün: {this.Isim}, Fiyat: {this.Fiyat}");
    }


}