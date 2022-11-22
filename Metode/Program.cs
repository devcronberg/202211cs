

Console.WriteLine();
Console.WriteLine("*");
Metode1();
Metode2(5);
Metode3(1, true, "*");
Metode4();
int res1 = Metode4();
Console.WriteLine(res1);

int res2 = Metode5(5,1);
Console.WriteLine(res2);

KortFarve res3 = Metode6(KortKulør.Hjerter);
Console.WriteLine(res3);

var res4 = Metode7(5, 7);
Console.WriteLine(res4.Sum);
Console.WriteLine(res4.Gns);

var res5 = Metode8(5, 8);
Console.WriteLine(res5.Item1);
Console.WriteLine(res5.Item2);

var res6 = Metode9(5, 8);
Console.WriteLine(res6.sum);
Console.WriteLine(res6.gns);

var res7 = Metode10(85);

//Metode11("*", 11, true, "DK");

//Metode11(navn: "Test", 
//    land: "DK", 
//    alder: 11, 
//    erSmart: true);

Test t = new Test();
int res8 = t.Metode12(1, 5, 1);
Console.WriteLine(res8);



// Du ikke bruge denne metode længere
[Obsolete(message:"Fejl.....", error: true)]
void Metode11(string navn, int alder, bool erSmart, string land)
{
}

void Metode1() {
    Console.WriteLine("Metode1");
}

void Metode2(int a)
{
    // return || Exception
    Console.WriteLine("Metode2a");
    if (a < 10)
        return;
    
    Console.WriteLine("Metode2b");

}   // return

void Metode3(int a, bool b, string c)
{
    Console.WriteLine("Metode3 " + c);
}   

int Metode4() {
    return 1;
}

int Metode5(int a, int b)
{
    return a+b;
}

KortFarve Metode6(KortKulør k)
{
    switch (k)
    {
        case KortKulør.Hjerter:
            return KortFarve.Rød;
        case KortKulør.Ruder:
            return KortFarve.Rød;
        case KortKulør.Klør:
            return KortFarve.Sort;
        case KortKulør.Spar:
            return KortFarve.Sort;
        default:
            //return KortFarve.Sort;
            throw new Exception("Forkert kulør");
    }
}

MinReturType Metode7(int a, int b) {
    MinReturType r = new MinReturType();
    r.Sum = a + b;
    r.Gns = r.Sum / 2.0;
    return r;
}

(double, double) Metode8(int a, int b)
{
    return (a + b, (a + b) / 2.0);
}

// Tuple
(double sum, double gns) Metode9(int a, int b)
{
    return (a + b, (a + b) / 2.0);
}

int Metode10(int a, int b = 10)
{
    return a + b;
}

[Serializable]
class MinReturType {
    public double Sum;
    public double Gns;
}

enum KortFarve { 
    Sort, Rød
}

enum KortKulør
{
    Hjerter, Ruder, Klør, Spar
}

class Test {
    public int Metode12(int a, int b)
    {
        return a + b;
    }

    public int Metode12(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Metode12(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }
}