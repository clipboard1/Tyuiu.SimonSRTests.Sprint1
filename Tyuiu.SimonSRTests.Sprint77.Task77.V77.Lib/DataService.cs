using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint77;

namespace Tyuiu.SimonSRTests.Sprint77.Task77.V77.Lib
{
    public class DataService : ISprint77Task77V77
    {
        public string GenerateByteTxtFile()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\hello.txt";
            byte[] bytes = Encoding.ASCII.GetBytes("101");
            File.WriteAllBytes(path, bytes);
            return path;
        }
    }
}
