using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint88;

namespace Tyuiu.SimonSRTests.Sprint88.Task88.V88.Lib
{
    public class DataService : ISprint88Task88V88
    {
        public string ReadTxtFile()
        {
            string result = System.IO.File.ReadAllText(@"C:\TestFiles\Test1.txt").Trim(); //Будем держать файлы на диске С в подготовленной папке.
            return result;
        }
    }
}
