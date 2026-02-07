using System;
public class Matris
{
    static void Main(string[] args)
    {
        Console.WriteLine("Uzunluk giriniz: ");
        int uzunluk = Convert.ToInt32(Console.ReadLine());
        int[,] matris = new int[uzunluk, uzunluk];

        Console.WriteLine("===================MATRİS ALMA===================");

        for (int satir = 0; satir < uzunluk; satir++)
        {
            for (int sutun = 0; sutun < uzunluk; sutun++)
            {
                Console.WriteLine($"({satir},{sutun}) elemanı giriniz: ");
                matris[satir, sutun] = Convert.ToInt32(Console.ReadLine());
                
            }
        }
        
        Console.WriteLine("===================MATRİS GÖSTERME===================");

        for (int satir = 0; satir < uzunluk; satir++)
        {
            for (int sutun = 0; sutun < uzunluk; sutun++)
            {
                Console.WriteLine(matris[satir, sutun] + "\t");
            }

            Console.WriteLine();
        }

        Console.WriteLine("===================SOL ÜST TOPLAMA===================");

        int toplam = 0;

        for (int satir = 0; satir < uzunluk; satir++)
        {
            for (int sutun = 0; sutun < uzunluk; sutun++)
            {
                if (satir + sutun < uzunluk)
                {
                    toplam = toplam + matris[satir, sutun];
                }
            }
        }
        Console.WriteLine("Sorunun cevabı: "+toplam);
    }
}