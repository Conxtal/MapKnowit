using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MapIt.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DivisionId",
                table: "Companies",
                newName: "DivisionID");

            migrationBuilder.AlterColumn<bool>(
                name: "DivisionName",
                table: "Divisions",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Name",
                table: "Companies",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyActivities",
                columns: table => new
                {
                    CompanySiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyActivities", x => x.CompanySiteID);
                });

            migrationBuilder.CreateTable(
                name: "CompanySiteOwnerRelations",
                columns: table => new
                {
                    CompanySiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnershipTupeID = table.Column<int>(type: "int", nullable: false),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySiteOwnerRelations", x => x.CompanySiteID);
                });

            migrationBuilder.CreateTable(
                name: "CompanySites",
                columns: table => new
                {
                    CompanySiteRelationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySites", x => x.CompanySiteRelationID);
                });

            migrationBuilder.CreateTable(
                name: "OwnershipTypes",
                columns: table => new
                {
                    OwnershipTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ownership = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnershipTypes", x => x.OwnershipTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    siteName = table.Column<bool>(type: "bit", nullable: false),
                    latitude = table.Column<float>(type: "real", nullable: false),
                    longitude = table.Column<float>(type: "real", nullable: false),
                    Area = table.Column<bool>(type: "bit", nullable: false),
                    Rent = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.SiteID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "CompanyActivities");

            migrationBuilder.DropTable(
                name: "CompanySiteOwnerRelations");

            migrationBuilder.DropTable(
                name: "CompanySites");

            migrationBuilder.DropTable(
                name: "OwnershipTypes");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.RenameColumn(
                name: "DivisionID",
                table: "Companies",
                newName: "DivisionId");

            migrationBuilder.AlterColumn<string>(
                name: "DivisionName",
                table: "Divisions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
