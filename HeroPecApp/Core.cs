using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPecApp
{
    sealed class Core
    {
        private static readonly HeroDBEntities context = new HeroDBEntities();
        public static HeroDBEntities Context { get => context; }
    }
}
