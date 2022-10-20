using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieRecommender.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Movie> Movies { get; set; } = Enumerable.Empty<Movie>(); //our movie list initially would be empty list. We take results and asign to book property

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() //this method is called, when our page loads
        {
            var a = "";
        }

        public void OnPost() //we call this method to send data for search. This method will be executed, when we submit form in web
        {
            var query = Request.Form["findQuery"].ToString(); //we are getting query value
            var searchType = Request.Form["searchType"].ToString();

            if (searchType == "T")
            {
                Movies = Program.List.SearchTitle(query);
            } else if (searchType == "K")
            {
                Movies = Program.List.SearchKeyword(query, Movies); //need to correct?
            }
            else
            {
                throw new ArgumentException("No such search type");
            }
        }
    }
}