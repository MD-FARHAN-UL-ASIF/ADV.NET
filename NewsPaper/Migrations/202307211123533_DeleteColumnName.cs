namespace NewsPaper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.News", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.News", "name", c => c.String());
        }
    }
}
