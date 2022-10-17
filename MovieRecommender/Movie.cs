

namespace MovieRecommender
{
    public class Movie
    {
        public Movie(string title)
        {
            Title = title;
        }

        public Movie()
        {
        }

        public string Title { get; set; }

        public GenreEnum Genre { get; set; }

        public string[] Keywords { get; set; }

        public int Rating { get; set; }

        public override string ToString()
        {
            return $"{Title}\n{Genre}";
        }


    }
}
