#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Fittness.Migrations
{
    /// <inheritdoc />
    public partial class setPalateImgTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Palates1");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Palates1",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Palates1");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Palates1",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
