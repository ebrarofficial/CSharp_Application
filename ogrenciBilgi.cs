using System;

public class OgrenciBilgi
{
    static void Main(string[] args)
    {
        Sinif a = new Sinif("Ebrar", 20);
        a.BilgiYazdir();
    }
}
public class Sinif
{

    public string Ad { get; set; }
    private int yas;
    public int Yas
    {
        get
        {
            return yas;
        }
        set
        {
            if (value < 8)
            {
                yas = 8;
            }
            else
            {
                yas = value;
            }
        }
    }

    public Sinif(string ad, int yas)
    {
        this.Ad = ad;
        this.Yas = yas;
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {this.Ad}, Yaş: {this.Yas}");
    }


}