//do we need this?

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieRecommender.Web.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public string SearchType { get; set; } = "T"; //represents search by title

        public string SelectedGenre { get; set; } //a method for IndexWithJs.cshtml

        public string SearchQuery { get; set; } //a method for IndexWithJs.cshtml
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}