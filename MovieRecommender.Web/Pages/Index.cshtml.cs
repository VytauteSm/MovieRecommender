using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieRecommender.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() //this method is called, when our page loads
        {
            var a = "";
        }

        public void OnPost() //we call this method to send data for search
        {
            var query = Request.Form["findQuery"].ToString(); //we are getting query value

            var result = Program.List.SearchTitle(query);
        }
    }
}