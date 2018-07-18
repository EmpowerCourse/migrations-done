using FluentMigrator;

namespace migrations_done
{
    [Migration(20180430121800)]
    public class AddActor : Migration
    {
        public override void Up()
        {
            Create.Table("actor")
                .WithColumn("actor_id").AsInt32().PrimaryKey().Identity()
                .WithColumn("first_name").AsAnsiString(45).NotNullable()
                .WithColumn("last_name").AsAnsiString(45).NotNullable()
                .WithColumn("last_update").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("actor");
        }
    }
}