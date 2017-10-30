using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Newtonsoft.Json;

namespace DllHellProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(new { From = "Console"}));
            Console.WriteLine(new Class1().Convert());
            Console.ReadLine();
        }
    }
}
