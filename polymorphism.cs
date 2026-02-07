using System;
public class Polymorphism
{
    static void Main(string[] args)
    {
        Hayvan duman = new Kedi();
        duman.SesCikar();

        Hayvan karabas = new Kopek();
        karabas.SesCikar();
    }
}

public class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor");
    }
}

public class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyavvv");
    }
}

public class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav Hav");
    }
}