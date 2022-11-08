using System;
using System.Globalization;
using Humanizer;

namespace NuGetTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sæt kultur (ikke fuld oversat)
            System.Threading.Thread.
                CurrentThread.CurrentUICulture =
                new CultureInfo("da-DK");

            string a = DateTime.Now.AddDays(-10).Humanize();
            Console.WriteLine(a);

            string c = "Lang tekst som skal forkortes".Truncate(15, " ...");
            Console.WriteLine(c);

            TimeSpan d = TimeSpan.FromMinutes(60);
            Console.WriteLine(d.Humanize());

            Console.WriteLine((360.0).ToHeading(HeadingStyle.Full));
            Console.WriteLine((130.0).ToHeading(HeadingStyle.Full));

        }
    }
}