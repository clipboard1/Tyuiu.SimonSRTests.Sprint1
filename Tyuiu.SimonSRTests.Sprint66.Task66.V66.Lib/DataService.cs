using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint66;

namespace Tyuiu.SimonSRTests.Sprint66.Task66.V66.Lib
{
    public class DataService : ISprint66Task66V66
    {
        public string GenerateByteTxtFile()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\hello.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write("101");
            }
            return path;
        }
    }
}
