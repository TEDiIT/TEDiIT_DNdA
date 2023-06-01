namespace StringAufgaben;

public class String1Loesungen
{
    public string HalloName(string name)
    {
        // Erstelle eine Methode, welche den Parameterwert "name" mit "Hallo" grüßt
        //
        // HalloName("Muster") -> "Hallo Muster"

        return "Hallo " + name;
    }

    public string MacheAbba(string a, string b)
    {
        // Erstelle eine Methode, welche die Werte a und b nimmt und diese nach dem 
        // Muster "abba" umformt
        //
        // MacheAbba("Hallo", "Na") -> "HalloNaNaHallo"
        
        return a+b+b+a;
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

        var erstenBuchstaben = grenze.Substring(0, 2);
        var letztenBuchstaben = grenze.Substring(2, 4);

        return erstenBuchstaben + wort + letztenBuchstaben;
    }

    public string ErstenBeiden(string s)
    {
        // Erstelle eine Methode, die die ersten 2 Buchstaben aus dem Wert s zurückgibt.
        // Falls s aus weniger als 2 Buchstaben bestehen sollte, sollen die Lücken mit dem
        // Zeichen "@" ersetzt werden
        //
        // ErstenBeiden("Moin") -> "Mo"
        // ErstenBeiden("") -> "@@"

        if (s.Length == 1)
            return s + "@";

        if (s.Length == 0)
            return "@@";

        var erstenBeiden = s.Substring(0, 2);

        return erstenBeiden;
    }
}