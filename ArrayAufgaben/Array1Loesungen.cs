namespace ArrayAufgaben;

public class Array1Loesungen
{
    public int FirstValue(int[] arr)
    {
        // Erstelle eine Methode, welche die erste Zahl aus einem Array aus ints zurückgibt
        //
        // FirstValue(new[] {2, 4, 7}) -> 2

        return arr[0];
    }
    
    public bool FourAppears(int[] arr)
    {
        // Erstelle eine Methode, die true zurückgibt, wenn an der ersten Stelle oder an
        // der letzten Stelle sich eine 4 befindet. Die Methode soll false zurückgeben wenn das Array leer ist
        // Tipp: mit arr.Length kannst du die Länge eines Arrays herausfinden
        //
        // FourAppears(new[] {3 ,4, 5}) -> false
        // FourAppears(new[] {4, 7, 9}) -> true

        if (arr.Length == 0)
            return false;
        
        var letzteZahl = arr[arr.Length - 1];
        
        return letzteZahl == 4 || arr[0] == 4;
    }

    public bool TwoAppears(int[] arr)
    {
        // Erstelle eine Methode, die prüft, ob nach dem ersten int im Array eine 2 vorkommt
        // Falls das Array kleiner als 2 ist, soll die Methode false zurückgeben
        //
        // TwoAppears(new[] {4, 2}) -> true
        // TwoAppears(new[] {4}) -> false

        if (arr.Length < 2)
            return false;
        
        return arr[1] == 2;
    }
}