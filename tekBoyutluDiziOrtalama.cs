using System;
public class Ortalama {
    static void Main(string[] args)
    {
        int[] sayi = new int[10];

        int toplam = 0;
        for (int i = 0; i < sayi.Length; i++)
        {
            Console.Write($"{i+1}. sayıyı giriniz: ");
            sayi[i] = Convert.ToInt32(Console.ReadLine());
            toplam += sayi[i];
        }

        double ortalama = (double)toplam / 10;
        Console.WriteLine(ortalama);
    }
}