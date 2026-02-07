using System;
class Program2
{
    public static void Main(string[] args)
    {
        Klima vestel = new Klima("Vestel", 25);
        Console.WriteLine(vestel.SicaklikDegistir(40));
    }
}
class Klima
{
    public string Marka { get; set; }
    private int derece;
    public int Sicaklik
    {
        get
        {
            return derece;
        }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Sıcaklık 18 derecenin altına düşemez, 18'e ayarlandı.");
                derece = 18;
            }

            else if (value > 30)
            {
                Console.WriteLine("Sıcaklık 30 derecenin üstüne çıkamaz, 30'a ayarlandı.");
                derece = 30;
            }

            else
            {
                derece = value;
            }
        }
    }

    public int SicaklikDegistir(int derece)
    {
        this.Sicaklik = derece;
        return this.Sicaklik;
    }

    public Klima(string marka, int derece)
    {
        this.Marka = marka;
        this.Sicaklik = derece;
    }    
}