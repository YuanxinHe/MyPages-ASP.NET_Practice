namespace MyPages.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipTypeTableNameChange2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            DropColumn("dbo.MemberShipTypes", "DuraionInMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "DuraionInMonths", c => c.Byte(nullable: false));
            DropColumn("dbo.MemberShipTypes", "DurationInMonths");
        }
    }
}
