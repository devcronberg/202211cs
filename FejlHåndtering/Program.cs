

Exception r;


try
{
    //string a = null;
    //a.ToUpper();
    //string a = System.IO.File.ReadAllText(@"c:\tmp\test.txt");
    checked
    {
        byte e = 255;
        e++;
    }
}
catch (IOException ex)
{
    Console.WriteLine("Fil");
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Null");
}
catch (Exception ex)
{
    // log....
    // besked
    Console.WriteLine(ex.Message);
    r = ex;
    return;
}
finally {
    // lukke db forbindelse
    
    Console.WriteLine("Kører altid");
}
