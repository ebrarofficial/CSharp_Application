using System;
public class Maksimum
{
    static void Main(string[] args)
    {
        int sonuc = BuyukOlaniHesapla(2, 4);
        Console.WriteLine(sonuc);
    }
    
    public static int BuyukOlaniHesapla(int sayi1, int sayi2)
    {
        if (sayi1 > sayi2)
        {
            return sayi1;
        }

        else
        {
            return sayi2;
        }
    }
}