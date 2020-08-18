using DSharpPlus;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotAnnaJellyFish
{
    public class Program
    {
        public static DiscordClient discord;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            var giphy = new Giphy("");
            var searchParameter = new SearchParameter()
            {
                Query = "jellyfish"
            };


            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "",
                TokenType = TokenType.Bot

            });

            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower().StartsWith("!jellyfish"))
                {
                    var random = new Random();
                    var gifResult = await giphy.GifSearch(searchParameter);
                    var result = random.Next(gifResult.Data.Length);
                    var annaUser = e.Guild.Members.Where(x => x.IsOwner).FirstOrDefault();
                    await e.Message.RespondAsync($"{gifResult.Data[result].BitlyGifUrl} {annaUser.Mention} HERE YOU HAVE CUTE JELLY" );
                }

                else if (e.Message.Content.ToLower().StartsWith("!help"))
                    await e.Message.RespondAsync("Type !jellyfish to give Anna a nice mention and VERY pretty jellyfish :3");
            };



            await discord.ConnectAsync();
            await Task.Delay(-1);

        }



    }
}
