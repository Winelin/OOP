using Microsoft.EntityFrameworkCore.Migrations;

namespace DOGobj.WebService.Migrations
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
                    Name = table.Column<string>(nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    SiteElements = table.Column<string>(nullable: true),
                    PlatformLighting = table.Column<string>(nullable: true),
                    FencingSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOGobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "FencingSite", "Landmark", "Name", "PlatformLighting", "SiteElements" },
                values: new object[] { 1L, "да", "город Москва, Рублёвское шоссе, дом 26, корпус 4", "Департамент культуры города Москвы", "нет", "балансир для собак,барьер одинарный,бум для собак,вышка-лестница (с перилами),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "FencingSite", "Landmark", "Name", "PlatformLighting", "SiteElements" },
                values: new object[] { 2L, "да", "город Москва, улица Удальцова, дом 40", "Департамент культуры города Москвы", "да", "барьер одинарный,бум для собак,вышка-лестница (с перилами),горка-лестница (без перил),туннель (нора),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "FencingSite", "Landmark", "Name", "PlatformLighting", "SiteElements" },
                values: new object[] { 3L, "да", "город Москва, улица Мичуринский Проспект, Олимпийская Деревня, дом 1, корпус 2", "Департамент культуры города Москвы", "да", "барьер двойной,барьер кольца,входной элемент,горка-лестница (без перил),горка-мостик А-форма,информационный стенд,туннель (нора),скамья для собаководов,трап,урна" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "FencingSite", "Landmark", "Name", "PlatformLighting", "SiteElements" },
                values: new object[] { 4L, "да", "город Москва, Борисовский проезд, дом 5, корпус 1", "Департамент культуры города Москвы", "нет", "барьер кольца, бум для собак, туннель (нора)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOGobjs");
        }
    }
}
