using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Models;

public class PetModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; } = DateTime.Now;

    [Required]
    public string? Gender { get; set; }

    [Required]
    public DateTime PlaceableFrom { get; set; }

    [Required]
    public bool CanJoinCats { get; set; } = false;

    [Required]
    public bool CanJoinDogs { get; set; } = false;

    [Required]
    public bool Indoor { get; set; } = true;

    [Required]
    public string? PetSort { get; set; }

    [Required]
    public bool Availible { get; set; } = false;
}
