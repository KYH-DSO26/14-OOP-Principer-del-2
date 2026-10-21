namespace _05_Statisk_polymorfism__Metodöverlagring_;

public class Skrivare
{
    // Samma metodnamn, men olika parametrar (Metodöverlagring)
    public void SkrivUt(string text)
    {
        Console.WriteLine($"Skriver ut en textsträng: {text}");
    }
    public void SkrivUt(int tal) 
    {
        Console.WriteLine($"Skriver ut ett tal: {tal}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 5: Mewtodöverlagring ---\n\n");

        var skrivare = new Skrivare();
        skrivare.SkrivUt("Hej klassen!");
        skrivare.SkrivUt(42);







        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
