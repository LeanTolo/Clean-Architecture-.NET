using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Core.Entities
{
    public class Artist
    {
        public Artist()
        {
            Songs = new Collection<Song>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
