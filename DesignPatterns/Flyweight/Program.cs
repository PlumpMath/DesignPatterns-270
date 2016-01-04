using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public static class FlyweightDemo
    {
        public static void Main()
        {
            var units = new Parser().ParseHTML();
        }
    }

}
