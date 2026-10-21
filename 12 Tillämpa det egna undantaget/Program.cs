namespace _12_Tillämpa_det_egna_undantaget;

// Vår egna specifika undantagsklass ärver från Exception
public class SaldoSaknasException : Exception
{
    public SaldoSaknasException() { }
    public SaldoSaknasException(string meddelande) : base(meddelande) { }
    public SaldoSaknasException(string meddelande, Exception innerEx) : base(meddelande, innerEx) { }

}
public class Bankkonto
{
    private double saldo;

    public Bankkonto(double saldo )
    {
        this.saldo = saldo;
    }

    public void Uttag(double belopp)
    {
        if (belopp > saldo)
        {
            // Vi kastar vårt eget undantag
            throw new SaldoSaknasException($"Uttag nekat: du försökte ta ut {belopp} men det finns bara {saldo} på kontot.");
        }
        saldo -= belopp;
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 12: Använda Eget Exception ---\n\n");

        Bankkonto konto = new(200);
        try
        {
            konto.Uttag(500);   // Överstiger saldot
        }
        catch (SaldoSaknasException ex)
        {
            Console.WriteLine($"Fel fångat: {ex.Message}");
        }
        //finally { }





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
