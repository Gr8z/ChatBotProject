using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotProject
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();

            timer1.Start();

        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
        }
        int duration = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Show();
            duration--;
            lbltimer2.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
