namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypeAgain : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (2, 'Horror')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO GenreTypes (Id, Name) VALUES (5, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
