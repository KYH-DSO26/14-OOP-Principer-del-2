namespace _03_Array_av_polymorfa_objekt;

public class Djur
{
    public virtual void GörLjud()
    {
        // Virtual tillåter underklasser att skriva över metoden
        Console.WriteLine("Djuret gör ett märkligt ljud.");
    }
}

public class Hund : Djur
{
    // override ändrar beteendet i underklassen
    public override void GörLjud()
    {
        Console.WriteLine("Hunden skäller: Voff Voff!");
    }
}

public class Katt : Djur
{
    public override void GörLjud()
    {
        Console.WriteLine("Katten säger Mjau!");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Lektion 3: Polymorf array ---\n\n");

        // Vi kan blanda underklasser i samma array tack vare den gemensamma basklassen
        Djur[] djurpark = new Djur[] 
        { 
            new Hund(),
            new Katt(),
        };

        foreach (Djur dj in djurpark)
        {
            dj.GörLjud();
        }






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
