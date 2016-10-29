namespace MyPages.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipTypeTableNameChange1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "DuraionInMonths", c => c.Byte(nullable: false));
            DropColumn("dbo.MemberShipTypes", "Duraion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "Duraion", c => c.Byte(nullable: false));
            DropColumn("dbo.MemberShipTypes", "DuraionInMonths");
        }
    }
}
