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
    public partial class TextBoxControl : UserControl
    {
        private Color borderColor = Color.FromArgb(255, 188, 23, 27);
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public TextBoxControl()
        {
            InitializeComponent();


        }

        public Color BorderColor 
        {
            get
            { 
                return borderColor;
            } 

            set
            { 
                borderColor = value; 
                this.Invalidate();
            } 
        }
        public int BorderSize {
            get 
            { 
               return borderSize; 
            }
            set 
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get 
            {
                return underlinedStyle;
            }
            set 
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }

    }
}
