using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public class PeperoniExtraDecorator : PizzaDecorator
    {
        public PeperoniExtraDecorator(IPizza pizza) : base(pizza) { }

        public override string PizzaTipo()
        {
            string tipo = base.PizzaTipo();
            tipo += "\r\n Con extra peperoni";
            return tipo;
        }
    }

}

