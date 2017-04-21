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
        }

        static ChatBot bot;
        private void Form1_Load(object sender, EventArgs e)
        {
            bot = new ChatBot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTxt.AppendText("YOU: \n" + InputTxt.Text + Environment.NewLine);
            outputTxt.AppendText("BOT: \n" + bot.getOutput(InputTxt.Text) + Environment.NewLine);
        }
    }
}