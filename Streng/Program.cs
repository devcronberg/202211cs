
{
    char a = '*';

    Console.WriteLine(a);
    Console.WriteLine(Convert.ToInt32(a));
    char h = Convert.ToChar(42);
    Console.WriteLine(h);

}

{
    string a;
    a = "a";
    a = "Kort sætning";
    a = "Noget længere sætning - i øvrigt med danske tegn";
    Console.WriteLine(a);

    string b = "**";
    string c = "**";
    Console.WriteLine(b == c);
    a = a.ToUpper();
    Console.WriteLine(a);


    //string sti = "c:\temp\test.txt";
    //string sti = "c:\\temp\\test.txt";
    string sti = @"c:\temp\test.txt";
    Console.WriteLine(sti);

    int q = 1000;
    double r = 100032.35;

    //string t = "Beløbet " + q.ToString("N2") + " og " + r.ToString("N3");
    string t = $"Beløbet {q:N2} og {r:N3}";

    Console.WriteLine(t);

}

{ 
    int a = 0;          // a indeholder værdi
    //a = null;

    string b = "a";    // b indeholder en reference
    //b = null;
    if(b != null)
        Console.WriteLine(b.ToUpper());

    // Sukker check
    Console.WriteLine(b?.ToUpper());
}

//{
//    // Stopur
//    System.Diagnostics.Stopwatch s 
//        = new System.Diagnostics.Stopwatch();
//    s.Start();
//    Console.WriteLine("Start");
//    string a = "";
//    for (int i = 0; i < 500000; i++)
//    {
//        a  = a + "*";
//    }
//    Console.WriteLine("Slut");
//    s.Stop();
//    Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
//}

{
    // Stopur
    System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
    System.Text.StringBuilder sb = new System.Text.StringBuilder();
    s.Start();
    for (int i = 0; i < 5_000_000; i++)
    {
        sb.Append("*");
    }
    s.Stop();
    Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
}