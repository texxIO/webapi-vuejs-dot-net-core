using AutoMapper;
using WebApiVue.DTO;
using WebApiVue.Model;

namespace WebApiVue.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {   //Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}