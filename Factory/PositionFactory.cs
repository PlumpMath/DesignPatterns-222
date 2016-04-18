using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class PositionFactory
    {
        public static Position Get(int type)
        {
            switch (type)
            {
                case 0:
                    return new Manager();
                case 1:
                    return new Developer(); 
                default:
                    return null;
            }
        }
    }
}
