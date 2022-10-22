using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.CompilerServices;

namespace MovieRecommender.Web.Helpers
{
    public static class SelectHelper //extention method to help to mark which item is selected
    {
        public static string IsSelected(this IHtmlHelper htmlHelper, string option, string selectedOption) //method will work with "this htmlHelper", and return string option value and will compare with string selectedOption
        {
            return option.Equals(selectedOption, StringComparison.InvariantCultureIgnoreCase)
                ? "selected" : string.Empty;
        }

        public static string GetRandomText(this string s, int length) //keyword; when called we use int length
        {
            return string.Empty;
        }
    }
}
