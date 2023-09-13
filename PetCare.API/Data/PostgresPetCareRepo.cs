using PetCare.API.Models;

namespace PetCare.API.Data
{
    public class PostgresPetCareRepo : Pets.IPetRepo
    {
        private readonly PetCareContext _context;

        public PostgresPetCareRepo(PetCareContext context)
        {
            _context = context;
        }

        public void CreatePet(PetModel pet)
        {
            if(pet == null)
            {
                throw new ArgumentException(nameof(pet));
            }

            _context.Pets.Add(pet);
        }

        public void DeletePet(PetModel pet)
        {
            if (pet == null)
            {
                throw new ArgumentException(nameof(pet));
            }

            _context.Pets.Remove(pet);
        }

        public IEnumerable<PetModel> GetAllPets()
        {
            return _context.Pets.ToList();
        }

        public PetModel GetPetById(int id)
        {
            return _context.Pets.FirstOrDefault(p => p.Id == id);

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePet(PetModel pet)
        {
            //doesn't do anyhting since it's handled by the DbContext
        }


    }
}
