using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class StaticSingleton
    {
        private static readonly StaticSingleton instance = new StaticSingleton();

        private StaticSingleton() { }

        public static StaticSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
