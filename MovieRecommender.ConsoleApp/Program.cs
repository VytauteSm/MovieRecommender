namespace MovieRecommender.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movieList = new MovieList();

            while(true)
            {
                var menuSelection = Menu.GetUserMenuSelection();

                switch (menuSelection) //cause our menu is predefined
                {
                    case "A":
                        AddMovieHelper.Start(movieList); //call the method
                        break;
                    case "D":
                        break;
                    case "F":
                        break;
                    case "E":
                        return;
                }
            }
            

            //movieList.Add(new Movie("Titanic"));
            //movieList.Add(new Movie("Shrek"));
            //movieList.Add(new Movie("Harry Potter 1"));
            //movieList.Add(new Movie("Harry Potter 2"));
            //movieList.Add(new Movie("Harry Potter 3"));
            //movieList.Add(new Movie("Harry Potter 4"));

            //var movies = movieList.Recommend("Titanic");

            //foreach (var item in movies)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}