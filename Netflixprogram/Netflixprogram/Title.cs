using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflixprogram
{
    public class Title
    {
        public string name;
        public double rating;
        public double time;



        public Title(string Name, double Rating, double Time)
        {
            name = Name;
            rating = Rating;
            time = Time;

        }
        public Title()
        {
            name = null;
            double? rating = null;
            double? time = null;
        }
        public static Title operator +(Title a, Title b)
        {
            Title twotitledgenre = new Title();

            twotitledgenre.Equals(a.name);
            twotitledgenre.Equals(b.name);



            return twotitledgenre;
        }
    }
}
 