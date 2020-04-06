using GoalDigger.DataStore.Databases;
namespace GoalDigger.Domain.Abstracts
{
  public abstract class ARepository
  {
    protected static readonly GoalDiggerDBContext dbContext = new GoalDiggerDBContext();
  }
}