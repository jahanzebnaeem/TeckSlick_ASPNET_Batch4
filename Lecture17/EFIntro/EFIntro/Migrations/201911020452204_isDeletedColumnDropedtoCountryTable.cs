namespace EFIntro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isDeletedColumnDropedtoCountryTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Country", "isDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Country", "isDeleted", c => c.Int(nullable: false));
        }
    }
}
