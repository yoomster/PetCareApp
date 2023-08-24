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
        
        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? HouseNr { get; set; }

        public string? Postcode { get; set; }

        public string? City { get; set; }

        public string? Email { get; set; }

        public int PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; } = DateTime.Now;
    }
}
