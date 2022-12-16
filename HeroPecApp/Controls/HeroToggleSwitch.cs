using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp.Controls
{
    public partial class HeroToggleSwitch : UserControl
    {
        private bool _checked = false;
        public event Action CheckedChanged;

        public HeroToggleSwitch()
        {
            InitializeComponent();
            checkPictureBox.Click += (s, e) => CheckedChanged?.Invoke();
            textLabel.Click += (s, e) => CheckedChanged?.Invoke();
            this.Click += (s, e) => CheckedChanged?.Invoke();
        }

        public bool Checked
        {
            get => _checked;
            set
            {
                _checked = value;
                checkPictureBox.Image = value ? Properties.Resources.toggleswitchon
                : Properties.Resources.toggleswitchoff;
            }
        }

        public string Texts { get => textLabel.Text; set => textLabel.Text = value; }

        private void HeroToggleSwitch_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            checkPictureBox.Image = Checked ? Properties.Resources.toggleswitchon
                : Properties.Resources.toggleswitchoff;
        }

        private void HeroToggleSwitch_Load(object sender, EventArgs e)
        {
            checkPictureBox.Image = Checked ? Properties.Resources.toggleswitchon
                : Properties.Resources.toggleswitchoff;
        }
    }
}
