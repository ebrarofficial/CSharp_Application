using System;
public class Deneme {
    static void Main(string[] args)
    {
        int[,] notlar = new int[3, 2];
        notlar[0, 0] = 50;
        notlar[0, 1] = 70;
        notlar[1, 0] = 80;
        notlar[1, 1] = 90;
        notlar[2, 0] = 40;
        notlar[2, 1] = 60;

        for (int i = 0; i < notlar.GetLength(0); i++)
        {
            Console.Write($"{i+1}. Ögrenci: ");
            for (int j = 0; j < notlar.GetLength(1); j++)
            {
                Console.Write($"{notlar[i, j]} ");
            }
            Console.WriteLine("");
        }
    }
}