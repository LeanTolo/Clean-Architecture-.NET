using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Interfaces.Repositories;
using MusicStoreAdministrator.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Services.Services
{
    public class ArtistService : BaseService<Artist>, IArtistService
    {
        public ArtistService(IBaseRepository<Artist> _baseRepository) : base(_baseRepository)
        {

        }
    }
}
