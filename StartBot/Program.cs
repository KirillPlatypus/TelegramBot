using System;
using Telegram.Bot;
using StartBot.Bot;

namespace StartBot
{

    class Program
    {
        static ITelegramBotClient client;


        static void Main(string[] args)
        {
            client = Bot.Bot.GetClient();

            client.StartReceiving();
            Console.ReadLine();
        }
    }
}
   
