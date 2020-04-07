using System;
using System.Collections.Generic;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class PostModel : AModel
    {
      // Entity Relationships
      public UserModel User { get; set; }
      // public FeedPostModel FeedPost { get; set; }
      public List<MentionModel> Mentions { get; set; }
      public HashtagPostModel HashtagPost { get; set; }
      
      // Class variables
      public string Body { get; set; }

      private static long uid_state = 0;

      public PostModel()
    {
      uid_state ++;
      uid = uid_state;
    }

    }
}
