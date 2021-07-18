using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Core.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
