using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            this.Icon = HeroPecApp.Properties.Resources.iconmain;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
