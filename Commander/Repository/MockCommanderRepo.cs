using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id = 0, HowTo="Cut bread", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id = 0, HowTo="Make a cup of tea", Line="Boil water", Platform="Kettle & Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo="Boil an egg", 
                Line="Boil water", 
                Platform="Kettle & Pan"
            };
        }
    }
}