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
using System.Text;

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

        [HttpGet]
        public IActionResult GetPosts()
        {
          try
          {
            var res = _http.GetAsync("http://api/post").GetAwaiter().GetResult(); // set the post here to 4000
            var posts = JsonConvert.DeserializeObject<List<PostViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            return View(posts);
          }
          catch(Exception ex)
          {
            ViewBag.ErrorMessage = ex.Message;

            return View("Error");
          }
             
        }

        [HttpGet]
        public IActionResult MakePost()
        {
          //var res = _http.GetAsync("http://api/post").GetAwaiter().GetResult();
          //ViewBag.posts = JsonConvert.DeserializeObject<List<PostViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
          return View(new PostViewModel());
        }

        [HttpPost]
        public IActionResult MakePost(PostViewModel p)
        {
  
          if(String.IsNullOrEmpty(p.Body)==false)
          {
            try{

            var newpost = JsonConvert.SerializeObject(p);
            
            var content = new StringContent(newpost, Encoding.UTF8, "application/json");
            //"http://api/post/post"
            var postres = _http.PostAsync("http://api/Post", content).GetAwaiter().GetResult();
            if(postres.IsSuccessStatusCode)
            {
              var res = _http.GetAsync("http://api/Post").GetAwaiter().GetResult(); // set the post here to 4000
              var posts = JsonConvert.DeserializeObject<List<PostViewModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
              return View("Index", posts);
            }
            else
            {
              ViewBag.ErrorMessage = "api/post response was unsuccessful";
              return View("Error");
            }
            
            }
          catch(Exception ex)
            {
              ViewBag.ErrorMessage= ex.Message;
              return View("Error"); 
            } 
            

          }
          else
          {
            ViewBag.ErrorMessage = "If Null Or Empty Returned True";
            return View("Error");
          }
        }
    }
}
        