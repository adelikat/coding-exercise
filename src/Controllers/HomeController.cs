using CodingExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodingExercise.Controllers;

public class HomeController : Controller
{
    private readonly ISuperMarketLogger _logger;

    public HomeController(ISuperMarketLogger logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var userService = new UserService();
        var users = await userService.GetUsersAsync();

        return View(users);
    }

    public IActionResult Example()
    {
        return View();
    }
}