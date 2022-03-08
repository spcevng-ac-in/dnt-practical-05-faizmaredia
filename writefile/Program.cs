using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writefile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamWriter sw = new StreamWriter("E:\\dotNet\\dotNetPractical_5\\Sample.txt");

                sw.WriteLine("Hello Guys !!!");
                sw.WriteLine("Hello Guys !!! 2nd Line");

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
