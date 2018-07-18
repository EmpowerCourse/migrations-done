using FluentMigrator;

namespace migrations_done
{
    [Migration(20180717162900)]
    public class AddFile : Migration
    {
        public override void Up()
        {
            Create.Table("film")
                .WithColumn("film_id").AsInt32().PrimaryKey().Identity()
                .WithColumn("title").AsAnsiString(255).NotNullable()
                .WithColumn("description").AsString()
                .WithColumn("release_year").AsAnsiString(4)
                .WithColumn("language_id").AsInt32()
                .WithColumn("original_language_id").AsInt32()
                .WithColumn("rental_duration").AsByte()
                .WithColumn("rental_rate").AsDecimal(4,2).NotNullable()
                .WithColumn("length").AsInt16()
                .WithColumn("replacement_cost").AsDecimal(5,2).NotNullable()
                .WithColumn("rating").AsAnsiString(10)
                .WithColumn("special_features").AsAnsiString(255)
                .WithColumn("last_update").AsDateTime().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("film");
        }
    }
}