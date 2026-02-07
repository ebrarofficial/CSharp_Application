using System;
public class Hesapla
{
    static void Main(string[] args)
    {
        int[,] notlar = new int[3, 2];
        notlar[0, 0] = 50;
        notlar[0, 1] = 70;
        notlar[1, 0] = 80;
        notlar[1, 1] = 90;
        notlar[2, 0] = 40;
        notlar[2, 1] = 60;

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Öğrenci {i + 1}: ");
            int vize = notlar[i, 0];
            int final = notlar[i, 1];
            Console.Write($"{notlar[i, 0]}, {notlar[i, 1]} ");

            double ortalama = vize * 0.4 + final * 0.6;

            Console.Write($" Geçme Notu: {ortalama}");
            Console.WriteLine("");
        }
    }
}