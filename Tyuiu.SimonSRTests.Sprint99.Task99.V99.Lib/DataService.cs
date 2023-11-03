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
            string result = (5*5).ToString();
            f.WriteLine(result);
            f.Close();
            return path;
        }
    }
}
