using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MapIt.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "siteName",
                table: "Sites",
                newName: "SiteName");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Sites",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Sites",
                newName: "Latitude");

            migrationBuilder.AlterColumn<string>(
                name: "SiteName",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Sites",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Sites");

            migrationBuilder.RenameColumn(
                name: "SiteName",
                table: "Sites",
                newName: "siteName");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Sites",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Sites",
                newName: "latitude");

            migrationBuilder.AlterColumn<bool>(
                name: "siteName",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Area",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
