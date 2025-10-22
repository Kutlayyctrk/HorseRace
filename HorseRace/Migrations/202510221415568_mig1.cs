namespace HorseRace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Atlar", "JokeyId");
            RenameColumn(table: "dbo.Atlar", name: "Jockey_Id", newName: "JokeyId");
            RenameIndex(table: "dbo.Atlar", name: "IX_Jockey_Id", newName: "IX_JokeyId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Atlar", name: "IX_JokeyId", newName: "IX_Jockey_Id");
            RenameColumn(table: "dbo.Atlar", name: "JokeyId", newName: "Jockey_Id");
            AddColumn("dbo.Atlar", "JokeyId", c => c.Int());
        }
    }
}
