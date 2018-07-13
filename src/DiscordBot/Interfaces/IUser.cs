namespace DiscordBot.Interfaces
{
    public interface IUser
    {
        ulong Id { get; set; }
        int Points { get; set; }
    }
}