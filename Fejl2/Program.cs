
string a = null;

try
{
    int t = HentTalFraFil(@"c:\temp\tal.txt");
    Console.WriteLine(t);
}
catch (Exception ex)
{

    if (ex.InnerException!= null)
        Console.WriteLine(ex.InnerException.Message);
	
    Console.WriteLine(ex.Message);
	
}




try
{

}
catch (Exception e)
{
    // log
    // forædle
    throw;
}

void Test() { 

    throw new NotImplementedException();
}


int LægSammen(int a, int b) {
    if (a < 0)
    {
        throw new ArgumentException("Fejl fordi....");
    }
    try
    {
        return a + b;
    }
    catch (Exception ex)
    {
        // log...
        throw;
    }
}

// denne metode kan placeres i Program-klassen
int HentTalFraFil(string sti)
{
    try
    {
        string talSomStreng = System.IO.File.ReadAllText(sti);
        int tal = Convert.ToInt32(talSomStreng);
        return tal;
    }
    catch (Exception ex)
    {
        // log...
        //throw;
        throw new ApplicationException($"Kan ikke konvertere tal fra {sti}", ex);
    }
}

