using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace camazon.Migrations
{
    /// <inheritdoc />
    public partial class AddMaker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Maker",
                table: "Product",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Maker",
                table: "Product");
        }
    }
}
