using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoalDigger.MVC.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace GoalDigger.MVC.Controllers
{
  public class HomeController : Controller
  {
    private readonly HttpClient _http = new HttpClient();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

        [HttpGet]
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(UserViewModel user)
    {
      //get users from db. and run login. 

      //on successful login, show post index page
      var res = _http.GetAsync("http://api/Post").GetAwaiter().GetResult(); // set the post here to 4000
      var posts = JsonConvert.DeserializeObject<List<PostViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
      return View("GetPosts",posts);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
