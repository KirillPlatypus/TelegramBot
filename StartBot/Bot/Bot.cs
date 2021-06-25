using System;
using System.Collections.Generic;
using Telegram.Bot;
using StartBot.Commands;

namespace StartBot.Bot
{
    public class Bot
    {
        static ITelegramBotClient m_client = new TelegramBotClient(ModelBot.client) { Timeout = TimeSpan.FromSeconds(10) };

        private static List<Command> commandList = new List<Command>
        {
            new HelloThere(m_client),
            new Meme(m_client),
        };

        public static IReadOnlyList<Command> commands { get => commandList; }


        public List<Command> GetCommands() => (List<Command>)commands;

        public static ITelegramBotClient GetClient()
        {
            var i = m_client.GetMeAsync().Result;

            Console.WriteLine($"Id = {i.Id} Last name = {i.FirstName} username {i.Username}");

            foreach (var command in commands)
            {
                m_client.OnMessage += command.BotMessege;
            }

            return m_client;
        }

    }
}
   
