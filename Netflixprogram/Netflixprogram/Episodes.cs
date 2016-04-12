using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflixprogram
{
    class Episodes
    {

       public double rating;
        public string episodename;
        public double runningtime;

        public Episodes(string EpisodeName,double RunTime, double EpisodeRating)
        {
            rating = EpisodeRating;
            episodename = EpisodeName;
            runningtime = RunTime;
        }
  
        public Episodes()
        {

        }
    }
}
