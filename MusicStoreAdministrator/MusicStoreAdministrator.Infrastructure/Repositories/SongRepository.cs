using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Interfaces.Repositories;
using MusicStoreAdministrator.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Infrastructure.Repositories
{
    public class SongRepository : BaseRepository<Song>, ISongRepository
    {
        public SongRepository(DbMusicContext context) : base(context)
        {

        }
    }
}
