using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;
using System.Media;

namespace ChatBotProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = InputTxt;
            InputTxt.Focus();

        }

        static ChatBot bot;
        private void Form1_Load(object sender, EventArgs e)
        {
            bot = new ChatBot();
            using (WelcomeScreen wlcm = new WelcomeScreen())
            {
                wlcm.ShowDialog();
                outputTxt.AppendText("BOT: Hello, I'm your ChatBot! \n");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(InputTxt.Text)))
            {
                SoundPlayer Send = new SoundPlayer("SOUND1.wav");
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav");
                outputTxt.AppendText("YOU: \n" + InputTxt.Text + Environment.NewLine);
                Send.Play();
                string outtt = bot.getOutput(InputTxt.Text);
                var t = new Timer();
                t.Interval = 1000 + (outtt.Length * 100); //Don't remove (Saad)
                //t.Interval = 1;
                txtTyping.Show();
                t.Tick += (s, d) =>
                {
                    outputTxt.AppendText("BOT: \n" + outtt + Environment.NewLine);
                    txtTyping.Hide();
                    Rcv.Play();
                    t.Stop();
                };
                t.Start();
                InputTxt.Text = "";
                InputTxt.Focus();
            }
            else
            {
                InputTxt.Focus();
            }
        }

        private void InputTxt_TextChanged(object sender, EventArgs e)
        {

        }



        private void outputTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(string.IsNullOrWhiteSpace(InputTxt.Text)))
                {
                    SoundPlayer Send = new SoundPlayer("SOUND1.wav");
                    SoundPlayer Rcv = new SoundPlayer("SOUND2.wav");
                    outputTxt.AppendText("YOU: \n" + InputTxt.Text + Environment.NewLine);
                    Send.Play();
                    string outtt = bot.getOutput(InputTxt.Text);
                    var t = new Timer();
                    //t.Interval = 1000 + (outtt.Length * 100); Don't remove (Saad)
                    t.Interval = 1;
                    txtTyping.Show();
                    t.Tick += (s, d) =>
                    {
                        outputTxt.AppendText("BOT: \n" + outtt + Environment.NewLine);
                        txtTyping.Hide();
                        Rcv.Play();
                        t.Stop();
                    };
                    t.Start();  
                    
                    e.SuppressKeyPress = true;
                    InputTxt.Text = "";
                    InputTxt.Focus();
                }
                else
                {
                    InputTxt.Focus();
                }
            }
        }
    }
}