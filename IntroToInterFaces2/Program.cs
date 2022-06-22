using System;
class Program
{
    static void Main()
    {
        mark m = new mark();

        m.Dothis();
        ((Isecond)m).Dothis();

        Isecond mm = new mark();
        mm.Dothis();
    }
}
public class mark : Ifirst, Isecond
{
    public void Dothis()
    {
        Console.WriteLine("Implementation of Ifirst.Dothis ");
    }

    int Isecond.Dothis()
    {
        Console.WriteLine("Implementation of Isecond.Dothis ");
        return 6;
    }
}

interface Ifirst
{
    void Dothis();
    
}
interface Isecond
{
    int Dothis();
}
