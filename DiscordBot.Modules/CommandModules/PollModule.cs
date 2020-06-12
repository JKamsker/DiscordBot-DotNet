using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules.CommandModules
{
    // -poll "Title" "Eins" "Zweites Zwei" "Drittens"

    public class PollModule : ModuleBase
    {
        [Command("poll")]
        public async Task CreatePoll(params string[] options)
        {
            foreach (var option in options)
            {
                await ReplyAsync(option);
            }
        }
    }
}
