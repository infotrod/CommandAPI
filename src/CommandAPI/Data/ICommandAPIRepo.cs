using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommnd(Command cmd);
        void UpdateCommnd(Command cmd);
        void DeleteCommnd(Command cmd);
    }
}