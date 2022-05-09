using Commander.Models;
using System.Collections.Generic;
using System.Linq;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        private List<Command> allCommands = new List<Command> {
                new Command { CommandId = 1, HowTo = "Boil an egg", Line="Boil Water", Platform="Kettle and Pan"},
                new Command { CommandId = 2, HowTo = "Cut Bread", Line="Get a knife", Platform="Chopping Board"},
                new Command { CommandId = 3, HowTo = "Cup of Tea", Line="Teabag in cup", Platform="Kettle and Cup"}
            };

        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {

            return allCommands;
        }

        public Command GetCommandById(int id)
        {
            Command command = allCommands.SingleOrDefault(c => c.CommandId == id);
            return command;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}
