using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol =
                                System.Net.SecurityProtocolType.Tls
                                | System.Net.SecurityProtocolType.Ssl3
                                | System.Net.SecurityProtocolType.Tls
                                | System.Net.SecurityProtocolType.Tls11;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception)
            {

            }
        }
    }
}
