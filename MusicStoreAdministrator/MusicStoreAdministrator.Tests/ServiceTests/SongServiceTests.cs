using Moq;
using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Interfaces.Repositories;
using MusicStoreAdministrator.Core.Interfaces.Services;
using MusicStoreAdministrator.Services.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MusicStoreAdministrator.Tests.ServiceTests
{
    //fixture
    public class SongsFixture
    {
        
    }

    public class SongServiceTests : IDisposable, IClassFixture<ArtistsFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ArtistsFixture _artistsFixture;
        private readonly MemoryStream _memoryStream;

        public SongServiceTests(ITestOutputHelper testOutputHelper,ArtistsFixture artistsFixture)
        {
            _testOutputHelper = testOutputHelper;
            _artistsFixture = artistsFixture;

            _testOutputHelper.WriteLine("Constructor Song Service Tests Working");

            _memoryStream = new MemoryStream();
        }
        public void Dispose()
        {
            _memoryStream.Dispose();
        }


        
    }
}
