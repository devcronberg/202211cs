Thread.CurrentThread.CurrentCulture =
    new System.Globalization.CultureInfo("da-DK");

//Thread.CurrentThread.CurrentCulture =
//    new System.Globalization.CultureInfo("en-GB");

//Thread.CurrentThread.CurrentCulture =
//    new System.Globalization.CultureInfo("en-US");



double tal = 20034.3347;

Console.WriteLine(tal);

string s = tal.ToString();
Console.WriteLine(s);

Console.WriteLine(tal.ToString("N2"));
Console.WriteLine(tal.ToString("N3"));
Console.WriteLine(tal.ToString("F2"));
Console.WriteLine(tal.ToString("C2"));

double p = 0.25;
Console.WriteLine(p.ToString("P2"));

System.DateTime d = System.DateTime.UtcNow;
Console.WriteLine(d.ToString("yyyy-MM-dd"));
Console.WriteLine(d.ToLongDateString());