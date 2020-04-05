using System;
using System.Collections.Generic;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class FeedModel : AModel
    {
      public UserModel User { get; set; }
      public FeedPostModel FeedPost { get; set; }

      private static long uid_state = 0;

      public FeedModel()
      {
        uid_state ++;
        uid = uid_state;
      }

    }
}
