using MovieRecommender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommender.ConsoleApp
{
    internal class FindRecommendationHelper
    {
        public static void Start(MovieList movieList)
        {
            var movies = movieList.Movies;
            SearchResults(Search(movies)); //method for showing results. We let method to complete itself, so we dont need return
        }

        public static IEnumerable<Movie> Search(IEnumerable<Movie> movies)
        {
            Console.WriteLine("Which category would you like to search in?");
            var option = GetSearch();
            Console.Write("Enter a query: ");
            var query = Console.ReadLine();

            var result = Enumerable.Empty<Movie>(); //we dont have to asign any value

            if (query != null)
            {
                switch (option)
                {
                    case "T":
                        result = SearchTitle(query, movies); //adjusted data types (use Enumerable)
                        break;
                    case "G":
                        result = SearchGenre(query, movies);
                        break;
                    case "K":
                        result = SearchKeyword(query, movies);
                        break;
                }
            }

            if (!result.Any()) //we dont need to know specific number of results and works quicker than Count
            {
                Console.WriteLine("Nothing found");
            }
            return result;
        }

        public static void SearchResults(IEnumerable<Movie> results)
        {
            Console.WriteLine("Results:"); //we print out movies. Still says Results when nothing is found.
            //for (int i = 0; i <results.Count(); i++)
            //{
            //    Console.WriteLine($"{i + 1}. {results.ElementAt(i).Title}");
            //}

            int j = 1; //initial value
            foreach (var item in results)
            {
                Console.WriteLine($"{j}. {item.Title}");
                ++j;
            }
        }

        private static string GetSearch()
        {
            while (true)
            {
                Console.WriteLine(Menu.Dash);
                Console.WriteLine("1 - Title [T]");
                Console.WriteLine("2 - Keywords [K]");
                Console.WriteLine("3 - Genre [G]");
                Console.WriteLine(Menu.Dash);

                Console.WriteLine("Select: ");

                var input = Console.ReadLine();

                if (input != null && SearchValidation(input))
                {
                    return input.ToUpper();
                }
            }
        }

        //private static string GetSearch()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine(Menu.Dash);
        //    }
        //}
        private static bool SearchValidation(string userInput)
        {
            var validMenuSelection = new string[] { "T", "K", "G" };

            return validMenuSelection.Contains(userInput.ToUpper());
        }

        private static IEnumerable<Movie> SearchTitle(string query, IEnumerable<Movie> movies)
        {
            return movies.Where(x => x.Title.Contains(query, StringComparison.InvariantCultureIgnoreCase)); //linq
        }
    private static IEnumerable<Movie> SearchKeyword(string query, IEnumerable<Movie> movies)
    {
            return movies.Where(x => x.Keywords.Any(z => z.Contains(query, StringComparison.InvariantCultureIgnoreCase))); //we are looking with Any
    }

    private static IEnumerable<Movie> SearchGenre(string query, IEnumerable<Movie> movies)
        {
            return movies.Where(x => x.Genre.ToString().Contains(query, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
