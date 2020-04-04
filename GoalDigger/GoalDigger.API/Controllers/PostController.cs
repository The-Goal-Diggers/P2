using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoalDigger.Domain.Models;

namespace GoalDigger.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private static readonly List<PostModel> _postmodellist = new List<PostModel>()
        {
          new PostModel() { Body = "My first #goal !!!" },
          new PostModel() { Body = "My second #goal !!!" },
        };

        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

      [HttpGet]
      public IActionResult Get()
      {
        return Ok(_postmodellist);
      }
        
    }
}
