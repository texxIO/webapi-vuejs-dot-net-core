using System.Collections.Generic;
using WebApiVue.Model;

namespace WebApiVue.Data
{
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
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "code 0", Line = "dotnet 0", Platform = "Windows 0" },
                new Command { Id = 1, HowTo = "code 1", Line = "dotnet 1", Platform = "Windows 1" },
                new Command { Id = 2, HowTo = "code 2", Line = "dotnet 2", Platform = "Windows 2" },
                new Command { Id = 3, HowTo = "code 3", Line = "dotnet 3", Platform = "Windows 3" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "code", Line = "dotnet", Platform = "Windows" };
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