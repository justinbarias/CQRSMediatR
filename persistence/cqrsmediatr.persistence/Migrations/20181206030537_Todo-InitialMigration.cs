using Microsoft.EntityFrameworkCore.Migrations;

namespace cqrsmediatr.persistence.Migrations
{
    public partial class TodoInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Todo");

            migrationBuilder.CreateTable(
                name: "TodoItem",
                schema: "Todo",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false),
                    Title = table.Column<bool>(nullable: false),
                    Description = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItem",
                schema: "Todo");
        }
    }
}
