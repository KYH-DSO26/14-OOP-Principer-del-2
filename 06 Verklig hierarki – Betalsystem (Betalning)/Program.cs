namespace _06_Verklig_hierarki___Betalsystem__Betalning_;

public class Betalning
{
    public double Belopp { get; set; }
    public virtual void ProcessaBetalning()
    {
        Console.WriteLine($"Processar en generell betalning på {Belopp:C2}");
    }
}

public class Kreditkort : Betalning
{
    public override void ProcessaBetalning()
    {
        Console.WriteLine($"Kopplar till banken... Drar {Belopp:C2} från kreditkortet");
    }
}

public class Swish : Betalning
{
    public override void ProcessaBetalning()
    {
        Console.WriteLine($"Öppnar Swish-appen. Godkänner överföring på {Belopp:C2}");
    }
}

public class PayPal : Betalning
{
    public override void ProcessaBetalning()
    {
        Console.WriteLine($"Kontaktar PayPal för att betala {Belopp}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 6: Verkligt betalsystem ---\n\n");

        Betalning b1 = new Kreditkort { Belopp = 450 };
        Betalning b2 = new Swish { Belopp = 120 };

        Kreditkort b3 = new Kreditkort { Belopp = 2000 };  // Utnyttjar inte run-time polymorfism
        var b4 = new Kreditkort { Belopp = 995 };  // Utnyttjar inte run-time polymorfism

        b1.ProcessaBetalning();
        b2.ProcessaBetalning();

        b3.ProcessaBetalning();
        b4.ProcessaBetalning();

        Betalning b5 = new PayPal { Belopp = 500 };
        b5.ProcessaBetalning();

        Console.WriteLine("\n\nBetalningar i en array:");
        Betalning[] betalningar = new Betalning[] { b1, b2, b3, b4, b5 };
        foreach (var betalning in betalningar)
        {
            betalning.ProcessaBetalning();
        }






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
