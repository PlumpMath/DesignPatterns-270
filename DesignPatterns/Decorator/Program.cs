using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public static class DecoratorDemo
    {
        public static void Main()
        {
            var doctorsDream = new AmbulanceCar(new Mersedes());
            doctorsDream.Go();
        }
    }
}

