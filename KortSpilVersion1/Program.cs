

// Kort 1
KortKulør kort1Kulør = KortKulør.Hjerter;
KortVærdi kort1Værdi = KortVærdi.To;

// Kort 2
KortKulør kort2Kulør = KortKulør.Spar;
KortVærdi kort2Værdi = KortVærdi.Es;

// Kort 3
KortKulør kort3Kulør = KortKulør.Ruder;
KortVærdi kort3Værdi = KortVærdi.Es;

if (kort1Værdi == KortVærdi.To)
{
    Console.WriteLine("Kort 1 er en to'er");
}

if (kort2Kulør == KortKulør.Spar)
{
    Console.WriteLine("Kort 2 er en spar");
}

if (kort2Værdi == kort3Værdi)
{
    Console.WriteLine($"Både værdien af kort 2 og kort 3 er: {kort2Værdi.ToString()}");
}

enum KortFarve
{
    Sort,
    Rød
}

enum KortKulør
{
    Spar, Klør, Hjerter, Ruder
}

enum KortVærdi
{
    To,
    Tre,
    Fire,
    Fem,
    Seks,
    Syv,
    Otte,
    Ni,
    Ti,
    Knægt,
    Dame,
    Konge,
    Es
}