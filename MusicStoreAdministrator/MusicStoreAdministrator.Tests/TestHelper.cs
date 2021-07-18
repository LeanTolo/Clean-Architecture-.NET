using Microsoft.EntityFrameworkCore;
using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Interfaces.Repositories;
using MusicStoreAdministrator.Infrastructure.Data;
using MusicStoreAdministrator.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Tests
{
    public class TestHelper
    {
        private readonly DbMusicContext musicContext;
        public TestHelper()
        {
            var builder = new DbContextOptionsBuilder<DbMusicContext>();
            builder.UseInMemoryDatabase(databaseName: "MusicDbInMemory");

            var dbContextOptions = builder.Options;
            musicContext = new DbMusicContext(dbContextOptions);
            // Delete existing db before creating a new one
            musicContext.Database.EnsureDeleted();
            musicContext.Database.EnsureCreated();
        }

        public IBaseRepository<Artist> GetInMemoryArtistRepository()
        {
            return new BaseRepository<Artist>(musicContext);
        }

        public void DeleteDB()
        {
            musicContext.Database.EnsureDeleted();
        }


    }
}
