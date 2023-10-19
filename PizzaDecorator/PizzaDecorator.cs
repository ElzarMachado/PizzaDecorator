using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public class PizzaDecorator : IPizza
    {
        private IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string PizzaTipo()
        {
            return _pizza.PizzaTipo();
        }
    }
    
 }

