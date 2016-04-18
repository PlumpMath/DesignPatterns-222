using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FordFactory : ICarFactory
    {
        public IHatchBack GetHatchBack()
        {
            return new Figo();
        }

        public ISedan GetSedan()
        {
            return new Fiesta();
        }
    }
}
