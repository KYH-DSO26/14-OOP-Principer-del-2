namespace _10_Kasta_egna_undantag__ArgumentException_;

public class Person
{
    private int _ålder;

    public int Ålder
    {
        get { return _ålder; }
        set {
            if (value < 0)
            {
                // Vi kastar ett inbyggt undntag om regeln bryts
                throw new ArgumentException("Åldern måste vara större än noll!");
            }
            _ålder = value; 
        }
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 10: Kasta undantag ---\n\n");

        var p = new Person();

        try
        {
            p.Ålder = -5;       // Provocera fram ett fel
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Valideringsfel stoppade programmet: ({ex.Message})");
        }






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
