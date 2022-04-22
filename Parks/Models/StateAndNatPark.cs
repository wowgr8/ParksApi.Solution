using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
  public class StateAndNatPark
  {
    public int StateAndNatParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [StringLength(13, ErrorMessage = "Type must be 'National park' or 'State Park'.")]
    public string Type { get; set; }
    [Required]
    public string LocationByState { get; set; }
  }
}