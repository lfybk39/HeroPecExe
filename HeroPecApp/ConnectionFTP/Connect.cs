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
            builder.Database = "ftp";
            builder.UserID = "heropecadmin";
            builder.Password = "5356dbd3651165dae79fb664c05f311a";
            builder.Server = "91.122.211.144";
            builder.Port = 53306;
            return builder.ConnectionString;
        }
        public HeroPeCContext(string conStr) : base(new MySqlConnection(conStr), true)
        { }
        public DbSet<User> User { get; set; }

    }

}
