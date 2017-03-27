using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new HomePage());
            Pages.Add(new LastPage());
        }
    }
}
