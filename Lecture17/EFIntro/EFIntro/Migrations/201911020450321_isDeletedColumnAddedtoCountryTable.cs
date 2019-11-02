namespace EFIntro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isDeletedColumnAddedtoCountryTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Country", "isDeleted", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Country", "isDeleted");
        }
    }
}
