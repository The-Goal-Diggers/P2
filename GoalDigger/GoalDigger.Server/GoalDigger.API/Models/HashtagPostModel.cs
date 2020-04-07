using System;
using System.Collections.Generic;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class HashtagPostModel : AModel
    {
      // public string UserName { get; set; }
      public List<HashtagModel> Hashtags { get; set; }
      public List<PostModel> Posts { get; set; }

      private static long uid_state = 0;

      public HashtagPostModel()
      {
        uid_state ++;
        uid = uid_state;
      }

    }
}
