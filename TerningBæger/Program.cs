using System.IO.Pipes;

namespace TerningBæger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bæger b = new Bæger();
            for (int i = 0; i < 10; i++)
            {
                b.Ryst();
                b.Skriv();
                Console.WriteLine(b.Point());
            }

            //Person p = new Person();
            //p.Skriv();
            //p.Antal = 1;

            Vare v = new Vare();
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms);


        }
    }

    public class Vare
    {

        private double pris;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        //public double PrisMedMoms()
        //{
        //    return this.Pris * 1.25;
        //}

        public double PrisMedMoms
        {
            get
            {
                return this.Pris * 1.25;
            }
        }


    }

    public class Bæger
    {

        Terning[] Terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                Terninger[i] = new Terning();
            }
        }

        internal void Ryst()
        {
            for (int i = 0; i < 5; i++)
            {
                Terninger[i].Ryst();
            }
        }

        internal void Skriv()
        {
            for (int i = 0; i < 5; i++)
            {
                Terninger[i].Skriv();
            }
            Console.WriteLine();
        }

        public bool ErYatzy()
        {
            // LINQ

            return false;
        }

        public bool ErToPar()
        {
            // LINQ

            return false;
        }

        public int Point()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Terninger[i].Værdi;
            }
            return sum;
        }

    }

    public class Terning
    {

        /// <summary>
        /// Initialisering
        /// </summary>
        public Terning()
        {
            this.Værdi = 1;
        }

        public int Værdi;   // 32 bit

        /// <summary>
        /// Skriver værdien ud
        /// </summary>
        public void Skriv()
        {
            Console.Write($"[ {this.Værdi} ] ");
        }

        /// <summary>
        /// Tilfældig værdi
        /// </summary>
        public void Ryst()
        {
            Random rnd = new Random();
            this.Værdi = rnd.Next(1, 7);
        }
    }

    // Console.WriteLine(p.Alder);

    public class Spiller
    {

        private int _alder;

        public int Alder
        {
            get { return _alder; }
            set { _alder = value; }
        }


    }


    


}