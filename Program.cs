using System;

namespace NottyKoti
{
    class Program
    {
        int i = 7;
          static string Name = "Koti";
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Your First Run is Success");
            Console.WriteLine(p.i);
            Console.WriteLine(Name);

            NottyNani nani = new NottyNani();
            nani.Method();
            nani.Methodology();

        }
    }
}
