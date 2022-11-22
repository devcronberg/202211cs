using System.Runtime.InteropServices;

namespace Indkapsling3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hund h = new Hund();

            var p = h.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            var m = h.GetType().GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);


            //h.SetAntalBen(4);
            h.AntalBen = 4;
            h.Navn = "fido";
            //Console.WriteLine(h.GetAntalBen());
            Console.WriteLine(h.AntalBen);
            h.Skriv();
            
            Console.WriteLine(h.NavnMedStort);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(h));

            Person pe = new Person() { Adresse = "æladskf" };

            var f = pe.GetType().GetFields( System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance );



        }
    }

    class Hund
    {
        

        private int antalBen;    // 32

        public int AntalBen
        {
            get
            {
                return this.antalBen;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ApplicationException("Forkerte ben");
                }

                this.antalBen = value;
            }

        }


        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public string NavnMedStort {
            get
            {
                return this.navn.ToUpper();
            }
        }

        public string KorrektNavn
        {
            get
            {
                return this.navn.Substring(0, 1).ToUpper() + this.navn.Substring(1);
            }
        }

        private bool erILive;

        public bool ErILive
        {
            get { return erILive; }
            set { erILive = value; }
        }





        //public int GetAntalBen() {
        //    // sikkerhed
        //    // log
        //    return this.antalBen;
        //}

        public void Skriv()
        {
            Console.WriteLine(this.antalBen);
        }

        //public void SetAntalBen(int value)
        //{
        //    if (value < 0 || value > 5)
        //    {
        //        throw new ApplicationException("Forkerte ben");
        //    }
        //    this.antalBen = value;
        //}


        public Hund()
        {
            this.antalBen = 4;
            this.navn = string.Empty;
        }

        public Hund(int antalBen, string navn)
        {
            this.AntalBen = antalBen;
            this.navn = navn;
        }
    }


    class Person {

        private int alder;

        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }


        private bool _erILive;

        public bool ErIlive
        {
            get { return _erILive; }
            set { _erILive = value; }
        }

        //private string adresse;

        //public string Adresse
        //{
        //    get { return adresse; }
        //    init { adresse = value; }
        //}

        public string Adresse { get; set; }
        //public int Årgang { get; set; }

        private int årgang;

        public int Årgang
        {
            get { return årgang; }
            set { 
                //
                årgang = value; }
        }

        public DateTime Fødselsdato { get; set; }



    }

    class Faktura {
        public int Id { get; set; }
        public string Kunde { get; set; }
        public List<string> Varer { get; set; }
    }

    class Terning {

        public int Værdi { get;  set; }
    }

    class A {
        public int Aa { get; set; }
        public string Bb { get; set; }

    }

}