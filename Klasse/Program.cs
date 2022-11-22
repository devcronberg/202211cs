namespace Klasse
{
    
    class Hund {

        public int AntalBen;
        public string Navn;

        // Default
        //public Hund()
        //{
        //    // Log
        //    // Initialisering
        //    // Sikkerhed
        //    AntalBen = 4;
        //}

        // Custom
        public Hund(int antalBen) : this(antalBen, string.Empty)
        {            
        }

        public Hund(int antalBen, string navn)
        {
            if (antalBen < 1)
                throw new ApplicationException("Fejl");
            this.AntalBen = antalBen;
            this.Navn = navn;
        }

        [Obsolete]
        public void Test() { }

    }

    class A {

        public int Værdi;
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hund h = new Hund();
            Hund h = new Hund(3);

            h.Test();


            A a = new A();
            a.Værdi = -1000;
            

            Person p1 = new Person() { Navn = "a" };
            Person p2 = new Person() { Navn = "a" };
            Console.WriteLine(p1 == p2);

            return;


            // Serialisering - rene data klasse 

            // Funktionalitet klasser

            //Person p1 = new Person();
            //p1.Alder = 1;
            //p1.Navn = "a";
            //p1.ErILive= true;

            //Person p2 = new Person() { Navn = "b", Alder = 85, ErILive = false };

            //string json = System.Text.Json.JsonSerializer.Serialize(p1);
            //File.WriteAllText(@"c:\temp\person.json", json);

            //Person p1 = System.Text.Json.JsonSerializer.Deserialize<Person>(File.ReadAllText(@"c:\temp\person.json"));

            //DateTime d = new DateTime(2022, 1, 1);
            
            //LudoTerning f = new LudoTerning();
            
            //f.Skriv();

            //Bæger b = new Bæger();
            
        }
    }

    public class Person
    {
        public string Navn { get; set; }
        public bool ErILive { get; set; }
        
        public int Alder;

     }

    public class Bæger {
        Terning[] bæger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                bæger[i] = new Terning();
            }
        }
    }

    public class Terning {

        public int Værdi { get; private set; }

        public void Ryst()
        {
            this.Værdi = new Random().Next(1, 7);
        }

        public Terning()
        {
            Ryst();
        }

        public virtual void Skriv() {
            Console.WriteLine("[ " + this.Værdi + " ]");
        }

    }

    class LudoTerning : Terning {
        public override void Skriv()
        {
            if(this.Værdi== 3) {
                Console.WriteLine("[ S ]");

            }else if(this.Værdi== 5) {
                Console.WriteLine("[ G ]");
            }else
                Console.WriteLine("[ " + this.Værdi + " ]");
        }
    }

}