using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstSqlServer.Migrations
{
    public partial class AddDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Members");
        }
    }
}
