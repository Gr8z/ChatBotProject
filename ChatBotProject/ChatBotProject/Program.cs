using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace ChatBotProject
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class ChatBot
    {
        const string UserId = "szabist";
        private Bot AimlBot;
        private User myUser;

        public ChatBot()
        {
            AimlBot = new Bot();
            myUser = new User(UserId, AimlBot);
            Initialize();
        }

        // Loads all the AIML files in the \AIML folder         
        public void Initialize()
        {
            AimlBot.loadSettings();
            AimlBot.isAcceptingUserInput = false;
            AimlBot.loadAIMLFromFiles();
            AimlBot.isAcceptingUserInput = true;
        }

        // Given an input string, finds a response using AIMLbot lib
        public String getOutput(String input)
        {
            Request r = new Request(input, myUser, AimlBot);
            Result res = AimlBot.Chat(r);
            return (res.Output);
        }
    }
}
