using System.Collections.Generic;
using System.Linq;
using GoalDigger.API.GoalDiggerDBContext;

namespace GoalDigger.API.Repositories
{
  public class GoalDiggerRepository
  {
    private GoalDiggerContext _db;

    public GoalDiggerRepository(GoalDiggerContext dbContext)
    {
      _db = dbContext;
    }

    // public IEnumerable<T> Create<T>(T model) where T : class
    // {
    //   return _db.Set<T>();
    // }

    public IEnumerable<T> Read<T>() where T : class
    {
      return _db.Set<T>();
    }

    public object CheckAccount(string user, string pass)
    {
      return new object();
    }
  }
}