namespace _01_Virtuell_metod__Djur_och_Hund_;

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
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Lektion 1: Virtuella metoder ---\n\n");

        Hund minHund = new Hund();
        minHund.GörLjud();





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
