using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginPortal.Data.Migrations
{
    public partial class CustomUserProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomValue",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomValue",
                table: "AspNetUsers");
        }
    }
}
