namespace NotePro.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinishedCategoryControllerandViews : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Category",
            //    c => new
            //        {
            //            CategoryId = c.String(nullable: false, maxLength: 128),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.CategoryId);
            
            //AddColumn("dbo.Note", "CategoryId", c => c.String(nullable: false, maxLength: 128));
            //CreateIndex("dbo.Note", "CategoryId");
            //AddForeignKey("dbo.Note", "CategoryId", "dbo.Category", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note", "CategoryId", "dbo.Category");
            DropIndex("dbo.Note", new[] { "CategoryId" });
            DropColumn("dbo.Note", "CategoryId");
            DropTable("dbo.Category");
        }
    }
}
