using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DiscordBot.Interfaces
{
    public interface IDataStore
    {
        Task InitializeAsync();

        Task SaveUserAsync(
            DiscordBot.Interfaces.IUser user,
            CancellationToken cancellationToken = default(CancellationToken)
        );

        Task UpdateLevelAsync(
            DiscordBot.Interfaces.IUser user,
            CancellationToken cancellationToken = default(CancellationToken)
        );

        Task SendPointsAsync(
            Discord.IUser user,  
            CancellationToken cancellationToken = default(CancellationToken)
        ); 
    }
}