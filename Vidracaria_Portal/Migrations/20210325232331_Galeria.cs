using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Galeria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PENDENTES");

            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dccb7ddf-34e0-45f1-8021-d146e39c7fd3", "0933b908-3288-4521-beaa-8b41ca0c1365" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef9cd124-c705-4d35-b0b7-ef0639c20bd6", "93214493-ff11-4444-8fea-feca64bb0707" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dccb7ddf-34e0-45f1-8021-d146e39c7fd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef9cd124-c705-4d35-b0b7-ef0639c20bd6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0933b908-3288-4521-beaa-8b41ca0c1365");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93214493-ff11-4444-8fea-feca64bb0707");

            migrationBuilder.CreateTable(
                name: "GALERIA",
                columns: table => new
                {
                    CodigoGaleria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Imagem = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GALERIA", x => x.CodigoGaleria);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "826dc7b9-ae96-41c1-b1e0-654a4c43a703", "5eff258d-fd6a-4f71-96fd-48d47c8a71eb", "Administrador", "ADMINISTRADOR" },
                    { "253af883-0f0b-4987-9c6d-ab8d214688f9", "b35254af-8a1c-42b3-85ae-03b3764eeb91", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f3acf2c8-ec32-4006-8705-b7156dafd6ce", 0, "804beb90-519a-4726-b9a0-5de3deb9955b", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAELOEfjXLjWG8z9m0cfbiAS0QdvhQEhxsrwoNz9Dt4s5Sbvml9ESWw21+O+Fge6Bdag==", null, false, "25717600", false, "admin@vidracariaportal.com.br" },
                    { "03b7f777-4f52-490e-91f9-38fa087d30c1", 0, "695a9adb-17a1-407d-ab31-2a39e52817ce", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEHLMJGdMW80Z0noC7ecNddpbBBxFNCxUG5XCHNkpvEGgYnJHxyWqHd2W9xU333Gdsw==", null, false, "30131813", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "826dc7b9-ae96-41c1-b1e0-654a4c43a703", "f3acf2c8-ec32-4006-8705-b7156dafd6ce" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "253af883-0f0b-4987-9c6d-ab8d214688f9", "03b7f777-4f52-490e-91f9-38fa087d30c1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GALERIA");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "253af883-0f0b-4987-9c6d-ab8d214688f9", "03b7f777-4f52-490e-91f9-38fa087d30c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "826dc7b9-ae96-41c1-b1e0-654a4c43a703", "f3acf2c8-ec32-4006-8705-b7156dafd6ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "253af883-0f0b-4987-9c6d-ab8d214688f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "826dc7b9-ae96-41c1-b1e0-654a4c43a703");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03b7f777-4f52-490e-91f9-38fa087d30c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3acf2c8-ec32-4006-8705-b7156dafd6ce");

            migrationBuilder.CreateTable(
                name: "PENDENTES",
                columns: table => new
                {
                    CodigoPendentes = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PENDENTES", x => x.CodigoPendentes);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    Codigo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    EstoqueMaximo = table.Column<int>(type: "int", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PrecoFabrica = table.Column<string>(type: "text", nullable: false),
                    PrecoVenda = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_PRODUTOS_CORES_CorId",
                        column: x => x.CorId,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ef9cd124-c705-4d35-b0b7-ef0639c20bd6", "18749c4d-555b-4f48-bbe5-8e6e006563db", "Administrador", "ADMINISTRADOR" },
                    { "dccb7ddf-34e0-45f1-8021-d146e39c7fd3", "918e1623-6822-4473-8d8f-e09fe613c1bc", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "93214493-ff11-4444-8fea-feca64bb0707", 0, "5368057e-2995-4a4b-bfb1-c0d884d448ed", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEORbwODZchP5t/EbyW6l5ZdvapCgcGTtNzPTL9G61meITQuKVtpRs2qagHqLQxX1nw==", null, false, "32481801", false, "admin@vidracariaportal.com.br" },
                    { "0933b908-3288-4521-beaa-8b41ca0c1365", 0, "360a9cbc-b415-41fc-89c7-cad38f6d287b", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEL1KY+5+kwrHmy8B5QL6dGhERd+qnHDXdufGIfpooZeUuT6XgxnWGW61stTmg7PfeQ==", null, false, "23900756", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ef9cd124-c705-4d35-b0b7-ef0639c20bd6", "93214493-ff11-4444-8fea-feca64bb0707" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dccb7ddf-34e0-45f1-8021-d146e39c7fd3", "0933b908-3288-4521-beaa-8b41ca0c1365" });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CorId",
                table: "PRODUTOS",
                column: "CorId");
        }
    }
}
