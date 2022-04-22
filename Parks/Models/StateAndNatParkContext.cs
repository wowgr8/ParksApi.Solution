using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
  public class StateAndNatParkContext : DbContext
  {
    public StateAndNatParkContext(DbContextOptions<StateAndNatParkContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<StateAndNatPark>()
        .HasData(
          new StateAndNatPark { StateAndNatParkId = 1, Name = "Yosimite", Type = "National Park", LocationByState = "California" },
          new StateAndNatPark { StateAndNatParkId = 2, Name = "Yellowstone", Type = "National Park", LocationByState = "Wyoming" },
          new StateAndNatPark { StateAndNatParkId = 3, Name = "Arches", Type = "National Park", LocationByState = "Utah" },
          new StateAndNatPark { StateAndNatParkId = 4, Name = "Palo Duro Canyon", Type = "State Park", LocationByState = "Texas" },
          new StateAndNatPark { StateAndNatParkId = 5, Name = "Chimney Rock", Type = "State Park", LocationByState = "North Carolina" },
          new StateAndNatPark { StateAndNatParkId = 6, Name = "Porcupine Mountains Wilderness", Type = "State Park", LocationByState = "Michigan" }
        );
    }

    public DbSet<StateAndNatPark> StateAndNatParks { get; set; }
  }
}