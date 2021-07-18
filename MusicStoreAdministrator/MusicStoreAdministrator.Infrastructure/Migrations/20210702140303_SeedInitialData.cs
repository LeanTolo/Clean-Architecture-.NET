using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStoreAdministrator.Infrastructure.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("INSERT INTO Artists(Name, SurName) VALUES('Artist 1', 'Surname 1');");
            migrationBuilder
               .Sql("INSERT INTO Artists(Name, SurName) VALUES('Artist 2', 'Surname 1');");
            migrationBuilder
               .Sql("INSERT INTO Artists(Name, SurName) VALUES('Artist 3', 'Surname 1');");
            migrationBuilder
               .Sql("INSERT INTO Artists(Name, SurName) VALUES('Artist 4', 'Surname 1');");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 1', 200, (SELECT Id FROM Artists WHERE Name = 'Artist 1'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 2', 210, (SELECT Id FROM Artists WHERE Name = 'Artist 1'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 3', 220, (SELECT Id FROM Artists WHERE Name = 'Artist 1'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 4', 210, (SELECT Id FROM Artists WHERE Name = 'Artist 2'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 5', 230, (SELECT Id FROM Artists WHERE Name = 'Artist 2'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 6', 240, (SELECT Id FROM Artists WHERE Name = 'Artist 3'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 7', 250, (SELECT Id FROM Artists WHERE Name = 'Artist 3'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 8', 210, (SELECT Id FROM Artists WHERE Name = 'Artist 3'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 9', 270, (SELECT Id FROM Artists WHERE Name = 'Artist 3'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 10', 280, (SELECT Id FROM Artists WHERE Name = 'Artist 4'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 11', 210, (SELECT Id FROM Artists WHERE Name = 'Artist 4'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 12', 300, (SELECT Id FROM Artists WHERE Name = 'Artist 4'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 13', 340, (SELECT Id FROM Artists WHERE Name = 'Artist 4'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 14', 320, (SELECT Id FROM Artists WHERE Name = 'Artist 4'));");
            migrationBuilder
             .Sql("INSERT INTO Songs(Name, Duration, ArtistId) VALUES('Song 15', 260, (SELECT Id FROM Artists WHERE Name = 'Artist 4'));");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
