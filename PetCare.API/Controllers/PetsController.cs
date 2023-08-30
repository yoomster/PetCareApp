using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetCare.API.Data.Pets;
using PetCare.API.Models;

namespace PetCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetRepo _repository;

        public PetsController(IPetRepo repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<PetModel>> GetAllPets()
        {
            var commandItems = _repository.GetAllPets();

            return Ok(commandItems) ;
        }

        [HttpGet("{id}")]
        public ActionResult <PetModel> GetPetById (int id)
        {
            var commandItems = _repository.GetPetById(id);

            return Ok(commandItems);
        }
    }
}
