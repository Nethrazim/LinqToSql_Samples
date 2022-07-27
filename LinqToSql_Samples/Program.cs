using LinqToSql_Samples.Basic;
using System;

namespace LinqToSql_Samples
{
    internal class Program
    {
        Where sample1 = new Where();
        static void Main(string[] args)
        {
            new Populate.Populate().Run();
            new Program().Run();
            Console.ReadKey();
        }

        public void Run()
        {
            sample1.Run();
        }
    }
}
