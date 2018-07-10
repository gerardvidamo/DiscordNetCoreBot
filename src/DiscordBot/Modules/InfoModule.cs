using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class InfoModule : ModuleBase<SocketCommandContext>
    {
        [Command("info")]
        public Task Info()
            => ReplyAsync(
                $"Hello, I am a bot called {Context.Client.CurrentUser.Username} written in c# NetCore 2.0\n");
    }
}