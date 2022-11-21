using Microsoft.EntityFrameworkCore.Migrations;

namespace SCP_Foundation.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SCPs",
                columns: table => new
                {
                    SCPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNumber = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: true),
                    ObjectClass = table.Column<string>(maxLength: 60, nullable: true),
                    ThreatLevel = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCPs", x => x.SCPID);
                });

            migrationBuilder.InsertData(
                table: "SCPs",
                columns: new[] { "SCPID", "IdNumber", "Name", "ObjectClass", "ThreatLevel" },
                values: new object[] { 1, "SCP-0003", "Biological Motherboard", "Euclid", "Dark" });

            migrationBuilder.InsertData(
                table: "SCPs",
                columns: new[] { "SCPID", "IdNumber", "Name", "ObjectClass", "ThreatLevel" },
                values: new object[] { 2, "SCP-0013", "Wooden Statue", "Keter", "Amida" });

            migrationBuilder.InsertData(
                table: "SCPs",
                columns: new[] { "SCPID", "IdNumber", "Name", "ObjectClass", "ThreatLevel" },
                values: new object[] { 3, "SCP-0023", "Oak Tree", "Archon", "Vlam" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCPs");
        }
    }
}
