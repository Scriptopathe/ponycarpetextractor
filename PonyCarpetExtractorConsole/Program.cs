using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PonyCarpetExtractor;
namespace PonyCarpetExtractorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Interpreter p = new Interpreter();
            p.OnPuts = new Interpreter.PutsDelegate(Console.WriteLine);
            p.OnError = new Interpreter.PutsDelegate(Console.WriteLine);
            while(true)
            {
                Console.Write("PCE > ");
                try
                {
                    p.Eval(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }
            }
        }
    }
}
