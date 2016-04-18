using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HondaFactory : ICarFactory
    {
        public IHatchBack GetHatchBack()
        {
            return new Jazz();
        }

        public ISedan GetSedan()
        {
            return new HondaCity();
        }
    }
}
