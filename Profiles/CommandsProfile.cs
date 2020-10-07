using AutoMapper;
using CommanderAPI.Dtos;
using CommanderAPI.Models;


namespace CommanderAPI.Profiles
{
    public class CommandsProfile:Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command,CommandReadDto>();
        }
    }
}