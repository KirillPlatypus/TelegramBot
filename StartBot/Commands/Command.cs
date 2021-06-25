using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace StartBot.Commands
{
    public abstract class Command
    {
        protected ITelegramBotClient client;

        public Command(ITelegramBotClient client)
        {
            this.client = client;
        }
        public abstract string Name { get; }

        protected bool Contains(string command)
        {
            return Name.Contains(command.Remove(0, 1), StringComparison.OrdinalIgnoreCase) && command.Contains("/");
        }

        public abstract void BotMessege(object sender, MessageEventArgs e);
    }
}
   
