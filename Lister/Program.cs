internal class Program
{
    private static void Main(string[] args)
    {

        List<int> a = new List<int>();
        a.Add(1);

        List<Terning> b = new List<Terning>();
        List<string> c = new List<string>();
        List<List<int>> d = new List<List<int>>();


        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        int y = stack.Pop();


        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        int u = q.Dequeue();


        //Dictionary<string, int> d = new Dictionary<string, int>();
        //d.Add("a", 1);
        //d.Add("a", 221);
        //d.Add("b", 2);
        //d.Add("c", 3);

        //int p = d["c"];

        List<DateTime> gg = new List<DateTime>() 
            { new DateTime(2022, 1, 1)
            , new DateTime(2023, 1, 1) };


        List<int> v = new List<int>() { 5, 1, 10, 5, 6, 3, 1, 10, 10, 5 };

        // LINQ

        var w = v.Where(i => i < 7).OrderBy(x => x).GroupBy(x => x);

        foreach (var item in w)
        {
            Console.WriteLine(item.Key);
            foreach (var item2 in item)
            {
                Console.WriteLine("\t" + item2);
            }
        }




    }

    class Terning { }

    class Garage<T>
    {

    }

    class Bil { }
    class MotorCykel { }
}