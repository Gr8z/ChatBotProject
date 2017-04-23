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
                outputTxt.AppendText("YOU: \n" + InputTxt.Text + Environment.NewLine);
                outputTxt.AppendText("BOT: \n" + bot.getOutput(InputTxt.Text) + Environment.NewLine);
                Console.Beep();
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
                    outputTxt.AppendText("YOU: \n" + InputTxt.Text + Environment.NewLine);
                    outputTxt.AppendText("BOT: \n" + bot.getOutput(InputTxt.Text) + Environment.NewLine);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    Console.Beep();
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