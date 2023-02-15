bool Igraj = true;
while (Igraj)
{
    bool pravilno = false;
    Console.Clear();
    Console.WriteLine("Pozdravljeni v igri Kamen, škarje, papir!");
    Console.WriteLine("Izberite vašo potezo (kamen, škarje, papir)");
    string izbira = Console.ReadLine().ToLower();
    string[] poteze = { "kamen", "škarje", "papir" };
    while (pravilno == false)
    {
        if (izbira == "kamen" || izbira == "škarje" || izbira == "papir")
        {
            pravilno = true;
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Pozdravljeni v igri Kamen, škarje, papir!");
            Console.WriteLine("Izberite vašo potezo (kamen, škarje, papir)");
            izbira = Console.ReadLine().ToLower();
        }
    }
    string jaz = izbira;

    Random r = new Random();
    int index = r.Next(poteze.Length);
    string racunalnik = poteze[index];

    if (jaz == racunalnik)
    {
        Console.Clear();
        Console.WriteLine("REZULTAT *Neodločeno je*");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("{0} (ti)   vs   {1} (racunalnik)", jaz, racunalnik);
    }

    else if ((jaz == "kamen" && racunalnik == "škarje") || (jaz == "škarje" && racunalnik == "papir") || (jaz == "papir" && racunalnik == "kamen"))
    {
        Console.Clear();
        Console.WriteLine("REZULTAT *Zmagal si*");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("{0} (ti)   vs   {1} (racunalnik)", jaz, racunalnik);
    }

    else
    {
        Console.Clear();
        Console.WriteLine("REZULTAT *Zgubil si*");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("{0} (ti)   vs   {1} (racunalnik)", jaz, racunalnik);
    }
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Igraj spet?");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("[da] da");
    Console.WriteLine("[Karkoli drugega] ne");
    string igrajSpet = Console.ReadLine().ToLower();
    if (igrajSpet != "da")
    {
        Igraj = false;
    }

}