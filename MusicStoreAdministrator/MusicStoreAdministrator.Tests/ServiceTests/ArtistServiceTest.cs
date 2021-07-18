using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using MusicStoreAdministrator.Core.Entities;
using MusicStoreAdministrator.Core.Interfaces.Repositories;
using MusicStoreAdministrator.Core.Interfaces.Services;
using MusicStoreAdministrator.Infrastructure.Data;
using MusicStoreAdministrator.Infrastructure.Repositories;
using MusicStoreAdministrator.Services.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MusicStoreAdministrator.Tests.ServiceTests
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

    public class ArtistServiceTest : IDisposable, IClassFixture<ArtistsFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ArtistsFixture _artistsFixture;
        private readonly MemoryStream _memoryStream;

        public ArtistServiceTest(ITestOutputHelper testOutputHelper, ArtistsFixture artistsFixture)
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

        //GET BY ID TEST - FINISH

        [Fact] //implementamos fact para avisar que es un nuevo test
        [Trait("Category", "Service")] //trait es para categorizar los tests
        public async Task Verify_Artist_Get_By_Id_NotNull_And_Equal_Object_Test()
        {
            //Arrange
            Artist expectedArtist = _artistsFixture.artistTest;

            var artistRepositoryMock = new Mock<IArtistRepository>();
            artistRepositoryMock.Setup(m => m.GetByIdAsync(1).Result)
                 .Returns(expectedArtist)
                 .Verifiable();

            IArtistService artistService = new ArtistService(artistRepositoryMock.Object);
            //Act
            var actual = await artistService.GetByIdAsync(1);

            //Assert
            artistRepositoryMock.Verify();//verify that GetByID was called based on setup.
            Assert.NotNull(actual);//assert that a result was returned
            Assert.Equal(expectedArtist, actual);//assert that actual result was as expected

        }

        //GET ALL TEST

        [Fact] //implementamos fact para avisar que es un nuevo test
        [Trait("Category", "Service")] //trait es para categorizar los tests
        public async Task Verify_Artist_Get_All_NotNull_And_Equal_Object_Test()
        {
            //Arrange
            IEnumerable<Artist> expectedArtists = _artistsFixture.allArtistsTest;

            var artistRepositoryMock = new Mock<IArtistRepository>();
            artistRepositoryMock.Setup(m => m.GetAllAsync().Result)
                 .Returns(expectedArtists)
                 .Verifiable();

            IArtistService artistService = new ArtistService(artistRepositoryMock.Object);
            //Act
            var all = await artistService.GetAllAsync();          

            //Assert
            artistRepositoryMock.Verify();//verify that GetAllAsync was called based on setup.
            Assert.NotNull(all);//assert that a result was returned
            Assert.Equal(expectedArtists, all);//assert that actual result was as expected

        }

        [Fact]
        [Trait("Category", "Service")]
        public async Task Verify_Artist_Add_NotNull_And_Equal_Object_Test()
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



    }
}
