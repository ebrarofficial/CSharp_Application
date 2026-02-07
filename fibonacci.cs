using System;
public class Fibonacci {
    static void Main(string[] args)
    {
        int ilkSayi = 0;
        int ikinciSayi = 1;

        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.Write($"{ilkSayi} {ikinciSayi} ");

        for(int i = 2; i <= sayi; i++)
        {
            int yeniSayi = ilkSayi + ikinciSayi;
            ilkSayi = ikinciSayi;
            ikinciSayi = yeniSayi;
            

            Console.Write($"{yeniSayi} ");
        }
    }
}