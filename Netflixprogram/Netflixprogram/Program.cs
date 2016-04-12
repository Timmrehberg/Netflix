using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflixprogram
{
    class Program
    {
        static void Main(string[] args)
        {

            Movies select = new Movies();

            select.Genreprompt();

            foreach (Title moviename in select.catalog.All)
            {
                Console.WriteLine(moviename.name);

            }
            select.catalog.Aggregategenres();

            select.catalog.Aggregatelistandgenre();
        }
    }
}
