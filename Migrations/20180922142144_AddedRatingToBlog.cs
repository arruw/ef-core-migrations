using Microsoft.EntityFrameworkCore.Migrations;

namespace ef_core_migrations.Migrations
{
    public partial class AddedRatingToBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Blogs");
        }
    }
}
