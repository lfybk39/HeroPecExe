using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    class HeroMessageBox
    {
        public static void Show(string message, string header = "Heropec Cloud")
        {
            new CustomMessageBox(message, header).ShowDialog();
        }

        public static bool Show(string message, MessageBoxButtons buttons)
        {
            return new CustomMessageBox(message, buttons).ShowDialog() == DialogResult.Yes;
        }
    }
}
