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
                    DepartamentalAffiliation = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    AdmArea = table.Column<string>(nullable: true),
                    Lighting = table.Column<string>(nullable: true),
                    Fencing = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOGobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 1L, "Западный административный округ", "Департамент культуры города Москвы", "да", "нет", "город Москва, Рублёвское шоссе, дом 26, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 339L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Большая Грузинская улица, дом 39" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 338L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Шелепихинская набережная, дом 22" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 337L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Стрельбищенский переулок, дом 8" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 336L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Трёхпрудный переулок, дом 11/13, строение 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 335L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Шелепихинская набережная, дом 14" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 334L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Зоологическая улица, дом 18" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 333L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Волков переулок, дом 7-9, строение 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 332L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "улица Земляной Вал, дом 25" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 331L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "улица Земляной Вал, дом 23, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 330L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "улица Антонова-Овсеенко, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 329L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Нижегородская улица, дом 1-7, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 328L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Верхняя Сыромятническая улица, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 327L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Гончарная улица, дом 38" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 326L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Порядковый переулок, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 325L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Верхняя Красносельская улица, дом 8, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 324L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "город Москва, 3-й Монетчиковский переулок, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 323L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Космодамианская набережная, дом 40-42, строение 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 322L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "Большая Переяславская улица, дом 6, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 321L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "2-й Крестовский переулок, дом 8" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 320L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "Калошин переулок, дом 6, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 319L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "Новинский бульвар, дом 18Б" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 318L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, Фрунзенская набережная, дом 16, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 317L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, улица Большая Якиманка, дом 35, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 316L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, улица Большая Полянка, дом 30" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 315L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, улица Большая Полянка, дом 28, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 314L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, улица Большая Полянка, дом 3/9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 313L, "Троицкий административный округ", "Префектура Троицкого и Новомосковского административных округов города Москвы", "да", "нет", "город Москва, поселение Роговское, посёлок Рогово, Юбилейная улица, дом 21" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 340L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "город Москва, Долгоруковская улица, дом 25" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 312L, "Троицкий административный округ", "Префектура Троицкого и Новомосковского административных округов города Москвы", "да", "нет", "город Москва, поселение Щаповское, посёлок Щапово, дом 19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 341L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, Крымский тупик, дом 6" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 343L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, улица Шаболовка, дом 27" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 370L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Фёдора Полетаева, дом 36" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 369L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Зеленодольская улица, дом 28, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 368L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Есенинский бульвар, дом 9, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 367L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Юных Ленинцев, дом 55" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 366L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Рождественская улица, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 365L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, Рождественская улица, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 364L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Ставропольский проезд, дом 17" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 363L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Верхние Поля, дом 5, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 362L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Совхозная улица, дом 41" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 361L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Цимлянская улица, дом 16" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 360L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Совхозная улица, дом 10, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 359L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Марьинский Парк, дом 45" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 358L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Краснодонская улица, дом 53" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 357L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Краснодарская улица, дом 56" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 356L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Головачёва, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 355L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Верхние Поля, дом 37А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 354L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Маршала Баграмяна, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 353L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Братиславская улица, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 352L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Новомарьинская улица, дом 30" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 351L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Братиславская улица, дом 27, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 350L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Новомарьинская улица, дом 30" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 349L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, 5-й квартал Капотня, дом 20" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 348L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "нет", "город Москва, Международная улица, дом 23" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 347L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, Тверская улица, дом 8, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 346L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, Мытная улица, дом 24" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 345L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, Ленинский проспект, дом 11, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 344L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, Ленинский проспект, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 342L, "Центральный административный округ", "Префектура Центрального административного округа города Москвы", "да", "да", "город Москва, Донская улица, дом 21, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 371L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, Привольная улица, дом 41" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 311L, "Новомосковский административный округ", "Префектура Троицкого и Новомосковского административных округов города Москвы", "да", "нет", "город Москва, поселение Рязановское, посёлок Знамя Октября, дом 29" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 309L, "Новомосковский административный округ", "Префектура Троицкого и Новомосковского административных округов города Москвы", "да", "нет", "город Москва, поселение \"Мосрентген\", посёлок Завода Мосрентген, дом 19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 277L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Чичерина, дом 12/2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 276L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Академика Королёва, дом 26" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 275L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Северный бульвар, дом 12Б" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 274L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Псковская улица, дом 2, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 273L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Абрамцевская улица, дом 30, строение 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 272L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "Анненская улица, дом 9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 271L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "Октябрьская улица, дом 105, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 270L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "4-й Стрелецкий проезд, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 269L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Образцова, дом 24" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 268L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "2-я улица Марьиной Рощи, дом 22" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 267L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "Изумрудная улица, дом 63/1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 266L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Милашенкова, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 265L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Докукина, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 264L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Бажова, дом 2, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 263L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Угличская улица, дом 18" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 262L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Римского-Корсакова, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 261L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "9-я Северная линия, дом 11, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 260L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Берингов проезд, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 259L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Костромская улица, дом 6, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 258L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Алтуфьевское шоссе, дом 77, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 257L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Бибиревская улица, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 256L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "город Москва, Ракетный бульвар, дом 17" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 255L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "Ботаническая улица, дом 33, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 254L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "проезд Дежнёва, дом 38А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 253L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "Полярная улица, дом 4, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 252L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "Бутырская улица, владение 86А, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 251L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Яблочкова, дом 49, строение 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 278L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Годовикова, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 310L, "Новомосковский административный округ", "Префектура Троицкого и Новомосковского административных округов города Москвы", "да", "да", "город Москва, поселение Рязановское, посёлок Фабрики имени 1 Мая, дом 53" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 279L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Цандера, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 281L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Юрловский проезд, владение 14, строение 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 308L, "Новомосковский административный округ", "Префектура Троицкого и Новомосковского административных округов города Москвы", "да", "нет", "город Москва, город Московский, 1-й микрорайон, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 307L, "Троицкий административный округ", "Префектура Троицкого и Новомосковского административных округов города Москвы", "да", "нет", "город Москва, поселение Кленовское, село Кленово, Октябрьская улица, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 306L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Дубравная улица, дом 48, корпус 1, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 305L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Карамышевская набережная, дом 44" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 304L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Генерала Глаголева, дом 30, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 303L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Маршала Тухачевского, дом 14, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 302L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, набережная Новикова-Прибоя, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 301L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Берзарина, дом 7, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 300L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Карамышевская набережная, дом 12, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 299L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Живописная улица, дом 54, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 298L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "да", "город Москва, Авиационная улица, дом 74, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 297L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "да", "город Москва, улица Маршала Бирюзова, дом 43" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 296L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "да", "город Москва, улица Свободы, дом 99, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 295L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Вишнёвая улица, дом 13" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 294L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Лодочная улица, дом 1, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 293L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Лодочная улица, дом 15, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 292L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Туристская улица, дом 2, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 291L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "да", "город Москва, улица Свободы, дом 50" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 290L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Василия Петушкова, дом 20, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 289L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Фабрициуса, дом 33, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 288L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "да", "город Москва, улица Мнёвники, дом 7, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 287L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "да", "город Москва, Юровская улица, дом 95, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 286L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Куркинское шоссе, дом 17" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 285L, "Северо-Западный административный округ", "Префектура Северо-Западного административного округа города Москвы", "да", "нет", "город Москва, Воротынская улица, дом 16" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 284L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Искры, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 283L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Милашенкова, дом 16, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 282L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "нет", "да", "город Москва, Верхоянская улица, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 280L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Плещеева, дом 26" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 372L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, Привольная улица, дом 70" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 373L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Привольная улица, дом 58" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 374L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, Новоостаповская улица, дом 4, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 464L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, проспект Андропова, дом 50, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 463L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, проспект Андропова, дом 30" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 462L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Загорьевский проезд, дом 9/12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 461L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Липецкая улица, дом 28" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 460L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Бирюлёвская улица, дом 37, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 459L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Лебедянская улица, дом 36, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 458L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Варшавское шоссе, дом 18, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 457L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, 4-й Верхний Михайловский проезд, дом 7, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 456L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Севастопольский проспект, дом 1, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 455L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Автозаводская улица, дом 9/1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 454L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Духовской переулок, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 453L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Павловская улица, дом 23" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 452L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, 2-й Павелецкий проезд, дом 4, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 451L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Крутицкая набережная, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 450L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Автозаводская улица, дом 1, строение 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 449L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Ключевая улица, дом 24, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 448L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Борисовские Пруды, дом 18, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 447L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Борисовские Пруды, дом 38" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 446L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Братеевская улица, дом 18, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 445L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, улица Борисовские Пруды, дом 6, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 444L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Востряковский проезд, дом 3, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 443L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Булатниковский проезд, дом 10, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 442L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Подольских Курсантов, дом 25А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 441L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Новоясеневский проспект, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 440L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Айвазовского, дом 5, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 439L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Новоясеневский проспект, дом 12, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 438L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Инессы Арманд, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 465L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Каширский проезд, дом 1/1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 437L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, проезд Одоевского, дом 3, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 466L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Академика Миллионщикова, дом 17" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 468L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Садовники, дом 9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 495L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Красного Маяка, дом 20, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 494L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Кировоградская улица, дом 32, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 493L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Варшавское шоссе, дом 144, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 492L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Варшавское шоссе, дом 114, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 491L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Сумская улица, дом 6, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 490L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Кавказский бульвар, дом 50" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 489L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Промышленная улица, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 488L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Каспийская улица, дом 18, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 487L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Каспийская улица, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 486L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Пролетарский проспект, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 485L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Кантемировская улица, дом 4, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 484L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Пролетарский проспект, дом 17, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 483L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Ореховый проезд, дом 19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 482L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Воронежская улица, дом 8, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 481L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Гурьевский проезд, дом 9, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 480L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Тамбовская улица, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 479L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Шипиловский проезд, дом 59, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 478L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Ясеневая улица, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 477L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Маршала Захарова, дом 16, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 476L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Борисовский проезд, дом 5, строение 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 475L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Генерала Белова, дом 21, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 474L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Шипиловский проезд, дом 49/1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 473L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Ялтинская улица, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 472L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Варшавское шоссе, дом 50" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 471L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Нагатинская набережная, дом 70" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 470L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Нагатинская набережная, дом 40А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 469L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Затонная улица, дом 22" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 467L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, Каширское шоссе, дом 5, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 436L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Вильнюсская улица, дом 7, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 435L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Старокачаловская улица, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 434L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Феодосийская улица, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 401L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, 2-я Мелитопольская улица, дом 21, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 400L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Академика Семёнова, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 399L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Адмирала Лазарева, дом 16" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 398L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Изюмская улица, дом 45, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 397L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Нахимовский проспект, дом 54/26" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 396L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, улица Ивана Бабушкина, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 395L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Профсоюзная улица, дом 20/9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 394L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Большая Черёмушкинская улица, дом 30, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 393L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Шверника, дом 13, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 392L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Профсоюзная улица, дом 17, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 391L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, Сторожевая улица, дом 24Б" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 390L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Шкулёва, владение 2Б, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 389L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Волжский бульвар, дом 3, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 388L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, квартал Грайвороново 90а, корпус 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 387L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Паперника, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 386L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, 1-й Казанский просек, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 385L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, улица Васильцовский Стан, дом 10, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 384L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Фёдора Полетаева, дом 20, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 383L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, 1-я Новокузьминская улица, дом 20, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 382L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Батюнинская улица, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 381L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Гурьянова, дом 41" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 380L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Гурьянова, дом 75" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 379L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, Шоссейная улица, дом 58, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 378L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, улица Симоновский Вал, дом 7А, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 377L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Гурьянова, дом 2, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 376L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "да", "город Москва, 2-й Южнопортовый проезд, дом 13" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 375L, "Юго-Восточный административный округ", "Префектура Юго-Восточного административного округа города Москвы", "да", "нет", "город Москва, 7-я Кожуховская улица, дом 10, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 402L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Брусилова, дом 27, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 403L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Плавский проезд, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 404L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Скобелевская улица, владение 46" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 405L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Севастопольский проспект, дом 28, корпус 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 433L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Керченская улица, дом 28" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 432L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Севастопольский проспект, дом 44, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 431L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Новочерёмушкинская улица, дом 57" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 430L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Новочерёмушкинская улица, дом 50" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 429L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, улица Каховка, дом 11, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 428L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Балаклавский проспект, владение 30А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 427L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Болотниковская улица, владение 36, корпус 1, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 426L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Херсонская улица, дом 12, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 425L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Островитянова, дом 9, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 424L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Новаторов, дом 36, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 423L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Обручева, дом 28, корпус 6" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 422L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Нагорный бульвар, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 421L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Нагорная улица, дом 29, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 250L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "город Москва, улица Пришвина, владение 6А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 420L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Нагорная улица, дом 24, корпус 10" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 418L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Ломоносовский проспект, дом 3, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 417L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, улица Косыгина, дом 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 416L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Ломоносовский проспект, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 415L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, улица Академика Арцимовича, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 414L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Профсоюзная улица, дом 101, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 413L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, улица Академика Волгина, дом 31, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 412L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Профсоюзная улица, дом 116, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 411L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Островитянова, дом 36" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 410L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Ломоносовский проспект, дом 14" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 409L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Кравченко, дом 8" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 408L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, проспект Вернадского, дом 11/19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 407L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, улица Вавилова, дом 91, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 406L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "нет", "город Москва, Нахимовский проспект, владение 10, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 419L, "Юго-Западный административный округ", "Префектура Юго-Западного административного округа города Москвы", "да", "да", "город Москва, Ленинский проспект, дом 60/2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 496L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "да", "город Москва, Чертановская улица, дом 48, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 249L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "проезд Нансена, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 247L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Седова, дом 6, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 90L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Лукинская улица, дом 18, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 89L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Лукинская улица, дом 18" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 88L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Лукинская улица, дом 10" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 87L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Боровское шоссе, дом 35" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 86L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Изваринская улица, дом 7, строение 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 85L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Насосная улица, дом 1А, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 84L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Маршала Тимошенко, дом 29" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 83L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Коцюбинского, дом 10" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 82L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Поклонная улица, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 81L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Наташи Ковшовой, дом 29" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 80L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, проспект Вернадского, дом 42, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 79L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Ленинский проспект, дом 108, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 78L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, посёлок Рублёво, Советская улица, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 77L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Ельнинская улица, дом 20, корпус 1, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 76L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Ивана Франко, дом 8, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 75L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Коцюбинского, дом 8, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 74L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Сталеваров, дом 14, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 73L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Реутовская улица, дом 16" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 72L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Косинская улица, дом 14, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 71L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Косинская улица, дом 24, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 70L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Красноярская улица, дом 5/36" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 69L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Камчатская улица, дом 6, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 68L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Амурская улица, дом 54" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 67L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Амурская улица, дом 40" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 66L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Алтайская улица, дом 19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 65L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Красный Казанец, дом 1, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 64L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Старый Гай, дом 2, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 91L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Крылатская улица, дом 25" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 63L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Кетчерская улица, дом 2, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 92L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Осенняя улица, дом 27" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 94L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Дорогобужская улица, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 121L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, улица Щорса, дом 4, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 120L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Авиаторов, дом 28" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 119L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Производственная улица, дом 1, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 118L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Платовская улица, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 117L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Кастанаевская улица, дом 50" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 116L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Бережковская набережная, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 115L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица 1812 Года, дом 10, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 114L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица 1812 Года, дом 4/45, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 113L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Брянская улица, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 112L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Резервный проезд, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 111L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Очаковское шоссе, дом 6, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 110L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, улица Марии Поливановой, дом 2/19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 109L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Озёрная улица, дом 31, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 108L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Большая Очаковская улица, дом 42, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 107L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Большая Очаковская улица, дом 21" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 106L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Никулинская улица, дом 12, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 105L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Бережковская набережная, дом 8" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 104L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Можайское шоссе, дом 38, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 103L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Красных Зорь, дом 59" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 102L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Барвихинская улица, дом 10" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 101L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, Беловежская улица, дом 57" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 100L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Толбухина, дом 2, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 99L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Олеко Дундича, дом 13, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 98L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Горбунова, дом 9, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 97L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Гжатская улица, дом 8" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 96L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Беловежская улица, дом 81" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 95L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Беловежская улица, дом 73" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 93L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, улица Ращупкина, дом 14, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 122L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, улица Богданова, дом 24" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 62L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Большой Матросский переулок, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 60L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Сиреневый бульвар, дом 3, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 28L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Сталеваров, дом 4, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 27L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Молостовых, дом 15, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 26L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Напольный проезд, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 25L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, шоссе Энтузиастов, дом 94, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 24L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Зелёный проспект, дом 26" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 23L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "да", "город Москва, Перовская улица, дом 70" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 22L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "да", "город Москва, Перовская улица, дом 70" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 21L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "да", "город Москва, Зелёный проспект, дом 74" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 20L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Погонный проезд, дом 11" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 19L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "да", "город Москва, бульвар Маршала Рокоссовского, дом 6, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 18L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Кузнецовская улица, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 17L, "Юго-Восточный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, Краснодонская улица, дом 1, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 16L, "Западный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, улица Удальцова, дом 22" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 15L, "Центральный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, Красногвардейский бульвар, дом 11/1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 14L, "Северо-Восточный административный округ", "Департамент культуры города Москвы", "да", "нет", "город Москва, Енисейская улица, дом 39, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 13L, "Северо-Восточный административный округ", "Департамент культуры города Москвы", "да", "нет", "город Москва, Олонецкий проезд, дом 4, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 12L, "Северо-Восточный административный округ", "Департамент культуры города Москвы", "да", "нет", "город Москва, Олонецкий проезд, дом 8" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 11L, "Южный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, улица Борисовские Пруды, дом 2А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 10L, "Южный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, Коломенский проезд, дом 14, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 9L, "Северо-Западный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, улица Свободы, дом 91, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 8L, "Восточный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, 3-й Лучевой просек, дом 12, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 7L, "Восточный административный округ", "Департамент культуры города Москвы", "да", "нет", "город Москва, аллея Жемчуговой, владение 2, строение 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 6L, "Северо-Восточный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, улица Корнейчука, дом 36А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 5L, "Северный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, улица Софьи Ковалевской, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 4L, "Южный административный округ", "Департамент культуры города Москвы", "да", "нет", "город Москва, Борисовский проезд, дом 5, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 3L, "Западный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, улица Мичуринский Проспект, Олимпийская Деревня, дом 1, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 2L, "Западный административный округ", "Департамент культуры города Москвы", "да", "да", "город Москва, улица Удальцова, дом 40" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 29L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Сталеваров, дом 12, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 61L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Олений Вал, дом 24, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 30L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Свободный проспект, дом 11, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 32L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Измайловский проезд, дом 5, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 59L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 3-я Парковая улица, дом 48, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 58L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 15-я Парковая улица, дом 46, корпус 6" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 57L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 11-я Парковая улица, дом 52" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 56L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 11-я Парковая улица, дом 42, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 55L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Никитинская улица, дом 16, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 54L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Константина Федина, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 53L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Суздальская улица, дом 9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 52L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Салтыковская улица, дом 11Б" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 51L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Суздальская улица, дом 8, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 50L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Руднёвка, дом 43А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 49L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Лухмановская улица, дом 34" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 48L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Лухмановская улица, дом 18" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 47L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Святоозерская улица, дом 24" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 46L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Святоозерская улица, дом 8" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 45L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Святоозерская улица, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 44L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Знаменская улица, дом 38, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 43L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Алымова улица, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 42L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Преображенский Вал, дом 24, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 41L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Большая Черкизовская улица, дом 22, корпус 1, строение 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 40L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Халтуринская улица, дом 4, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 39L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 3-я Владимирская улица, дом 25, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 38L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 1-я Владимирская улица, дом 20" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 37L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Новогиреевская улица, дом 24А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 36L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, улица Аносова, дом 9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 35L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 5-я улица Соколиной Горы, дом 25, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 34L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, 8-я улица Соколиной Горы, дом 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 33L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Измайловское шоссе, дом 57" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 31L, "Восточный административный округ", "Префектура Восточного административного округа города Москвы", "да", "нет", "город Москва, Свободный проспект, дом 19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 123L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица 26-ти Бакинских Комиссаров, дом 10, корпус 6" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 124L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, набережная Тараса Шевченко, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 125L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, улица Раевского, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 215L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Бутырская улица, дом 15" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 214L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Башиловская улица, дом 19" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 213L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Бутырская улица, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 212L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Вятская улица, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 211L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Прибрежный проезд, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 210L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Фестивальная улица, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 209L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "бульвар Матроса Железняка, дом 9А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 208L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Новая Ипатовка, владение 3Г, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 207L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Нарвская улица, дом 2А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 206L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "3-й Новомихалковский проезд, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 205L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Весенняя улица, дом 3, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 204L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Маршала Федоренко, дом 16/2, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 203L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Новая улица, дом 22" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 202L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Базовская улица, дом 22А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 201L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дегунинская улица, дом 2, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 200L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Ивана Сусанина, дом 4, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 199L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Коровинское шоссе, дом 34" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 198L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дмитровское шоссе, дом 107, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 197L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Карельский бульвар, дом 2, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 196L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Клязьминская улица, дом 7, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 195L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Ангарская улица, дом 45, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 194L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Софьи Ковалевской, дом 4А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 193L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Клязьминская улица, дом 29, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 192L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Лавочкина, дом 28/42" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 191L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Онежская улица, дом 34, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 190L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Онежская улица, дом 14, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 189L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Фестивальная улица, дом 46, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 216L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Полтавская улица, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 188L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Смольная улица, дом 9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 217L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Петровско-Разумовский проезд, дом 16" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 219L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Фестивальная улица, дом 22, корпус 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 246L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Яблочкова, дом 31, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 245L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Ротерта, дом 10, корпус 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 244L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "город Москва, улица Тихомирова, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 243L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Палехская улица, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 242L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Корнейчука, дом 47" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 241L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "город Москва, Холмогорская улица, дом 6, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 240L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Лескова, дом 11А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 239L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "город Москва, проезд Шокальского, дом 37, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 238L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "Палехская улица, дом 21" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 237L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "Большая Марфинская улица, дом 4, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 236L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Палехская улица, дом 147, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 235L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "улица Бориса Галушкина, дом 25" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 234L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "улица Космонавтов, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 233L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "улица Космонавтов, дом 6" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 232L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "проспект Мира, дом 184, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 231L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "проспект Мира, дом 182, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 230L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "Рижский проезд, дом 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 229L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "да", "Новоалексеевская улица, дом 5А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 228L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "город Москва, улица Дыбенко, дом 12" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 227L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "город Москва, улица Дыбенко, дом 38, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 226L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "город Москва, улица Новая Башиловка, дом 6" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 225L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Бескудниковский бульвар, дом 19, корпус 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 224L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Сальвадора Альенде, дом 4, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 223L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Малый Песчаный переулок, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 222L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Хорошёвское шоссе, дом 50, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 221L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Хорошёвское шоссе, дом 5, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 220L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Куусинена, дом 9, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 218L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Вятская улица, дом 41" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 187L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Онежская улица, дом 37" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 186L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Керамический проезд, дом 75, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 185L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дубнинская улица, дом 75, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 152L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1801Б" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 151L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "да", "город Москва, город Зеленоград, корпус 814" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 150L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, Малинская улица, дом 109" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 149L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1620" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 148L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 2018" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 147L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 2010" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 146L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1603" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 145L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 2010" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 144L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "да", "город Москва, город Зеленоград, корпус 450" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 143L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "да", "город Москва, город Зеленоград, корпус 2301" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 142L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1524" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 141L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 842" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 140L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 534" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 139L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 917" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 138L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 815" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 137L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1211" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 136L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1201" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 135L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1113" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 134L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1007" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 133L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1001" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 132L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 442А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 131L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 249" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 130L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, Панфиловский проспект, дом 3, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 129L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Никулинская улица, дом 23, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 128L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "да", "город Москва, набережная Тараса Шевченко, дом 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 127L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, улица Столетова, дом 7, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 126L, "Западный административный округ", "Префектура Западного административного округа города Москвы", "да", "нет", "город Москва, Кутузовский проспект, дом 26, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 153L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "да", "город Москва, город Зеленоград, корпус 702" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 154L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 521" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 155L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 342, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 156L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 345" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 184L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дубнинская улица, дом 18, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 183L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дубнинская улица, дом 12, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 182L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дубнинская улица, дом 8, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 181L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дубнинская улица, дом 2, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 180L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Ленинградское шоссе, дом 34, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 179L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Клары Цеткин, дом 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 178L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Космонавта Волкова, дом 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 177L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "5-й Войковский проезд, дом 16" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 176L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Коровинское шоссе, дом 4, корпус 3" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 175L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Бескудниковский бульвар, дом 59А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 174L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Дубнинская улица, дом 27, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 173L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Дубнинская улица, дом 45, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 172L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Бескудниковский проезд, дом 2, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 248L, "Северо-Восточный административный округ", "Префектура Северо-Восточного административного округа города Москвы", "да", "нет", "город Москва, Тенистый проезд, дом 12А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 171L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Бескудниковский бульвар, дом 55, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 169L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Беговая улица, дом 2" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 168L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Беговой проезд, дом 7" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 167L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Скаковая улица, дом 17, строение 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 166L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "улица Академика Ильюшина, дом 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 165L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "1-я Аэропортовская улица, дом 6" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 164L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Ленинградский проспект, дом 62" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 163L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "да", "Ленинградский проспект, дом 60А" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 162L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Верхняя Масловка, дом 9" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 161L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица 8 Марта, дом 13" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 160L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Красноармейская улица, дом 5" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 159L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Ленинградский проспект, дом 50" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 158L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "улица Черняховского, дом 9, корпус 4" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 157L, "Зеленоградский административный округ", "Префектура Зеленоградского административного округа города Москвы", "да", "нет", "город Москва, город Зеленоград, корпус 1432" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 170L, "Северный административный округ", "Префектура Северного административного округа города Москвы", "да", "нет", "Бескудниковский бульвар, дом 28, корпус 1" });

            migrationBuilder.InsertData(
                table: "DOGobjs",
                columns: new[] { "Id", "AdmArea", "DepartamentalAffiliation", "Fencing", "Lighting", "Location" },
                values: new object[] { 497L, "Южный административный округ", "Префектура Южного административного округа города Москвы", "да", "нет", "город Москва, улица Лобанова, дом 9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOGobjs");
        }
    }
}
