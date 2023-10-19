using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class QuesoPizzaDecorator : PizzaDecorator
    {
        public QuesoPizzaDecorator(IPizza pizza) : base(pizza) { }

        public override string PizzaTipo()
        {
            string tipo = base.PizzaTipo();
            tipo += "\r\n con extra queso";
            return tipo;
        }
    }
    
}

