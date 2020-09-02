namespace NotePro.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigrate : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Note", "CategoryId", "dbo.Category");
            //DropIndex("dbo.Note", new[] { "CategoryId" });
            //AlterColumn("dbo.Note", "CategoryId", c => c.String(maxLength: 128));
            //CreateIndex("dbo.Note", "CategoryId");
            //AddForeignKey("dbo.Note", "CategoryId", "dbo.Category", "CategoryId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Note", "CategoryId", "dbo.Category");
            //DropIndex("dbo.Note", new[] { "CategoryId" });
            //AlterColumn("dbo.Note", "CategoryId", c => c.String(nullable: false, maxLength: 128));
            //CreateIndex("dbo.Note", "CategoryId");
            //AddForeignKey("dbo.Note", "CategoryId", "dbo.Category", "CategoryId", cascadeDelete: false);
        }
    }
}
