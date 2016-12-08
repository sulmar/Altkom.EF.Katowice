namespace Altkom.RentBikes.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePeopleToPersons : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Persons");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Persons", newName: "People");
        }
    }
}
