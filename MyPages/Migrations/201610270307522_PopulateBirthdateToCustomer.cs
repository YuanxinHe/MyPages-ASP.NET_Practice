namespace MyPages.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE CUSTOMERS SET BIRTHDATE=1/1/1980 WHERE NAME='John Smith'");
        }
        
        public override void Down()
        {
        }
    }
}
