using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class game
    {
        public string name {get; set;}
        public string genre {get; set;}
        public string Publisher {get; set;}
        public int year {get; set;}
        public int price {get; set;}
        public double rating {get; set;}

        public game (string line)
        {
            string[] temp = line.Split(";");
            name = temp[0];
            genre = temp[1];
            Publisher = temp[2];
            year = int.Parse(temp[3]);
            price = int.Parse(temp[4]);
            rating = Convert.ToDouble(temp[5].Replace('.',','));


        }
    }
}
