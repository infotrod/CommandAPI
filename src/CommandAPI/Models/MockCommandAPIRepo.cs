using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommnd(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommnd(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command 
                {
                    Id = 0,
                    HowTo = "How to generate migration",
                    CommandLine = "dotnet ef migration add <Name of Migration>",
                    Platform = ".Net Core EF"
                },
                new Command 
                {
                    Id = 1,
                    HowTo = "Run migration",
                    CommandLine = "dotnet ef database update",
                    Platform = ".Net Core EF"
                },
                new Command 
                {
                    Id = 2,
                    HowTo = "List active migrations",
                    CommandLine = "dotnet ef migrations list add <Name of Migration>",
                    Platform = ".Net Core EF"
                }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {
                Id = 0,
                HowTo = "How to generate migration",
                CommandLine = "dotnet ef migration add <Name of Migration>",
                Platform = ".Net Core EF"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommnd(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}