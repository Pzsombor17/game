using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class model
    {
        public List<game> games = new();
        private void Import()
        {
            games =File.ReadAllLines("games.txt").Select(x=> new game(x)).ToList();

        }
        public model()
        {
            Import();
        }
        public Dictionary<string,int> PublisherCount()
        {
            return games.GroupBy(x => x.Publisher).ToDictionary(x => x.Key, x => x.Count());
        }
        public Dictionary<string, int> GenreCount()
        {
            return games.GroupBy(x => x.genre).ToDictionary(x => x.Key, x => x.Count());
        }
        public Dictionary<string, double> PublisherAvgPrice()
        {
            return games.GroupBy(x => x.Publisher).ToDictionary(x => x.Key, x => x.Average(y=> y.price));
        }
        public Dictionary<string, double> GenreAvgRating()
        {
            return games.GroupBy(x => x.genre).ToDictionary(x => x.Key, x => x.Average(y=>y.rating));
        }
        public Dictionary<string, double> PublisherAvgRating()
        {
            return games.GroupBy(x => x.Publisher).ToDictionary(x => x.Key, x => x. Max(y => y.rating));
        }
        public Dictionary<string, string> MostExpensiveGameByGenre()
        {
            return games.GroupBy(x => x.genre).ToDictionary(x => x.Key, x => x.OrderByDescending(y => y.price).Select(y => y.name).First());
        }
        public List<string> PublisherMin4()
        {
            return games.GroupBy(x => x.Publisher).Where(x => x.Count()>= 4).Select(x=> x.Key).ToList();
        }


        public Dictionary<string, int> After2020Publisher()
        {
            return games.Where(x => x.year >= 2020).GroupBy(x => x.Publisher).ToDictionary(x => x.Key, x => x.Count());
        }

        public Dictionary<string, string> BestRatingGameByGenre()
        {
            return games.GroupBy(x => x.genre).Select(x => x.OrderByDescending(y => y.rating).First()).ToDictionary(x => x.genre, x=> x.name);
        }

    }
}
