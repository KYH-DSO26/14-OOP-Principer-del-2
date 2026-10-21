namespace _08_Enkel_Try_Catch__Division_med_noll_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 8: Felhantering (Division)");


		try
		{
			int t1 = 10;
			int t2 = 2;

			int resultat = t1 / t2;
			Console.WriteLine($"Resultat av {t1} / {t2}: {resultat}");

			t2 = 0;			// Vi vill provocera fram ett fel
			resultat = t1 / t2;
			Console.WriteLine($"Resultat av {t1} / {t2}: {resultat}");
		}
		catch (DivideByZeroException)
		{
            Console.WriteLine("Ett fel inträffade: det går inte att dividera med noll!");
		}






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
