using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class MultiThreadedSingleton
    {
        private static volatile MultiThreadedSingleton instance;
        private static object obj = new Object();

        private MultiThreadedSingleton() { }

        public static MultiThreadedSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new MultiThreadedSingleton();
                    }
                }
                return instance;
            }
        }
    }

}
