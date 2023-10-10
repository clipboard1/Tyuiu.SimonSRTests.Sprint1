using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SimonSRTests.Sprint99.Task99.V99;
using Tyuiu.SimonSRTests.Sprint99.Task99.V99.Lib;

namespace Tyuiu.SimonSRTests.Sprint99.Task99.V99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine(File.ReadAllText(ds.GenerateTxtFile()));
            Console.WriteLine(ds.GenerateTxtFile());
            Console.ReadKey();
        }
    }
}