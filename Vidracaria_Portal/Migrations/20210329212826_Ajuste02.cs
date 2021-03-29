using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Ajuste02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NOSSO_TIME_NOSSO_TIME_CargoId",
                table: "NOSSO_TIME");

            migrationBuilder.DropTable(
                name: "CARGOS");

            migrationBuilder.DropIndex(
                name: "IX_NOSSO_TIME_CargoId",
                table: "NOSSO_TIME");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5404041b-2459-406c-b7ee-f5e03896f4a6", "2103567b-0a6f-45f4-9d4d-e0f219b74e21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "051c1a4a-8873-4acc-a88d-11a448866702", "2e39b85b-41cc-410f-a228-6153820d2446" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "051c1a4a-8873-4acc-a88d-11a448866702");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5404041b-2459-406c-b7ee-f5e03896f4a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2103567b-0a6f-45f4-9d4d-e0f219b74e21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e39b85b-41cc-410f-a228-6153820d2446");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "NOSSO_TIME");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "NOSSO_TIME",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb483eb9-4e61-4adf-93db-819f132e7604", "6e274051-06f1-462b-bc67-0e651b5ff1ab", "Administrador", "ADMINISTRADOR" },
                    { "3f1ba507-91fa-4101-aaea-7976d1eeb2e7", "5d6ae7c2-1b70-434b-a6ff-71b92985d563", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "866c5391-29c3-42fd-8850-d98b0d5465db", 0, "4c8d11d1-cb4d-4a3d-8b4d-869a4ba7d07b", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEDz1AOiCd83NhjbX33Ia7Oc6oyBjWY9PakGQu5prUryC95hJN2nWFj/XiiPj2xbofg==", null, false, "37966223", false, "admin@vidracariaportal.com.br" },
                    { "98a55741-73cc-4ce7-92b8-4c2c1c0578d5", 0, "1a01d314-dc47-4d06-940f-e8994bbabdf5", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEOqC6F0OTeUFqzK/LaKyHSChjsehGQCZsmh61109oiy5sLWHcn25bPNoHzJUf+pszg==", null, false, "6151694", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb483eb9-4e61-4adf-93db-819f132e7604", "866c5391-29c3-42fd-8850-d98b0d5465db" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3f1ba507-91fa-4101-aaea-7976d1eeb2e7", "98a55741-73cc-4ce7-92b8-4c2c1c0578d5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb483eb9-4e61-4adf-93db-819f132e7604", "866c5391-29c3-42fd-8850-d98b0d5465db" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f1ba507-91fa-4101-aaea-7976d1eeb2e7", "98a55741-73cc-4ce7-92b8-4c2c1c0578d5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f1ba507-91fa-4101-aaea-7976d1eeb2e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb483eb9-4e61-4adf-93db-819f132e7604");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "866c5391-29c3-42fd-8850-d98b0d5465db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98a55741-73cc-4ce7-92b8-4c2c1c0578d5");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "NOSSO_TIME");

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "NOSSO_TIME",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CARGOS",
                columns: table => new
                {
                    CodigoCargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeCargo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARGOS", x => x.CodigoCargo);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5404041b-2459-406c-b7ee-f5e03896f4a6", "bbc853c8-a10d-49cd-b7c6-14d65a055e29", "Administrador", "ADMINISTRADOR" },
                    { "051c1a4a-8873-4acc-a88d-11a448866702", "36fce250-c8a8-47f5-9a32-b3963ac2a1a1", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2103567b-0a6f-45f4-9d4d-e0f219b74e21", 0, "e410bc5c-0253-40a8-9646-6323ddbafc76", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEGfos648xoxfhjUowRYdvT4IRbsNt6Z78Nz79twHkaGzPNtfr5SoKXCZybjzmO/9gg==", null, false, "21418771", false, "admin@vidracariaportal.com.br" },
                    { "2e39b85b-41cc-410f-a228-6153820d2446", 0, "a73afaef-60db-4b45-b43f-b42ec06b3048", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEF7C3jTYWLW42L3nY/GGjbTVz8q1fraRMv1IpnXmTEXmp9eSlk57T6Po0nderyj+kg==", null, false, "58551215", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5404041b-2459-406c-b7ee-f5e03896f4a6", "2103567b-0a6f-45f4-9d4d-e0f219b74e21" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "051c1a4a-8873-4acc-a88d-11a448866702", "2e39b85b-41cc-410f-a228-6153820d2446" });

            migrationBuilder.CreateIndex(
                name: "IX_NOSSO_TIME_CargoId",
                table: "NOSSO_TIME",
                column: "CargoId");

            migrationBuilder.AddForeignKey(
                name: "FK_NOSSO_TIME_NOSSO_TIME_CargoId",
                table: "NOSSO_TIME",
                column: "CargoId",
                principalTable: "NOSSO_TIME",
                principalColumn: "CodigoTIme",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
