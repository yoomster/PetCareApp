using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace PetCare.Models
{
    public class PersonModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [MaxLength (100)]
        public string? HouseNr { get; set; }

        [Required]
        public string? Postcode { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; } = DateTime.Now.Date;
    }
}
