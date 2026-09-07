using System.ComponentModel.DataAnnotations;

namespace DoodleDuel.Utility;

public class GameSettings
{
    [Required]
    [Range(5, 10, ErrorMessage = "Unit count must be between 5 and 10.")]
    public int UnitCount { get; set; } = 5;
    public string Background { get; set; } = "default-bg.jpg";
}
