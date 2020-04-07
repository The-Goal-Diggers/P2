using System;
using System.Collections.Generic;
using GoalDigger.Domain.Abstracts;

namespace GoalDigger.Domain.Models
{
    public class HashtagModel : AModel
    {
      public HashtagPostModel HashtagPost { get; set; }

      private static long uid_state = 0;

      public HashtagModel()
      {
        uid_state ++;
        uid = uid_state;
      }

    }
}
