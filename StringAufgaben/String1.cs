namespace StringAufgaben;

public class String1
{
    public string HalloName(string name)
    {
        // Erstelle eine Methode, welche den Parameterwert "name" mit "Hallo" grüßt
        //
        // HalloName("Muster") -> "Hallo Muster"

        return string.Empty;
    }

    public string MacheAbba(string a, string b)
    {
        // Erstelle eine Methode, welche die Werte a und b nimmt und diese nach dem 
        // Muster "abba" umformt
        //
        // MacheAbba("Hallo", "Na") -> "HalloNaNaHallo"
        
        return string.Empty;
    }

    public string UmgrenzeWort(string grenze, string wort)
    {
        // Gegeben ist der Wert "grenze", welcher aus 4 Buchstaben besteht. Platziere den Wert
        // "wort" in die Mitte des "grenze"-Werts.
        //
        // UmgrenzeWort("<<>>", "ichBinEinWort") -> <<ichBinEinWort>>
        //
        // Tipp: nutze die Methode Substring() z. B.:
        // string erstenBuchstaben = wort.Substring(0, 2);

        return string.Empty;
    }

    public string ErstenBeiden(string s)
    {
        // Erstelle eine Methode, die die ersten 2 Buchstaben aus dem Wert s zurückgibt.
        // Falls s aus weniger als 2 Buchstaben bestehen sollte, sollen die Lücken mit dem
        // Zeichen "@" ersetzt werden
        //
        // ErstenBeiden("Moin") -> "Mo"
        // ErstenBeiden("") -> "@@"

        return string.Empty;
    }
}