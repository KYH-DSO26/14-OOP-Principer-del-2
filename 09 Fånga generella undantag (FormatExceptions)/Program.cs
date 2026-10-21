namespace _09_Fånga_generella_undantag__FormatExceptions_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 9: Fånga FormatFel");

        try
        {
            Console.Write("Ange ett heltal: ");
            string input = Console.ReadLine();
            int tal = int.Parse(input);
            Console.WriteLine($"Du angav talet: {tal}");
            int a = 10 / tal;
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Inmatningsfel: Texten kunde inte tolkas som ett heltal. ({ex.Message})");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Nu uppstod något annat fel. Fan vet vad. \n({ex.Message})");
        }

        finally
        {
            // Detta körs ALLTID. Perfekt för att städa upp efter sig
            Console.WriteLine("Städningslogg: Finally-blocket har körts");
        }





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
