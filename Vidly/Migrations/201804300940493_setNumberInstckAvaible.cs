namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setNumberInstckAvaible : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailble = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
