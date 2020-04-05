using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoalDigger.Domain.Models;
// using Newtonsoft.Json;
using System.Net.Http;

namespace GoalDigger.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PostController : ControllerBase
  {
    private readonly HttpClient _http = new HttpClient();
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

  [HttpPost]
  public IActionResult Post([FromBody] PostModel p)
  {
    _postmodellist.Add(p);
    
    return Ok();
  }
      
  }
}
