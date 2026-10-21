



namespace _13_Stark_sammanhållning__High_Cohesion_;

// Klassen har HÖG sammanhållning - den gör en sak och gör det bra
public class RapportData
{
    public string Titel { get; set; }
    public string Innehåll { get; set; }
}

// Den här klassen har hand om utskriften. (Single Responsibility)
public class RapportUtskrivare
{
    public void SkrivUtTillKonsol(RapportData rapport)
    {
        Console.WriteLine($"--- {rapport.Titel} ---\n");
        Console.WriteLine(rapport.Innehåll);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 13: High Cohesion ---");

        RapportData rapport = new RapportData
        {
            Titel = "Månadsrapport",
            Innehåll = "Nu har vi flyt!"
        };
        var utskrivare = new RapportUtskrivare();

        utskrivare.SkrivUtTillKonsol(rapport);

        // TODO: Här behöver vi en metod för att skapa en ny bil



        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
