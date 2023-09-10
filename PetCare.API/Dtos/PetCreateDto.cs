using System.ComponentModel.DataAnnotations;

namespace PetCare.API.Dtos
{
    public class PetCreateDto
    {
        [Required]
        public string? Name { get; set; }

        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Required]
        public string? Gender { get; set; }

        [Required]
        public DateTime PlaceableFrom { get; set; }

        public bool CanJoinCats { get; set; } = false;

        public bool CanJoinDogs { get; set; } = false;

        public bool Indoor { get; set; } = true;

        [Required] 
        public string? PetSort { get; set; }

        public bool Availible { get; set; } = false;
    }
}
