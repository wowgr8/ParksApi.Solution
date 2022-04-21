using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
  public class StateAndNatParkContext : DbContext
  {
    public StateAndNatParkContext(DbContextOptions<StateAndNatParkContext> options)
      : base(options)
    {
    }

      public DbSet<StateAndNatPark> StateAndNatParks { get; set; }
  }
}