using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LazySingleton
    {
        private static LazySingleton instance;

        private LazySingleton()
        {

        }

        public static LazySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazySingleton();
                }
                return instance;
            }
        }

    }
}
