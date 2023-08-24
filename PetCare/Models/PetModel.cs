using System.ComponentModel.DataAnnotations;

namespace PetCare.Models;

public class PetModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    
    public DateTime DateOfBirth { get; set; } = DateTime.Now;

    public string? Gender { get; set; }

    public DateTime PlaceableFrom { get; set; }

    public bool CanJoinCats { get; set; } = false;

    public bool CanJoinDogs{ get; set; } = false;

    public bool Indoor { get; set; } = true;

    public string? PetSort { get; set; }

    public bool Availible { get; set; } = false;
}
