using MovieRecommender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommender.ConsoleApp
{
    internal class RemoveMovie
    {
        internal static void Start(MovieList movieList)
        {
            var movies = movieList.Movies;
            var choice = GetRemoveModeSelection();
            switch (choice)
            {
                case "L":
                    RecommendMovie.DisplaySearchResults(movies);
                    var selection = GetMovieNumberSelection();
                    if (selection <= movies.Count() && GetDeleteConfirmation(movies.ElementAt(selection - 1)))
                    {
                        movieList.Delete(movies.ElementAt(selection - 1));
                        Console.WriteLine("Your movie was removed successfully!");
                    }
                    break;
                case "S":
                    while (true)
                    {
                        var searchResults = RecommendMovie.Search(movies);
                        RecommendMovie.DisplaySearchResults(searchResults);
                        if (searchResults.Count() == 1 && GetDeleteConfirmation(searchResults.First()))
                        {
                            movies.Remove(searchResults.First());
                            Console.WriteLine("Your movie was removed successfully!");
                            break;
                        }
                    }
                    break;
            }
        }

        private static string GetRemoveModeSelection()
        {
            while (true)
            {
                Console.WriteLine(Menu.Dash);
                Console.WriteLine("1. Pick a book to remove from a List [L]");
                Console.WriteLine("2. Search for a book to remove [S]");
                Console.WriteLine(Menu.Dash);

                Console.Write("Pick menu item: ");

                var input = Console.ReadLine();

                if (input != null && IsRemoveModeSelectionValid(input))
                {
                    return input.ToUpper();
                }
            }
        }

        private static bool IsRemoveModeSelectionValid(string userInput)
        {
            var validMenuSelection = new string[] { "L", "S" };

            return validMenuSelection.Contains(userInput.ToUpper());
        }

        private static int GetMovieNumberSelection()
        {
            while (true)
            {
                Console.Write("Enter a number of the movie you want to delete: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
            }
        }

        private static bool GetDeleteConfirmation(Movie movie)
        {
            while (true)
            {
                Console.WriteLine($"Are you sure you want to delete {movie.Title} [Y/N]?");
                switch (Console.ReadLine().ToUpper())
                {
                    case "Y":
                        return true;
                    case "N":
                        return false;
                    default:
                        break;
                }
            }
        }
    }
}
