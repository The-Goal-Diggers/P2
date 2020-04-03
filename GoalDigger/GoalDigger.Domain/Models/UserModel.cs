using System;
using System.Collections.Generic;

namespace GoalDigger.Domain.Models
{
    public class UserModel
    {
      public string UserName { get; set; }
      public List<PostModel> Posts { get; set; }
    }
}
