using System;
using System.Collections.Generic;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class MentionModel : AModel
    {
      public UserModel User { get; set; }
      public PostModel Post { get; set; }

      private static long uid_state = 0;

      public MentionModel()
      {
        uid_state ++;
        uid = uid_state;
      }

    }
}
