using System;
public class TersCevir {
    static void Main(string[] args)
    {
        int[] dizi = { 1, 2, 3, 4, 5 };

        int[] yeni = DiziyiTersCevir(dizi);

        foreach (var eleman in yeni)
        {
            Console.Write(eleman+ " ");
        }
    }

    public static int[] DiziyiTersCevir(int[] dizi)
    {
        int[] yeniDizi = new int[dizi.Length];

        yeniDizi[0] = dizi[4];
        yeniDizi[1] = dizi[3];
        yeniDizi[2] = dizi[2];
        yeniDizi[3] = dizi[1];
        yeniDizi[4] = dizi[0];

        return yeniDizi;
    }
}