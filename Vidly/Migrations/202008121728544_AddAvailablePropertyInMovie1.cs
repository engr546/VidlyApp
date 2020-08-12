namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailablePropertyInMovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Available = Stocks");
        }
        
        public override void Down()
        {
        }
    }
}
