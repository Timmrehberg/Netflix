using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflixprogram
{
    class Genre : IEnumerable
    {



        public List<Title> titles = new List<Title>();
        public IEnumerator<Title> GetEnumerator()
        {
            Console.WriteLine("All movies are");
            foreach (Title title in titles)
            {
                yield return title;

            }


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return null;
        }


        public static Genre operator +(Genre a, Genre b)
        {
            Genre aggregatedGenre = new Genre();
            aggregatedGenre.titles.AddRange(a.titles);
            aggregatedGenre.titles.AddRange(b.titles);
            //foreach(Title newlist in aggregatedGenre)
            //{
            //    Console.WriteLine(newlist.name);
            //}


            return aggregatedGenre;
        }
        public static Genre operator +(Genre a, Title b)
        {
            Genre aggregatedtitleandgenre = new Genre();
            aggregatedtitleandgenre.titles.AddRange(a.titles);
            aggregatedtitleandgenre.titles.Add(b);



            return aggregatedtitleandgenre;



        }
    }
}
    





