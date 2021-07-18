using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace MusicStoreAdministrator.Tests.ServiceTests
{
    //fixture
    public class ObjectsFixture
    {
        //here we initialize all the things of create new objetcs like
        // public Calculator Calc => new Calculator();
    }

    public class SongServiceTests : IDisposable// : IClassFixture<ObjectsFixture>
    {
        //private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream _memoryStream;

        public SongServiceTests()
        {
            _memoryStream = new MemoryStream();
        }
        public void Dispose()
        {
            _memoryStream.Dispose();
        }


        [Fact] //implementamos fact para avisar que es un nuevo test
        [Trait("Category","Service")] //trait es para categorizar los tests
        public void CheckIfCreate()
        {
            //Arrange
            var songId = 1;
            var expected = "Song 1";
            var song = new Song()
            {
                Id = songId,
                Name
            };
        }

    }
}
