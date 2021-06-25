using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace StartBot.Commands
{
    class HelloThere : Command
    {

        public HelloThere(ITelegramBotClient client) : base(client)
        {
        }

        public override string Name => "Hello there!";

        public async override void BotMessege(object sender, MessageEventArgs e)
        {
            var text = e.Message.Text;

            if (text == null)
                return;

            if (Contains(text))
            {
                Console.WriteLine($"text = {text} id = {e.Message.Chat.Id} text contains - {Contains(text)}");
                await client.SendTextMessageAsync(e.Message.Chat, $"{Name}").ConfigureAwait(false);
            }
        }
    }
}
   
