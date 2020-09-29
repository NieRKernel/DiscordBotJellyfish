using DSharpPlus;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordBotAnnaJellyFish
{
    public class Program
    {
        public static DiscordClient discord;
        public static List<string> floof = new List<string>();
        public static string annamayo = "https://i.ytimg.com/vi/ZsO32V7IoDg/maxresdefault.jpg";

        static async Task Main(string[] args)
        {
            floof = new List<string>() { "https://cdn.discordapp.com/attachments/753639587745890395/756615317160984707/image7.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756615317001863334/image6.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756615316833960098/image5.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756615316632502312/image4.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756615316389363730/image3.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756615316091437144/image2.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756615315605029013/image1.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756615315231604786/image0.jpg"
            ,"https://cdn.discordapp.com/attachments/753639587745890395/756614912687472720/image1.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756614912440008784/image0.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756614813177741434/image8.jpg"
            ,"https://cdn.discordapp.com/attachments/753639587745890395/756612954451083284/image0.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756612954744422481/image1.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756612955235418222/image2.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613254478037072/image0.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613254662586429/image1.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613254918307840/image2.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613255153057962/image3.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613255434207414/image4.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613255434207414/image4.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613255694385312/image5.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613256449097829/image6.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613256717795518/image7.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613256923054130/image8.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613257107865600/image9.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613577535914024/image0.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613577703424191/image1.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613577913139261/image2.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613578148020320/image3.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613578361929850/image4.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613578525769778/image5.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613578718445608/image6.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613579175755866/image7.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613579439865936/image8.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613579700043868/image9.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613805093421097/image0.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613805336952862/image1.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613805554794536/image2.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756613805727023145/image3.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614444217401394/image0.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614444750209154/image2.jpg" ,"https://cdn.discordapp.com/attachments/753639587745890395/756614444968050758/image3.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614445299531816/image4.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614445601390642/image5.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614446058700890/image6.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756614446486388877/image7.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614446948024370/image8.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614447484895252/image9.jpg,","https://cdn.discordapp.com/attachments/753639587745890395/756614811630174300/image0.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614811936096337/image1.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614812112519298/image2.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614812301262868/image3.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614812485681152/image4.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614812611641474/image5.jpg","https://cdn.discordapp.com/attachments/753639587745890395/756614812850716862/image6.jpg", "https://cdn.discordapp.com/attachments/753639587745890395/756614813005774908/image7.jpg" };

            //
            var giphy = new Giphy(""); //Authkey you can get from Giphy
            var searchParameter = new SearchParameter()
            {
                Query = "jellyfish"
            };


            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "", //Token duh from discord
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
                    await e.Message.RespondAsync($"{gifResult.Data[result].BitlyGifUrl} {annaUser.Mention} HERE YOU HAVE CUTE JELLY");
                }

                else if (e.Message.Content.ToLower().StartsWith("!floof"))
                {
                    var random = new Random();
                    await e.Message.RespondAsync($"{floof[random.Next(floof.Count)]} Floof!");
                }

                else if (e.Message.Content.ToLower().StartsWith("!annamayo"))
                {
                    var annaUser = e.Guild.Members.Where(x => x.IsOwner).FirstOrDefault();
                    await e.Message.RespondAsync($"{annamayo} {annaUser.Mention} Mayonetta");
                }

                else if (e.Message.Content.ToLower().StartsWith("!willkernelgetcastlevaniatoday"))
                {
                    var random = new Random();
                    var nierKernel = e.Guild.Members.Where(x => x.Username == "NieR;Kernel").FirstOrDefault();
                    string textToSend = "";
                    if (random.NextDouble() >= 0.99)
                    {
                        textToSend = $"{nierKernel.Mention} will get Castlevania from Vrenna today";
                    }
                    else
                    {
                        textToSend = $"{nierKernel.Mention} will not get Castlevania from Vrenna today";
                    }
                    
                    await e.Message.RespondAsync(textToSend);
                }

                else if (e.Message.Content.ToLower().StartsWith("!help"))
                    await e.Message.RespondAsync("Type !jellyfish to give Anna a nice mention and VERY pretty jellyfish :3 \n" +
                        "!floof for gory pictures \n !willkernelgetcastlevaniatoday nier begging for game");
            };
            await discord.ConnectAsync();
            await Task.Delay(-1);

        }

    }
}
