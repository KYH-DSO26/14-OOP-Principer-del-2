namespace _07_Verklig_hierarki___Användarsystem__Användare_;

public class Användare
{
    public string Namn { get; set; }
}

public class Admin : Användare
{
    public void NollställSystem()
    {
        Console.WriteLine("Kritiskt meddelande: Hela systemet har återställts av Admin.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 7: Användarroller ---\n\n");

        Användare[] systemAnvändare = new Användare[]
        {
            new Användare {Namn = "Carl-Henrik"},
            new Admin {Namn = "Sandra"},
        };

        foreach (var användare in systemAnvändare)
        {
            Console.WriteLine($"Inloggad: {användare.Namn}");
            if (användare is Admin a)
            {
                Console.WriteLine($"{a.Namn} är Admin");
                a.NollställSystem();
            }
        }








        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
