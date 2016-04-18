using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DotnetLazySingleton
    {
        private static readonly Lazy<DotnetLazySingleton> lazy =
        new Lazy<DotnetLazySingleton>(() => new DotnetLazySingleton());

        public static DotnetLazySingleton Instance { get { return lazy.Value; } }

        private DotnetLazySingleton()
        {
        }

    }
}
