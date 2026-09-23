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

    }
}
