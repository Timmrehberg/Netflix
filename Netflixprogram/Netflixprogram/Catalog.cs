using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflixprogram
{
    class Catalog
    {

        public Genre romance = new Genre();
        public Genre comedy = new Genre();
        public Genre action = new Genre();
        public Genre All = new Genre();
        public void Allmovies()
        {
            comedy.titles.Add(new Title("Knocked up", 5.6, 20.33));
            All.titles.Add(new Title("Knocked up", 5.6, 20.33));
            comedy.titles.Add(new Title("Over the hedge", 5.5, 2.45));
            All.titles.Add(new Title("Over the hedge", 5.5, 2.45));
            romance.titles.Add(new Title("Dear John", 5.6, 20.33));
            All.titles.Add(new Title("Dear John", 5.6, 20.33));
            romance.titles.Add(new Title("Notebook", 2.5, 120));
            All.titles.Add(new Title("Notebook", 2.5, 120));
            comedy.titles.Add(new Title("Get Hard", 5.6, 20.33));
            All.titles.Add(new Title("Get Hard", 5.6, 20.33));
            comedy.titles.Add(new Title("Pineapple Express", 5.0, 40.50));
            All.titles.Add(new Title("Pineapple Express", 5.0, 40.50));
            action.titles.Add(new Title("Lethal Weapon", 4.5, 130));
            All.titles.Add(new Title("Lethal Weapon", 4.5, 130));
            action.titles.Add(new Title("Lethal Weapon 2", 4.3, 130));
            All.titles.Add(new Title("Lethal Weapon 2", 4.3, 130));
            action.titles.Add(new Title("Lethal Weapon 3", 4.3, 130));
            All.titles.Add(new Title("Lethal Weapon 3", 4.3, 130));
        }



        public void CreateNewGenre()
        {
            Genre RomanticComedy = romance + comedy;
            foreach (Title aggregated in RomanticComedy)
            {
                Console.WriteLine(aggregated.name + " is a romantic comedy");
            }
        }
        public void CreateActionRomance()
        {
            Genre ActionRomance = action + romance;
            foreach (Title actionromance in ActionRomance.titles)
            {
                Console.WriteLine(actionromance.name + " is a action romance");
            }
        }
      
        public void Aggregategenres()
        {
            Console.WriteLine("Pick a genre-1.Comedy,2.Action,3.Romance");
            string aggregateone = Console.ReadLine();
            Console.WriteLine("Pick a second genre");
            string aggregatetwo = Console.ReadLine();
            if (aggregateone.Equals("1") || aggregatetwo.Equals("1") && aggregatetwo.Equals("2") || aggregateone.Equals("2"))
            {
                Genre Combined = comedy + action;
                foreach (Title combined in Combined)
                {
                    Console.WriteLine(combined.name + " is a Action Comedy");
                }
            }
            else if (aggregateone.Equals("1") || aggregatetwo.Equals("1") && aggregateone.Equals("3") || aggregatetwo.Equals("3"))
            {
                Genre Combined = comedy + romance;
                foreach (Title combined in Combined)
                {
                    Console.WriteLine(combined.name + " is a Romance Comedy");
                }
            }
            else if (aggregateone.Equals("2") || aggregatetwo.Equals("2") && aggregateone.Equals("3") || aggregatetwo.Equals("3"))
            {
                Genre Combined = action + romance;
                foreach(Title combined in Combined)
                {
                    Console.WriteLine(combined.name + " is a Action Romance");
                }
            }
        }
        public void Aggregatelistandgenre()
        {
            Console.WriteLine("Pick a genre-1.Comedy,2.Action,3.Romance");
            string genrepicker = Console.ReadLine();
            Console.WriteLine("Enter a movie title");
            string moviepicker = Console.ReadLine();
            if (genrepicker.Equals("1")){
                foreach(Title title in comedy)
                {
                    Console.WriteLine(moviepicker);
                    Console.WriteLine(title.name);
                }
            } else if (genrepicker.Equals("2"))
            {
                foreach(Title title in action)
                {
                    Console.WriteLine(moviepicker);
                    Console.WriteLine(title.name);
                }
            } else if (genrepicker.Equals("3"))
            {
                foreach(Title title in romance)
                {
                    Console.WriteLine(moviepicker);
                    Console.WriteLine(title.name);
                }
            }
        }
    }
}
