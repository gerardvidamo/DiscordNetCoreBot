using System.Threading;
using System.Threading.Tasks;
using Discord;
using DiscordBot.Interfaces;

namespace DiscordBot.Data.NoDb
{
    public class DataStore : IDataStore
    {
        Task IDataStore.InitializeAsync()
        {
            throw new System.NotImplementedException();
        }

        Task IDataStore.SaveUserAsync(
            Interfaces.IUser user, 
            CancellationToken cancellationToken
        )
        {
            throw new System.NotImplementedException();
        }

        Task IDataStore.SendPointsAsync(
            Discord.IUser user, 
            CancellationToken cancellationToken
        )
        {
            throw new System.NotImplementedException();
        }

        Task IDataStore.UpdateLevelAsync(
            Interfaces.IUser user, 
            CancellationToken cancellationToken
        )
        {
            throw new System.NotImplementedException();
        }
    }
}