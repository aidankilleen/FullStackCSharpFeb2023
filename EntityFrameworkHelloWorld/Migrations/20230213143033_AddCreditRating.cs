using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkHelloWorld.Migrations
{
    public partial class AddCreditRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CreditRating",
                table: "Members",
                type: "REAL",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditRating",
                table: "Members");
        }
    }
}
