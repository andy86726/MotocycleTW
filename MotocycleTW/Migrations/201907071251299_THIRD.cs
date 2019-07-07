namespace MotocycleTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class THIRD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Battery_store",
                c => new
                    {
                        s_id = c.Int(nullable: false, identity: true),
                        s_name = c.String(),
                        s_block = c.String(),
                        s_address = c.String(),
                    })
                .PrimaryKey(t => t.s_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Battery_store");
        }
    }
}
