namespace Terning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terning1 t = new Terning1();
            t.Skriv();
            int v = t.GetVærdi();
            Console.WriteLine(v);

            Console.WriteLine();
            Terning1 t2 = new Terning1(5);
            t2.Skriv();
            Console.WriteLine(t2.GetVærdi());

            Terning1 t3 = new Terning1(1);
            t.Skriv();
            t.Ryst();
            t.SetVærdi(6);
            t.Skriv();

            Console.WriteLine("------------------");

            Terning2 t4 = new Terning2();
            t4.Skriv();

            t4.Værdi = 1;
            Console.WriteLine(t4.Værdi);
            t4.Skriv();

            var metoder = t4.GetType().GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);


        }
    }


    class Terning1
    {
        // aldrig public men private
        private int Værdi;

        // Default
        public Terning1()
        {
            this.Ryst();
        }

        public Terning1(int værdi)
        {
            SetVærdi(værdi);
        }


        public int GetVærdi()
        {
            return this.Værdi;
        }

        public void SetVærdi(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                throw new Exception("Forkert værdi");
            this.Værdi = værdi;
        }


        public void Skriv()
        {
            Console.WriteLine("[ " + this.Værdi + " ]");
        }

        public void Ryst()
        {
            this.Værdi = new Random().Next(1, 7);
        }


    }

    class Terning2
    {




        private int værdi;

        // Property (Egenskab)
        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    throw new Exception("Forkert værdi 2");
                this.værdi = value;
            }

        }


        public Terning2()
        {
            this.Ryst();
        }

        public Terning2(int værdi)
        {
            this.Værdi = værdi;
        }

        public void Skriv()
        {
            Console.WriteLine("[ " + this.værdi + " ]");
        }

        public void Ryst()
        {
            this.værdi = new Random().Next(1, 7);
        }

    }

    class Hund
    {

        private int antalBen;

        public int AntalBen
        {
            get { return antalBen; }
            set
            {

                antalBen = value;
            }
        }

        //public string Navn;
        private string _navn;

        public string Navn
        {
            get { return _navn; }
            private set
            {
                // æslkfælf 
                _navn = value;
            }
        }

        public void Test()
        {
            this.Navn = "ælkæl";
        }

        //public void Test() => this.Navn = "ælkæl";

        class Person
        {

            public int Alder { get; set; }


        }
    }
}