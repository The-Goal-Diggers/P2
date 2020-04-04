using System;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class PostModel : AModel
    {
      public UserModel User { get; set; }
      public string Body { get; set; }

      private static long uid_state = 0;

      public PostModel()
    {
      uid_state ++;
      uid = uid_state;
    }

    }
}
