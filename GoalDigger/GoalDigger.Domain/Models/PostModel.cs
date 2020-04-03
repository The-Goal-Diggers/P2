using System;

namespace GoalDigger.Domain.Models
{
    public class PostModel
    {
      public UserModel User { get; set; }
      public string Body { get; set; }
    }
}
