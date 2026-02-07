using System;

public class DiziOrtalama {
    static void Main(string[] args)
    {
        int[] sayilar = { 10, 15, 12 };
        Console.WriteLine(OrtalamaHesapla(sayilar));
    }
    
    public static double OrtalamaHesapla(int[] sayilar)
    {
        int toplam = 0;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }

        double sonuc = (double)toplam / sayilar.Length;

        return sonuc;
    }
}