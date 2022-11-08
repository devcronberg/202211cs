using System.ComponentModel.DataAnnotations.Schema;
{
    //int antal = 10;
    int antal = 10;
    // instans
    Console.WriteLine(antal.ToString());

    //Thread.Sleep(5000);

    // Statisk
    Console.WriteLine(int.MinValue);


    double d = 10.23;
    bool t = true;

    Console.WriteLine(t.ToString());


    // statiske
    Console.WriteLine(DateTime.Now);

}

{
    int a = 0;
    int b = 10000000;


    double c = 10000000010.23;
    double d = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;
    Console.WriteLine(d);

    Console.WriteLine(10/3);

    Console.WriteLine(a);
    a = a + 1;
    a++;
    a += 1;
    
    a += 5;
    a = a + 5;

    Console.WriteLine(a);

}

{
    int a = 10;
    Console.WriteLine($"a = {a}");
    a = a + 10;
    Console.WriteLine($"a = {a}");
    a += 10;
    Console.WriteLine($"a = {a}");

    int b = 50;
    Console.WriteLine($"b = {b}");
    b = b - 10;
    Console.WriteLine($"b = {b}");
    b -= 10;
    Console.WriteLine($"b = {b}");

    int c = 10;
    Console.WriteLine($"c = {c}");
    c = c * 2;
    Console.WriteLine($"c = {c}");
    c *= 2;
    Console.WriteLine($"c = {c}");

    int d = 10;
    Console.WriteLine($"d = {d}");
    d++;
    Console.WriteLine($"d = {d}");

    int e = 10;
    Console.WriteLine($"e = {e}");
    e--;
    Console.WriteLine($"e = {e}");

    int f = 1;
    if (f++ == 1)
    {
        Console.WriteLine($"f = 1");
    }
    // nu er f = 2

    if (--f == 1)   // f = 1 igen (før check)
    {
        Console.WriteLine($"f = 1");
    }
}

//checked
//{
//    byte b = 255;
//    Console.WriteLine($"b={b}");
//    b++;
//    b++;
//    b++;
//    Console.WriteLine($"b={b}");
//}

{ 

    bool a = true;
    System.Boolean b = true;

    //if ((a == true && b == false) || a == b) { }
    if ((a && !b) || a == b) { }

    
}

{
    System.DateTime a = new System.DateTime();
    Console.WriteLine(a);

    System.DateTime b = new System.DateTime(2022, 5, 10);
    Console.WriteLine(b);

    System.DateTime c = new System.DateTime(2022, 5, 10, 10,25,30);
    Console.WriteLine(c);

    System.DateTime d = System.DateTime.UtcNow;
    Console.WriteLine(d);

    Console.WriteLine(d.Year);
    Console.WriteLine(d.Month);
    Console.WriteLine(d.Minute);

    Console.WriteLine(d);
    d = d.AddDays(10);
    d = d.AddDays(-5);
    d = d.AddMinutes(1000);
    Console.WriteLine(d);
    Console.WriteLine(d.ToString());
    Console.WriteLine(d.ToShortDateString());
    Console.WriteLine(d.ToLongDateString());


    
    Console.WriteLine();

    Console.WriteLine(b);
    Console.WriteLine(d);
    
    Console.WriteLine(DateTime.Now.AddDays(1).AddDays(-1));
     

    TimeSpan e = d - b;
    Console.WriteLine(e.TotalDays);


}