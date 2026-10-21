namespace _02_Polymorfism_med_basklassreferens;

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
        Console.WriteLine("--- Lektion 2: Basklassreferens ---\n\n");

        Hund minHund = new Hund();
        minHund.GörLjud();
        
        
        Djur minAndraHund = new Hund();     // OBS Det ser mysko ut, men funkar!

        // C# avgör vid körning (runtime) vilken metod som ska anropas
        minAndraHund.GörLjud();





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
