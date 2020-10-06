using System.Collections.Generic;
using CommanderAPI.Models;

namespace CommanderAPI.Data{
    public interface ICommanderRepo{
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}