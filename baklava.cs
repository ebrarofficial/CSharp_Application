using System;
public class Yildiz {
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++) 
        {
            for (int k = 0; k < n - i - 1; k++) 
            {
                System.Console.Write(" ");
            }
            for (int j = 0; j < 2*i + 1; j++) 
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("");
        }

        for (int i = 1; i < n; i++)
        {
            for (int k = 1; k < i + 1; k++)
            {
                System.Console.Write(" ");
            }
            for (int j = 0; j < 2*(n-i)-1; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("");
        }
    }
}