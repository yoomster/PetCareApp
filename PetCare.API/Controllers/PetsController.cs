using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetCare.API.Data.Pets;
using PetCare.API.Dtos;
using PetCare.API.Models;

namespace PetCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        //dependency injection
        private readonly IPetRepo _repository;
        private readonly IMapper _mapper;

        public PetsController(IPetRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<PetReadDto>> GetAllPets()
        {
            var listOfPets = _repository.GetAllPets();

            return Ok(_mapper.Map<IEnumerable<PetReadDto>>(listOfPets));
        }

        [HttpGet("{id}", Name = "GetPetById")]
        public ActionResult<PetReadDto> GetPetById(int id)
        {
            var petById = _repository.GetPetById(id);
            if (petById != null)
            {
                return Ok(_mapper.Map<PetReadDto>(petById));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<PetReadDto> CreatePet(PetCreateDto petCreateDto)
        {
            var petModel = _mapper.Map<PetModel>(petCreateDto);
            _repository.CreatePet(petModel);
            _repository.SaveChanges();

            var petReadDto = _mapper.Map<PetReadDto>(petModel);

            return CreatedAtRoute(nameof(GetPetById), new { Id = petReadDto.Id }, petReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePet(int id, PetUpdateDto petUpdateDto)
        {
            var petModelFromRepo = _repository.GetPetById(id);
            if (petModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(petUpdateDto, petModelFromRepo);
            _repository.UpdatePet(petModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialPetUpdate(int id, JsonPatchDocument<PetUpdateDto> patchDoc)
        {
            var petModelFromRepo = _repository.GetPetById(id);
            if (petModelFromRepo == null)
            {
                return NotFound();
            }

            var petToPatch = _mapper.Map<PetUpdateDto>(petModelFromRepo);
            patchDoc.ApplyTo(petToPatch, ModelState);
            if (!TryValidateModel(petToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(petToPatch, petModelFromRepo);
            _repository.UpdatePet(petModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePet(int id)
        {
            var petModelFromRepo = _repository.GetPetById(id);
            if (petModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeletePet(petModelFromRepo);
            _repository.SaveChanges();

            return NoContent();

        }
    }
}
