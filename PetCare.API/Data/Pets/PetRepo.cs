using PetCare.API.Models;

namespace PetCare.API.Data.Pets
{
    public class PetRepo : IPetRepo
    {
        public IEnumerable<PetModel> GetAllPets()
        {
            var pets = new List<PetModel>
            {
                new PetModel { Id=0, Name="Teddy" },
                new PetModel { Id=1, Name="Snuggly" },
                new PetModel { Id=2, Name="Balou" }
        };

            return pets;
        }

        public PetModel GetPetById(int id)
        {
            return new PetModel { Id = 0, Name = "Teddy" };
        }
    }
}
