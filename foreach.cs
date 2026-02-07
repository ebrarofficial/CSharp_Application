public class Foreach {
    public static void Main(string[] args)
    {
        string[] isimler = ["Elif", "Ali", "Veli", "Ayşe", "Fatma", "Fırat"];

        foreach(var isim in isimler)
        {
            Console.WriteLine(isim);
        }
    }
}