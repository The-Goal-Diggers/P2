using System;
using System.Collections.Generic;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class FeedPostModel : AModel
    {
      public List<FeedModel> Feeds { get; set; }
      public List<PostModel> Posts { get; set; }

      private static long uid_state = 0;

      public FeedPostModel()
      {
        uid_state ++;
        uid = uid_state;
      }

    }
}
