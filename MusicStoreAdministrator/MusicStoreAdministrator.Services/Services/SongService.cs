using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Interfaces;
using MusicStoreAdministrator.Core.Interfaces.Services;
using MusicStoreAdministrator.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Services.Services
{
    public class SongService : ISongService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SongService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Song> CreateSong(Song newSong)
        {
            SongValidator validator = new();

            var validationResult = await validator.ValidateAsync(newSong);
            if (validationResult.IsValid)
            {
                await _unitOfWork.SongRepository.AddAsync(newSong);
                await _unitOfWork.CommitAsync();
            }
            else
            {
                throw new ArgumentException(validationResult.Errors.ToString());
            }

            return newSong;
        }

        public async Task DeleteSong(int songId)
        {
            Song song = await _unitOfWork.SongRepository.GetByIdAsync(songId);
            await _unitOfWork.SongRepository.Remove(song);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Song>> GetAll()
        {
            return await _unitOfWork.SongRepository.GetAllAsync();
        }

        public async Task<Song> GetSongById(int id)
        {
            return await _unitOfWork.SongRepository.GetByIdAsync(id);
        }

        public async Task<Song> UpdateSong(int songToBeUpdatedId, Song newSongValues)
        {
            SongValidator songValidator = new();

            var validationResult = await songValidator.ValidateAsync(newSongValues);
            if (!validationResult.IsValid)
                throw new ArgumentException(validationResult.Errors.ToString());

            Song songToBeUpdated = await _unitOfWork.SongRepository.GetByIdAsync(songToBeUpdatedId);

            if (songToBeUpdated == null)
                throw new ArgumentException("Invalid Song ID while updating");

            songToBeUpdated.Name = newSongValues.Name;
            songToBeUpdated.Duration = newSongValues.Duration;
            songToBeUpdated.ArtistId = newSongValues.ArtistId;

            await _unitOfWork.CommitAsync();

            return await _unitOfWork.SongRepository.GetByIdAsync(songToBeUpdatedId);
        }
    }
}