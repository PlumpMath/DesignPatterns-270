using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    class Team
    {
        public string Name { get; private set; }

        public Team(string name)
        {
            Name = name;
        }

        public void CompleteProject(List<Requirement> requirements)
        {
            AnalyzeRequirements(requirements);
            foreach (var requirement in requirements)
            {
                WorkOnRequirement(requirement);
            }
        }

        private void WorkOnRequirement(Requirement requirement)
        {
            Console.WriteLine("User Story ({0}) has been completed", requirement.UserStory);
        }

        private void AnalyzeRequirements(List<Requirement> requirements)
        {
            if (requirements.Any(requirement => string.IsNullOrEmpty(requirement.UserStory)))
            {
                throw new ArgumentException("not enought information on some of the requirements...");
            }
        }
    }
}