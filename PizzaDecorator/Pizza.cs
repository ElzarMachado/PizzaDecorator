using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public class Pizza : IPizza
    {
        public string PizzaTipo()
        {
            return "Pizza orilla de queso";
        }   
    }
    
}

