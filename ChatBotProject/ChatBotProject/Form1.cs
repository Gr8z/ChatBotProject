﻿using System;
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
            bbl_old.Top = 0 - bbl_old.Height + 10;
        }

        private void showOutput()
        {
            if (!(string.IsNullOrWhiteSpace(InputTxt.Text)))
            {
                SoundPlayer Send = new SoundPlayer("SOUND1.wav");
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav");
                addInMessage(InputTxt.Text);
                Send.Play();
                string outtt = bot.getOutput(InputTxt.Text);
                var t = new Timer();
                //t.Interval = 1000 + (outtt.Length * 100); //Don't remove (Saad)
                t.Interval = 1;
                txtTyping.Show();
                InputTxt.Enabled = false;
                t.Tick += (s, d) =>
                {
                    InputTxt.Enabled = true;
                    addOutMessage(outtt);
                    txtTyping.Hide();
                    Rcv.Play();
                    InputTxt.Focus();
                    t.Stop();
                };
                t.Start();
                InputTxt.Text = "";
                
            }
            else
            {
                InputTxt.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showOutput();
        }

        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showOutput();
                e.SuppressKeyPress = true;
            }
        }
        
        bubble bbl_old = new bubble();
        public void addInMessage(string message)
        {
            bubble bbl = new ChatBotProject.bubble(message, msgtype.In);
            bbl.Location = bubble1.Location; bbl.Left += 50; // add indent
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);
            bbl.Focus();

            bbl_old = bbl;  // save the last added object

        }
        public void addOutMessage(string message)
        {
            bubble bbl = new ChatBotProject.bubble(message, msgtype.Out);
            bbl.Location = bubble1.Location; 
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);
            bbl.Focus();

            bottom.Top = bbl.Bottom + 50;

            bbl_old = bbl;  // save the last added object

        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}