using System.Collections.Generic;
using System.Linq;
using GoalDigger.API.GoalDiggerDBContext;

namespace PizzaBox.Storage.Repositories
{
  public class GoalDiggerRepository
  {
    private GoalDiggerContext _db;

    public GoalDiggerRepository(GoalDiggerContext dbContext)
    {
      _db = dbContext;
    }

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