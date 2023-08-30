using PetCare.API.Models;

namespace PetCare.API.Data.Pets
{
    public interface IPetRepo
    {
        IEnumerable<PetModel> GetAllPets();

        PetModel GetPetById(int id);

    }
}
