using System.Net;

namespace AvType1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (int a, double b, bool c, string d) a =
                (4, 54.32, true, "");
            Console.WriteLine(a.Item1);
            Console.WriteLine(a.Item2);
            Console.WriteLine(a.Item3);
            Console.WriteLine(a.Item4);

            Console.WriteLine(a.a);
            Console.WriteLine(a.b);
            Console.WriteLine(a.c);
            Console.WriteLine(a.d);

            var r = LægSammen(5, 6);
            Console.WriteLine(r.Sum);
            Console.WriteLine(r.Gns);
            Console.WriteLine(r.Antal);
            Console.WriteLine(r.Item1);
            Console.WriteLine(r.Item2);
            Console.WriteLine(r.Item3);

        }

        //static MinRetur LægSammen(int a, int b) {
        //    return new MinRetur { Gns = (a + b) / 2.0, Sum = a + b };
        //}

        //static MinRetur LægSammen(int a, int b)
        //{
        //    return new MinRetur(a + b, (a + b) / 2.0);
        //}

        static (int Sum, double Gns, int Antal) LægSammen(int a, int b)
        {
            return (a + b, (a + b) / 2.0, 2);
        }
    }
    //record MinRetur(int Sum, double Gns);

    //class MinRetur {
    //    public int Sum { get; set; }
    //    public double Gns { get; set; }
    //}
}