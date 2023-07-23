namespace NewsPaper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tittle = c.String(),
                        date = c.DateTime(nullable: false),
                        name = c.String(),
                        cid = c.Int(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.cid, cascadeDelete: true)
                .Index(t => t.cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "cid", "dbo.Categories");
            DropIndex("dbo.News", new[] { "cid" });
            DropTable("dbo.News");
            DropTable("dbo.Categories");
        }
    }
}
