using CodingExercise.Models;
using CodingExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodingExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var homeService = new HomeService();
            var users = await homeService.GetUsersAsync();

            return View(new IndexViewModel
            {
                Users = users,
            });
        }

        public IActionResult Example()
        {
            return View();
        }
    }
}