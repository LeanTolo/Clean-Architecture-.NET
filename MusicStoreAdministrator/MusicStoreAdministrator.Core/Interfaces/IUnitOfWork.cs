using MusicStoreAdministrator.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        ISongRepository SongRepository { get; }
        IArtistRepository ArtistRepository { get; }

        Task<int> CommitAsync();
    }
}
