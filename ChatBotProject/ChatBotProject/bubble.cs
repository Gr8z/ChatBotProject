using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotProject
{
    public partial class bubble : UserControl
    {
        public bubble()
        {
            InitializeComponent();
        }
        public bubble(string message, msgtype messagetype)
        {
            InitializeComponent();
            lblmessgae.Text = message;

            if (messagetype.ToString() == "In")
            {
                //incoming message
                this.BackColor = Color.FromArgb(0, 164, 147);
            }
            else
            {
                //Outgoing Message
                this.BackColor = Color.Gray;
            }

            Setheight();
        }

        private void bubble_Load(object sender, EventArgs e)
        {

        }

        void Setheight()
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lblmessgae.Text, lblmessgae.Font, lblmessgae.Width);

            lblmessgae.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
        }

        private void bubble_Resize(object sender, EventArgs e)
        {
            Setheight();
        }

        private void lblmessgae_Click(object sender, EventArgs e)
        {

        }
    }
    public enum msgtype
    {
        In,
        Out
    }
}
