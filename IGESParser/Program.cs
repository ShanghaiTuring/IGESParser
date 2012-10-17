using System;
using System.IO;

namespace IGESParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            var igs = File.ReadAllText(args[0]);
            var parser = new Parser(igs);
            Console.WriteLine(parser.GetLineCount());
            Console.WriteLine(parser.GetGlobalInfo());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
