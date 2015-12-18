using System.Collections.Generic;
using System.Linq;

namespace Interpreter
{
    class GoodsPackage : Goods
    {
        public List<Goods> GoodsInside { get; set; }
        public override int Interpret(CurrentPricesContext context)
        {
            return GoodsInside.Sum(goods => goods.Interpret(context));
        }
    }
}