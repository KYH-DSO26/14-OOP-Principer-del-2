namespace _11_Skapa_en_egen_undantagsklass__SaldoSaknasException_;

// Vår egna specifika undantagsklass ärver från Exception
public class SaldoSaknasException : Exception
{
    public SaldoSaknasException() { }
    public SaldoSaknasException(string meddelande) : base(meddelande) { }
    public SaldoSaknasException(string meddelande, Exception innerEx) : base(meddelande, innerEx) { }

}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 11: eget Exception ---\n\n");

        Console.WriteLine("Klassen SaldoSaknasException skapad och redo för användning.");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
