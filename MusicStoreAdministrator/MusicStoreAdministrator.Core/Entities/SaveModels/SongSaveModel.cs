﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Core.Entities.SaveModels
{
    public class SongSaveModel
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int ArtistId { get; set; }
    }
}

