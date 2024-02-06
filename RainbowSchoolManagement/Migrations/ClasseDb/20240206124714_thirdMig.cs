using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RainbowSchoolManagement.Migrations.ClasseDb
{
    public partial class thirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassStrength = table.Column<int>(type: "int", nullable: false),
                    ClassLeader = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.class_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classe");
        }
    }
}
