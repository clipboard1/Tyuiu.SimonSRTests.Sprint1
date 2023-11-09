using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint99;

namespace Tyuiu.SimonSRTests.Sprint99.Task99.V99.Lib
{
    public class DataService : ISprint99Task99V99
    {
        public string GenerateTxtFile()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\hello.txt";
            StreamWriter f = new StreamWriter(path);
            string result = "1;2;3\r\n4;5;6\r\n7;8;9";
            f.WriteLine(result);
            f.Close();
            return path;
        }
    }
}
