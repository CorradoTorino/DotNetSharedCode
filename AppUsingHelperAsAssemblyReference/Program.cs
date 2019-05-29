using System;
using Helper;

namespace AppUsingHelperAsAssemblyReference
{
    static class Program
    {
        static void Main(string[] args)
        {
            Run(args);
        }

        public static void Run(string[] args)
        {
            GuardClauses.IsNotEmpty(args, "args");

            Console.WriteLine("This <Hello World> use GuardClauses referencing Helper.dll");
            Console.WriteLine("Listing arguments:");
            foreach (var arg in args)
            {
                Console.WriteLine($" - {arg}");
            }
        }
    }
}
