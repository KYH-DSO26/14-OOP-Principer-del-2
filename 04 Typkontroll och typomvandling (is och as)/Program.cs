namespace _04_Typkontroll_och_typomvandling__is_och_as_;

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
    public void ViftaPåSvansen()
    {
        Console.WriteLine("Hunden viftar glatt på svansen");
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
        Console.WriteLine("--- Lektion 4: Typkontroll med 'is' ---\n\n");

        // Vi kan blanda underklasser i samma array tack vare den gemensamma basklassen
        Djur[] djurpark = new Djur[]
        {
            new Hund(),
            new Katt(),
        };

        foreach (Djur dj in djurpark)
        {
            dj.GörLjud();

            // Kontrollerar och mönstermatchar typen i ett steg
            // Ja, syntaxen känns lite knepig, men så är det
            if (dj is Hund specifikHund)
            {
                specifikHund.ViftaPåSvansen();      // Nu kommer vi åt Hundens unika metoder
            }
        }






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
