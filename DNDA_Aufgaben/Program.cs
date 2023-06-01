namespace DNDA_Aufgaben;

public class Program
{
    public static void Main(string[] args)
    {
        // Wahrheitswerte
        bool wahr = true;
        bool falsch = false;
        
        // Zahlenwerte
        byte byteWert = 8;      // -128 bis 127
        short shortWert = 123;  // -32,768 bis 32,767
        int intWert = 4324;     // -2,147,483,648 bis 2,147,483,647
        long longWert = 92233;  // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        
        // Gleitkommazahlen
        float floatWert = 0.1f;         // Präzision: ~6-9 Nachkommastellen
        double doubleWert = 2.6d;       // Präzision: ~15-17 Nachkommastellen
        decimal decimalWert = 12.2m;    // Präzision: 28-29 Nachkommastellen
        
        // Zeichenwerte
        char charWert = 'a';
        string stringWert = "Hallo";
        
        
        // Tutorial
        
        // Operatoren:
        
        // Arithmetische Operatoren:

        int x = 5;
        int y = 5;
        int sum = x + y;            // Operator für Addition
        int difference = x - y;     // Operator für Substraktion
        int product = x * y;        // Operator für Multiplikation
        int quotient = x / y;       // Operator für Division


        // Vergleichsoperatoren

        bool xGroesserAlsY = x > y;
        bool xKleinerAlsY = x < y;
        bool xGleichY = x == y;
        bool xGroesserGleichY = x >= y;
        bool xKleinerGleichY = x <= y;
        
        // Beispiel für Vergleichsoperatoren:

        if (x > y)
        {
            Console.WriteLine("X ist größer als Y!");
        }
        else
        {
            Console.WriteLine("X ist nicht größer als Y!");
        }
        
        
        // Boolesche logische Operatoren verbunden mit If Anweisungen

        if (!xGroesserAlsY)
        {
            // "Wenn Bedingung NICHT auftritt, dann...".
            // Das "!" ist der Negationsoperator
        }

        if (xGroesserAlsY && xGleichY)
        {
            // "Wenn 1. Bedingung UND 2. Bedingung wahr sind, dann...".
            // Das "&&" ist der binär bedingte logische AND Operator
        }

        if (xGroesserAlsY || xKleinerGleichY)
        {
            // "Wenn 1. Bedingung oder 2. Bedingung, dann..."
            // Das "||" ist der binär bedingte logische OR Operator
        }
        
        
        // Schleifen
        
        // For Schleife

        for (int i = 0; i < x; i++)
        {
            // i = 0 und Schleife wird so lange wiederholt, bis i = x ist
            // i++ am Ende ist das Inkrement
            
            Console.WriteLine($"Ich trete {x} mal auf");
        }
        
        // Foreach Schleife

        int[] einArray = { 1, 2, 3, 4, 5, 6 };

        foreach (var zahl in einArray)
        {
            // Für jedes Element in "einArray" wird der folgende Befehl ausgeführt
            
            Console.WriteLine(zahl);
        }
        
        // While Schleife

        int count = 0;

        while (count != 5)
        {
            // Schleife wird ausgeführt, solange die oben genannte Bedingung wahr ist
            
            count++;    // count wird bei jeder Iteration um 1 erhöht
            Console.WriteLine($"Variable Count beträgt = {count}");
        }
    }
}