//#define TERSE
#define VERBOSE
using System;
using System.Diagnostics;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            TersePrinter();
            VerbosePrinter();
            TerseVerbosePrinter();
        }

        [Conditional("TERSE")]
        static void TersePrinter()
        {
            Console.WriteLine("Printing a terse coditional");
        }

        [Conditional("VERBOSE")]
        static void VerbosePrinter()
        {
            Console.WriteLine("Verbose statement");
        }


        [Conditional("VERBOSE"), Conditional("TERSE")]
        static void TerseVerbosePrinter()
        {
            Console.WriteLine("Terse and Verbose statement");
        }


    }
}
