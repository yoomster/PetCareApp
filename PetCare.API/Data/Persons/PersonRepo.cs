using PetCare.API.Models;
using PetCare.Models;

namespace PetCare.API.Data.Persons
{
    public class PersonRepo : IPersonRepo
    {
        public IEnumerable<PersonModel> GetAllPersons()
        {
            var persons = new List<PersonModel>
            {
                new PersonModel { Id=0, FirstName="Naomi" },
                new PersonModel { Id=1, FirstName="Adam" },
                new PersonModel { Id=2, FirstName="Ann" }
        };

            return persons;
        }

        public PersonModel GetPersonById(int id)
        {
            return new PersonModel { Id = 0, FirstName = "Yoomi" };
        }
    }
}
