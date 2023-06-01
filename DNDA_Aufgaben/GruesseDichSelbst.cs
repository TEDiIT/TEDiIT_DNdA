namespace DNDA_Aufgaben;

public class GruesseDichSelbst
{
    private string _name;
    
    public GruesseDichSelbst(string name)
    {
        _name = name;
        Gruesse();
    }

    private void Gruesse()
    {
        Console.WriteLine("Hallo " + _name);
    }
}