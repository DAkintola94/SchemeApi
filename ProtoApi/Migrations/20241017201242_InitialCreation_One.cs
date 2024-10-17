using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProtoApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation_One : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Information_data");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Information_data",
                type: "longblob",
                nullable: true);
        }
    }
}
