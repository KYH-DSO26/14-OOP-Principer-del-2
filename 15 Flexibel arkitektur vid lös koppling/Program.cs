namespace _15_Flexibel_arkitektur_vid_lös_koppling;

public interface IMeddelandeTjanst { void Skicka(string m); }
public class EpostTjanst : IMeddelandeTjanst
{
    public void Skicka(string m)
    {
        System.Console.WriteLine($"E-post: {m}");
    }
}
// En helt ny klass kan läggas till utan att vi rör Notifierare överhuvudtaget!
public class SmsTjanst : IMeddelandeTjanst
{
    public void Skicka(string meddelande)
    {
        System.Console.WriteLine($"Skickar SMS till mobilen: {meddelande}");
    }
}
public class Notifierare
{
    private IMeddelandeTjanst _tjanst;
    public Notifierare(IMeddelandeTjanst tjanst) { _tjanst = tjanst; }
    public void SkickaSystemMeddelande(string text) { _tjanst.Skicka(text); }
}
internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("--- Projekt 15: Ersättningsbarhet vid Lös Koppling ---");
        
        // Vi byter ut Epost mot SMS utan att Notifierare bryr sig eller behöver kompileras om
        Notifierare smsNotifierare = new Notifierare(new SmsTjanst());
        smsNotifierare.SkickaSystemMeddelande("Varning: Strömavbrott i serverhallen!");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
