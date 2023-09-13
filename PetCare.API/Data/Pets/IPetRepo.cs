using PetCare.API.Models;

namespace PetCare.API.Data.Pets
{
    public interface IPetRepo
    {
        bool SaveChanges();
        IEnumerable<PetModel> GetAllPets();
        PetModel GetPetById(int id);
        void CreatePet(PetModel pet);
        void UpdatePet(PetModel pet);
        void DeletePet(PetModel pet);

    }
}
