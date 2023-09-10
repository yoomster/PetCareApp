using AutoMapper;
using PetCare.API.Dtos;
using PetCare.API.Models;

namespace PetCare.API.Profiles
{
    public class PetsProfile: Profile
    {
        public PetsProfile()
        {
            //createmap from Source -> Target
            CreateMap<PetModel, PetReadDto>();
            CreateMap<PetCreateDto, PetModel>();
        }
    }
}
