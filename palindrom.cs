using System;
public class Palindrom {
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int orta = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= orta; i++)
        {
            Console.Write(i);
        }
        for(int j = orta - 1; j > 0; j--)
        {
            Console.Write(j);
        }
    }  
}