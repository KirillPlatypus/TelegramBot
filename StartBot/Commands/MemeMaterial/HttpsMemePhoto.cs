using System.Collections.Generic;

namespace StartBot.Commands.MemeMaterial
{
    class HttpsMemePhoto
    {
        public static List<string> path
        {
            get
            {
                List<string> getPath = new List<string>();
                for (int i = 0; i < 23; i++)
                {
                    if (i != 6 && i != 0)
                        getPath.Add($"https://memepedia.ru/wp-content/uploads/2021/03/evergreen-memy-{i}.jpg");
                }
                getPath.Add("https://s.keepmeme.com/files/en_posts/20210331/evergreen-suez-ship-was-i-a-good-meme-yes-but-now-get-the-fuck-out-of-my-way.jpg");
                getPath.Add("https://medialeaks.ru/wp-content/uploads/2021/03/exva8f_weaavmra.jpeg");
                return getPath;
            }
        }
    }
}
   
