using PetCare.Models;

namespace PetCare.API.Data.Persons
{
    public interface IPersonRepo
    {
        IEnumerable<PersonModel> GetAllPersons();

        PersonModel GetPersonById(int id);
    }
}
