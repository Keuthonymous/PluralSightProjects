using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] instructors = { "Aaron", "Fritz", "Scott", "Keith" };

            IEnumerable<string> query = from s in instructors
                                        where s.Length == 5
                                        orderby s descending
                                        select s;
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
