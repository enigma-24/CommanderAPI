using System.Collections.Generic;
using CommanderAPI.Models;

namespace CommanderAPI.Data
{
    // used for initial setup and testing, replaced by SqlCommanderRepo
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id = 0, HowTo = "Copy Line", Line = "Press Ctrl + C", Platform = "Windows"},
                new Command{Id = 1, HowTo = "Cut Line", Line = "Press Ctrl + X", Platform = "Mac OS"},
                new Command{Id = 2, HowTo = "Paste Line", Line = "Press Ctrl + V", Platform = "Linux"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo = "Copy Line above", Line = "Press Ctrl + C", Platform = "Windows"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}