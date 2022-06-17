using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNames = new List<string>()
            {
                "Norbert Frick",
                "Matus Benus",
                "Stavri Benedikty",
                "Peter Truchly",
                "Mia Fiolekova"
            };

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
