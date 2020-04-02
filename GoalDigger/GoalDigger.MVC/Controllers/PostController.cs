using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoalDigger.MVC.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace GoalDigger.MVC.Controllers
{
    public class PostController : Controller
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var res = _http.GetAsync("http://api/post").GetAwaiter().GetResult(); // set the post here to 4000
            var posts = JsonConvert.DeserializeObject<List<PostViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());

            return View(posts);
        }
    }
}

        