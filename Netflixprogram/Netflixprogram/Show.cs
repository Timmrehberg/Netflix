using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflixprogram
{
    class Show : Title
    {
        public List<Episodes> episodelist = new List<Episodes>();
        public List<Title> TVShows = new List<Title>();
        public Episodes episode = new Episodes();
        public int numberofEpisodes;
        public int runtime;
        Episodes Walkingdeadepisode1 = new Episodes("Days gone by", 60, 9.5);


        public Show(string Name, int numberofepisodes, double Rating, int Runtime)
        {
            name = Name;
            rating = Rating;
            numberofEpisodes = numberofepisodes;
            runtime = Runtime;
           
        }
        public void Allshows()
        {
            TVShows.Add(new Show("Fear the Walking Dead", 12, 10.0, 60));


            TVShows.Add(new Show("Walking Dead", 120, 10.0, 60));
            TVShows.Add(new Show("Breaking Bad", 210, 9.5, 60));

        }
        public Show()
        {

        }
        public void Whichshow()
        {
            Console.WriteLine("Which shows episodes would you like to review");
            string showpicker = Console.ReadLine();
            if(showpicker.Equals("Walking Dead"))
            {
                episodelist.Add(Walkingdeadepisode1);
                foreach(Episodes episode in episodelist)
                {
                    Console.WriteLine("Title for this episode is " + episode.episodename + " Runtime for this episode is " + episode.runningtime);
                    break;
                }
                
            }
        }
        public override string ToString()
        {
            return "Title " + name + " number of episodes - " + numberofEpisodes;

        }


    }
} 
