using System;
using System.Collections.Generic;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class UserModel : AModel
    {
      // Entity relationships
      public List<GoalModel> Goals { get; set; }
      public List<PostModel> Posts { get; set; }
      public List<MentionModel> Mentions { get; set; }
      // public virtual FeedModel Feed { get; set; }

      // Class variables
      public string UserName { get; set; }

      private static long uid_state = 0;

      public UserModel()
      {
        uid_state ++;
        uid = uid_state;
      }

    }
}
