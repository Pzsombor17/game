namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            model Model = new model();
            foreach (KeyValuePair<string, int> item in Model.PublisherCount())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (KeyValuePair<string, int> item in Model.GenreCount())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (KeyValuePair<string, double> item in Model.PublisherAvgPrice())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (KeyValuePair<string, double> item in Model.GenreAvgRating())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (KeyValuePair<string, double> item in Model.PublisherAvgRating())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            foreach (KeyValuePair<string, string> item in Model.MostExpensiveGameByGenre())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Model.PublisherMin4().ForEach(x => Console.WriteLine(x));
            foreach(KeyValuePair<string, string>item in Model.BestRatingGameByGenre())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
