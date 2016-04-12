using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflixprogram
{
    class Movies 
    {
        public Catalog catalog = new Catalog();
        Show show = new Show();
        Title movietitles = new Title();
        


       

        
        public void Genreprompt()
        {
            catalog.Allmovies();
            show.Allshows();


            Console.WriteLine("Pick your genre or type shows to list all the available TV shows");
            string genrepicker = Console.ReadLine();
            if (genrepicker.Equals("Comedy"))
            {
                foreach (Title movie in catalog.comedy.titles)
                {
                    Console.WriteLine(movie.name);

                }

            }
            else if (genrepicker.Equals("Romance"))
            {
                foreach (Title movie in catalog.romance.titles)
                {
                    Console.WriteLine(movie.name);
                }
            }
            else if (genrepicker.Equals("Action"))
            {
                foreach (Title movie in catalog.action.titles)
                {
                    Console.WriteLine(movie.name);
                }
            }
            else if (genrepicker.Equals("TV shows"))
            {
                foreach (Show tvshows in show.TVShows)
                {
                    Console.WriteLine("The name is " + tvshows.name + " rating is " + tvshows.rating + " number of episodes is " + tvshows.numberofEpisodes);

                }
            }
        }
        public override string ToString()
        {
            return "Title " + movietitles.name + " Time " + movietitles.time;

        }
    }
}

