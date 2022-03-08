using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("E:\\dotNet\\dotNetPractical_5\\Sample.txt");

                //Read the first line of text
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
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
