using Microsoft.EntityFrameworkCore.Migrations;

namespace cqrsmediatr.persistence.Migrations
{
    public partial class ChangeTitleAndDescriptionToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "Todo",
                table: "TodoItem",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Todo",
                table: "TodoItem",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Title",
                schema: "Todo",
                table: "TodoItem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Description",
                schema: "Todo",
                table: "TodoItem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
