using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementOrganizations.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOGobjs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartmentalAffiliation = table.Column<string>(nullable: true),
                    SiteElements = table.Column<string>(nullable: true),
                    PlatformLighting = table.Column<string>(nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    FencingSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOGobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "DepartmentalAffiliation", "FencingSite", "Landmark", "PlatformLighting", "SiteElements" },
                values: new object[] { 1L, "Департамент культуры города Москвы", "да", "город Москва, Рублёвское шоссе, дом 26, корпус 4", "нет", "балансир для собак,барьер одинарный,бум для собак,вышка-лестница (с перилами),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOGobjs");
        }
    }
}
