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
    }
}