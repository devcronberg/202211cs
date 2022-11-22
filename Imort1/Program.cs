namespace Imort1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hund h1 = new Hund(4, "x", 10);
            Hund h2 = new Hund(4, "x", 11);
            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h1 == h2);


        }
    }


    partial class A {
        public void Test() { }
    }

    partial class A {
        public void Test2() { }
    }

    record Hund(int Antalben, string Navn, int Alder);

    

    


    //class Hund : IEquatable<Hund?>
    //{

    //    public int AntalBen { get; init; }
    //    public string Navn { get; init; }

    //    public Hund(int antalBen, string navn)
    //    {
    //        AntalBen = antalBen;
    //        Navn = navn;
    //    }

    //    public override string ToString()
    //    {
    //        return System.Text.Json.JsonSerializer.Serialize(this);
    //    }

    //    public override bool Equals(object? obj)
    //    {
    //        return Equals(obj as Hund);
    //    }

    //    public bool Equals(Hund? other)
    //    {
    //        return other is not null &&
    //               AntalBen == other.AntalBen &&
    //               Navn == other.Navn;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(AntalBen, Navn);
    //    }

    //    public static bool operator ==(Hund? left, Hund? right)
    //    {
    //        return EqualityComparer<Hund>.Default.Equals(left, right);
    //    }

    //    public static bool operator !=(Hund? left, Hund? right)
    //    {
    //        return !(left == right);
    //    }
    //}

}