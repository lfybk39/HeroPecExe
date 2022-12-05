using HeroPecApp.ConnectionFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPecApp

{
    public static class Core
    {
        private static HeroPeCContext context;
        public static HeroPeCContext Context { get => context ?? (context = new HeroPeCContext(HeroPeCContext.StrConnection())); }

    }

}
