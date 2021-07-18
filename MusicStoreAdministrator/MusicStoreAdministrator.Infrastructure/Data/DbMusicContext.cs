using Microsoft.EntityFrameworkCore;
using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Infrastructure.Data
{
    public class DbMusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public DbMusicContext(DbContextOptions<DbMusicContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ArtistConfiguration());
            builder.ApplyConfiguration(new SongConfiguration());
        }
    }
}
