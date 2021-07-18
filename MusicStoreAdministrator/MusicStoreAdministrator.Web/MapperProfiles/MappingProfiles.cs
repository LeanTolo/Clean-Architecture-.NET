using AutoMapper;
using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Entities.SaveModels;
using MusicStoreAdministrator.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Web.MapperProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Entities To Models
       //     CreateMap<Artist, ArtistSaveModel>();
        //    CreateMap<Song, SongSaveModel>();
            CreateMap<Artist, ArtistViewModel>();
            CreateMap<Song, SongViewModel>();

            //Models To Entities
          //  CreateMap<ArtistSaveModel, Artist>();
        //    CreateMap<SongSaveModel, Song>();
            CreateMap<ArtistViewModel, Artist>();
            CreateMap<SongViewModel, Song>();
        }
    }
}
