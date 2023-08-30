using Microsoft.EntityFrameworkCore;
using PetCare.API.Data.Pets;
using PetCare.API.Models;
using PetCare.Models;

namespace PetCare.API.Data
{
    public class PetCareContext : DbContext
    {
        public PetCareContext(DbContextOptions<PetCareContext> opt) : base(opt)
        {

        }

        public DbSet<PersonModel> People { get; set; }

        public DbSet<PetModel> Pets{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=petcare_db;User Id=root;Password=root;");
    }
}
