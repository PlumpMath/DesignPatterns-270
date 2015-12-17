using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            // із певних міркуваня, босс завжди знає, що грошей стає тільки
            // oна бригаду Z
            var team = new Team("Z");
            // також отримав список вимог, що треба буде передати бригаді
            var requirements = new List<Requirement>() { new Requirement("Cool web site"), new Requirement("Ability to book beer on site") };
            // yви повинні бути готові бути викликаним замовником
            ICommand commandX = new YouAsProjectManagerCommand(team, requirements);

            customer.AddCommand(commandX);

            // в компанії також є програміст-герой, що кодує на швидкості світла
            var heroDeveloper = new HeroDeveloper();
            // босс вирішив віддати йому проект A
            ICommand commandA = new HeroDeveloperCommand(heroDeveloper, "A");

            customer.AddCommand(commandA);

            // як тільки замовник підписує контракт із вашим боссом
            // ваша бригада і програміст-герой готові виконати все що треба
            customer.SignContractWithBoss();
        }
    }
}
