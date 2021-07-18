using MusicStoreAdministrator.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MusicStoreAdministrator.Tests.RepositoryTests
{
    //fixture
    public class ArtistsFixture 
    {
        public TestHelper testHelper => new TestHelper();

        public Artist artistTest => new Artist()
        {
            Id = 1,
            Name = "Artist 1",
            SurName = "Surname 1"
        };   

        public IEnumerable<Artist> allArtistsTest => new List<Artist>
        {
            new Artist{
                Id = 1,
                Name = "Artist 1",
                SurName = "Surname 1"
            },
            new Artist{
                    Id = 2,
                    Name = "Artist 2",
                    SurName = "Surname 2"
            },
            new Artist
            {
                Id = 3,
                Name = "Artist 3",
                SurName = "Surname 3"
            },
            new Artist
            {
                Id = 4,
                Name = "Artist 4",
                SurName = "Surname 4"
            }
        };

    }
    public class ArtistRepositoryTest : IDisposable, IClassFixture<ArtistsFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ArtistsFixture _artistsFixture;
        private readonly MemoryStream _memoryStream;

        public ArtistRepositoryTest(ITestOutputHelper testOutputHelper, ArtistsFixture artistsFixture)
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

        [Fact]
        [Trait("Category", "Repository")]
        public async Task Verify_Artist_Add_And_Get_By_Id_NotNull_And_Equal_Object_Test()
        {
            //Arrange          
            Artist expectedArtist = _artistsFixture.artistTest;

            // Repositories with InMemory Database
            var artistRepo = _artistsFixture.testHelper.GetInMemoryArtistRepository();

            // use Write Repository to add mock data
            await artistRepo.AddAsync(expectedArtist);

            var result = artistRepo.GetByIdAsync(1).Result;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedArtist, result);
        }

        [Fact]
        [Trait("Category", "Repository")]
        public async Task Verify_Artist_Add_Range_And_Get_All_NotNull_And_Equal_Object_Test()
        {
            //Arrange          
            IEnumerable<Artist> expectedArtists = _artistsFixture.allArtistsTest;

            // Repositories with InMemory Database
            var artistRepo = _artistsFixture.testHelper.GetInMemoryArtistRepository();

            // use Write Repository to add mock data
            await artistRepo.AddRangeAsync(expectedArtists);

            var result = artistRepo.GetAllAsync().Result;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedArtists, result);
        }

        [Fact]
        [Trait("Category", "Repository")]
        public async Task Verify_Artist_Add_Remove_And_Get_By_Id_Null_And_NotEqual_Object_Test()
        {
            //Arrange          
            Artist expectedArtist = _artistsFixture.artistTest;

            // Repositories with InMemory Database
            var artistRepo = _artistsFixture.testHelper.GetInMemoryArtistRepository();

            
            await artistRepo.AddAsync(expectedArtist);
            await artistRepo.Remove(expectedArtist);

            var result = artistRepo.GetByIdAsync(1).Result;

            // Assert
            Assert.Null(result);
            Assert.NotEqual(expectedArtist, result);
        }

        [Fact]
        [Trait("Category", "Repository")]
        public async Task Verify_Artist_Add_Range_Remove_Range_And_Get_All_Null_And_NOTEqual_Object_Test()
        {
            //Arrange          
            IEnumerable<Artist> expectedArtists = _artistsFixture.allArtistsTest;

            // Repositories with InMemory Database
            var artistRepo = _artistsFixture.testHelper.GetInMemoryArtistRepository();

            // use Write Repository to add mock data
            await artistRepo.AddRangeAsync(expectedArtists);
            await artistRepo.RemoveRange(expectedArtists);

            var result = artistRepo.GetAllAsync().Result;

            // Assert
            Assert.Null(result);
            Assert.NotEqual(expectedArtists, result);
        }




    }
}
