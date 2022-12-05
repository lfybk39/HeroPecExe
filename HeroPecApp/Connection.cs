using HeroPecApp.ConnectionFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPecApp

{
    public static class Connection
    {
        private static ConnectionFTP.User currentUser;
        public static ConnectionFTP.User CurrentUser { get => currentUser; set => currentUser = value; }

    }
}
