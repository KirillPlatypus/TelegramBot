using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.InputFiles;
using StartBot.Commands.MemeMaterial;

namespace StartBot.Commands
{
    class Meme : Command
    {
        List<string> inputOnlineFiles = HttpsMemePhoto.path;

        public Meme(ITelegramBotClient client) : base(client)
        {
        }

        public override string Name => "Meme";

        public async override void BotMessege(object sender, MessageEventArgs e)
        {

            var text = e.Message.Text;

            if (text == null)
                return;

            Random random = new Random();
            int randomI = random.Next(inputOnlineFiles.Count);

            if (Contains(text))
            {
                if (inputOnlineFiles.Count == 0)
                {
                    await client.SendTextMessageAsync(e.Message.Chat, $"our meme supply are over").ConfigureAwait(false);
                    return;
                }
                Console.WriteLine($"id = {randomI} exeption = {inputOnlineFiles[randomI]} count = {inputOnlineFiles.Count} text contains - {Contains(text)}");

                await client.SendPhotoAsync(e.Message.Chat, new InputOnlineFile(inputOnlineFiles[randomI]));

                inputOnlineFiles.RemoveAt(randomI);
            }
        }
    }
}
   
