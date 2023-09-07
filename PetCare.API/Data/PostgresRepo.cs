using PetCare.API.Models;

namespace PetCare.API.Data
{
    public class PostgresRepo : Pets.IPetRepo
    {
        private readonly PetCareContext _context;

        public PostgresRepo(PetCareContext context)
        {
            _context = context;
        }
        public IEnumerable<PetModel> GetAllPets()
        {
            return _context.Pets.ToList();
        }

        public PetModel GetPetById(int id)
        {
            return _context.Pets.FirstOrDefault(p => p.Id == id);

        }
    }
}
