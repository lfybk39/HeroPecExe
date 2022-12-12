using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPecApp.ConnectionFTP
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class HeroPeCContext : DbContext
    {

        static public string StrConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Database = Properties.Settings.Default.Database;
            builder.UserID = Properties.Settings.Default.DBUserID;
            builder.Password = Properties.Settings.Default.DBUserPassword;
            builder.Server = Properties.Settings.Default.ServerIP;
            builder.Port = Properties.Settings.Default.ServerPort;
            return builder.ConnectionString;
        }
        public HeroPeCContext(string conStr) : base(new MySqlConnection(conStr), true)
        { }
        public DbSet<User> User { get; set; }

    }

}
