using System.Diagnostics;
using System.Text.Json.Serialization;

namespace Indkapsling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Navn = "x";
            //p.Alder = 10;

            //Person p1 = new Person()
            //{
            //    Alder = 10,
            //    Navn = "x"
            //};

            Person p2 = new Person(10, "x", "321");
            Console.WriteLine(p2.ToString());

            Person p3 = new Person(10, "x", "sdf");

            Console.WriteLine(p2 == p3);

            //string a = "x";
            //string b = "x";
            //Console.WriteLine(a==b);


        }
    }

    record Person(int Alder, string Navn, string Adresse);


    //class Person : IEquatable<Person>
    //{


    //    public int Alder { get; init; }
    //    public string Navn { get; init; }
    //    public bool ErILive { get; set; }



    //    public Person(int alder, string navn)
    //    {
    //        this.Navn = navn;
    //        this.Alder = alder;
    //    }

    //    public override string ToString()
    //    {
    //        string json = System.Text.Json.JsonSerializer.Serialize(this);
    //        return json;
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        return Equals(obj as Person);
    //    }

    //    public bool Equals(Person other)
    //    {
    //        return other is not null &&
    //               Alder == other.Alder &&
    //               Navn == other.Navn &&
    //               ErILive == other.ErILive;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(Alder, Navn, ErILive);
    //    }

    //    public static bool operator ==(Person left, Person right)
    //    {
    //        return EqualityComparer<Person>.Default.Equals(left, right);
    //    }

    //    public static bool operator !=(Person left, Person right)
    //    {
    //        return !(left == right);
    //    }
    //}

    //class Terning {
    //    private int værdi;

    //    public int Værdi
    //    {
    //        get { return værdi; }
    //        set { værdi = value; }
    //    }

    //}

    class Terning
    {
        //public int Værdi { get; set; }
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set
            {

                værdi = value;
            }
        }


        public Terning()
        {
            this.Værdi = 6;
        }
    }

    

    class Hund
    {

        public string Navn { get; set; }
        public int AntalBen { get; set; }

    }
}