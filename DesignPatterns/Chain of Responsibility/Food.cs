using System.Collections.Generic;

namespace Chain_of_Responsibility
{
    class Food
    {
        public Food(string name, List<string> ingradients)
        {
            Name = name;
            Ingradients = ingradients;
        }

        public List<string> Ingradients { get; private set; }

        public string Name { get; private set; }
    }
}