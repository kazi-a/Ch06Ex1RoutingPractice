using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null) {
                return Content("No ID supplied.");
            }
            else {
                return Content("ID: " + id);
            }
        }

        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult Countdown(int start, int end = 0, string message = "")
        {
            string contentString = "Counting down:\n";

            for (int i = start; i >= end; i--)
            {
                contentString += i + "\n";
            }

            // Append the message after the countdown is complete
            if (!string.IsNullOrEmpty(message))
            {
                contentString += message + "\n";
            }

            return Content(contentString);
        }

    }
}