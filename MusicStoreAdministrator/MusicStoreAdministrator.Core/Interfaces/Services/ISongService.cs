using MusicStoreAdministrator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Core.Interfaces.Services
{
    public interface ISongService
    {
        Task<Song> GetSongById(int id);
        Task<IEnumerable<Song>> GetAll();
        Task<Song> CreateSong(Song newSong);
        Task<Song> UpdateSong(int songToBeUpdatedId, Song newSongValues);
        Task DeleteSong(int songId);
    }
}
