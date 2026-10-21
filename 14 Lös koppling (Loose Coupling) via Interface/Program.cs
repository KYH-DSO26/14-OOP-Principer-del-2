namespace _14_Lös_koppling__Loose_Coupling__via_Interface;

// Abstrakt kontrakt för meddelandetjänster
public interface IMeddelandeTjanst
{
    void Skicka(string meddelande);
}
public class EpostTjanst : IMeddelandeTjanst
{
    public void Skicka(string meddelande)
    {
        System.Console.WriteLine($"Skickar E-post: {meddelande}");
    }
}
public class Notifierare
{
    private IMeddelandeTjanst _tjanst;
    // Klassen är LÖST KOPPLAD eftersom den ber om ett interface via konstruktorn
    public Notifierare(IMeddelandeTjanst tjanst)
    {
        _tjanst = tjanst;
    }
    public void SkickaSystemMeddelande(string text)
    {
        _tjanst.Skicka(text);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("--- Projekt 14: Lös Koppling via Interface ---");
        
        // Vi injicerar EpostTjanst i vår Notifierare
        Notifierare notifiering = new Notifierare(new EpostTjanst());
        notifiering.SkickaSystemMeddelande("Varning: Servern är varm!");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
