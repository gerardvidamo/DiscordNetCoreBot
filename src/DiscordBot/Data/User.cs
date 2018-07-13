using DiscordBot.Interfaces;

namespace DiscordBot.Data
{
    public class User : IUser
    {
        public ulong Id { get; set; }
        public int Points { get; set; }
    }
}