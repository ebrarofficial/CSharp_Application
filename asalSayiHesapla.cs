using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı gir: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int sayac = 1;

        if (sayi < 2)
        {
            sayac = 2;
        }

        else
        {
            for (int i = 2; i < sayi; i++)
            {
            
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
                
            }

        }

        if (sayac == 2)
        {
            Console.WriteLine("ASAL DEĞİL");
        }

        else
        {
            Console.WriteLine("ASAL");
        }
    }
}
