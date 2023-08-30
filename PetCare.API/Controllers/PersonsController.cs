using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetCare.API.Data.Persons;
using PetCare.Models;

namespace PetCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepo _repository;

        public PersonsController(IPersonRepo repository)
            {
                _repository = repository;
            }


            [HttpGet]
            public ActionResult<IEnumerable<PersonModel>> GetAllPersons()
            {
                var commandItems = _repository.GetAllPersons();

                return Ok(commandItems);
            }

            [HttpGet("{id}")]
            public ActionResult<PersonModel> GetPersonById(int id)
            {
                var commandItems = _repository.GetPersonById(id);

                return Ok(commandItems);
            }
        }
}
