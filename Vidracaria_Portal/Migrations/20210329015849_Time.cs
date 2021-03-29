using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49d07712-559d-4ad4-b025-c5969ac439d4", "8baaa558-2255-4543-a24e-339bc6504d46" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec557f23-9292-4f6d-b1e9-f9f227bcacf3", "bd3820d1-1a0e-4e52-b98e-77d686fdc4c8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49d07712-559d-4ad4-b025-c5969ac439d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec557f23-9292-4f6d-b1e9-f9f227bcacf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baaa558-2255-4543-a24e-339bc6504d46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3820d1-1a0e-4e52-b98e-77d686fdc4c8");

            migrationBuilder.CreateTable(
                name: "NOSSO_TIME",
                columns: table => new
                {
                    CodigoTIme = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeTime = table.Column<string>(type: "text", nullable: true),
                    Cargo = table.Column<string>(type: "text", nullable: true),
                    Imagem = table.Column<string>(type: "text", nullable: true),
                    LinkFacebook = table.Column<string>(type: "text", nullable: true),
                    LinkImagem = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOSSO_TIME", x => x.CodigoTIme);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7bcdab2-5e1e-4725-b1f2-04eb06b25767", "6c16aab0-2979-4848-8c3c-8d5aa1d6dd2f", "Administrador", "ADMINISTRADOR" },
                    { "41e7ced3-dbbd-426e-9d89-ab105655365d", "c8f6117e-3446-48a7-a0f5-508da617069e", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d39d4bf-4cd4-4761-9e3a-9eccda18df2f", 0, "a0df24cf-07a1-4b93-97ef-e382fca98264", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAECD3LZvgWvTySycgjFH2xTwGXFZuILKjJJI+bOrvLUixzriWF3jt1V+0smTt0ovaYQ==", null, false, "37966223", false, "admin@vidracariaportal.com.br" },
                    { "d8143ca6-55d3-4779-9f9b-d4403451a9f8", 0, "7656e0da-29f8-4fa4-b5c5-caac29632dd5", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEAq1JyfRZDwi4LYWA5fQUriQ64ry7FmCpwKUHJaWMyHqQ57bDycA48KjpTNIfRJkPg==", null, false, "6151694", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7bcdab2-5e1e-4725-b1f2-04eb06b25767", "1d39d4bf-4cd4-4761-9e3a-9eccda18df2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "41e7ced3-dbbd-426e-9d89-ab105655365d", "d8143ca6-55d3-4779-9f9b-d4403451a9f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NOSSO_TIME");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7bcdab2-5e1e-4725-b1f2-04eb06b25767", "1d39d4bf-4cd4-4761-9e3a-9eccda18df2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41e7ced3-dbbd-426e-9d89-ab105655365d", "d8143ca6-55d3-4779-9f9b-d4403451a9f8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41e7ced3-dbbd-426e-9d89-ab105655365d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7bcdab2-5e1e-4725-b1f2-04eb06b25767");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d39d4bf-4cd4-4761-9e3a-9eccda18df2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8143ca6-55d3-4779-9f9b-d4403451a9f8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec557f23-9292-4f6d-b1e9-f9f227bcacf3", "17c866c9-a57b-4584-abb4-3e9db6043de3", "Administrador", "ADMINISTRADOR" },
                    { "49d07712-559d-4ad4-b025-c5969ac439d4", "ec119a7f-3472-493b-9f60-0c0a4558bd5c", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bd3820d1-1a0e-4e52-b98e-77d686fdc4c8", 0, "beeaefea-ecec-4413-9d20-0f058268bb1b", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEF2bUz87pndA9p5VF9nl5Wm2hd1ojoecm0g+WMRLkpZd5Sp47GwWwVZ71yxtFITdAA==", null, false, "13780214", false, "admin@vidracariaportal.com.br" },
                    { "8baaa558-2255-4543-a24e-339bc6504d46", 0, "7fbaaeaa-5eb9-42b0-ac14-ca1cb104369c", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEFof7vQZ4glKBsV5941UANewDhtregamsD2M6K2FwK6/XDmuRySoHcj77DU/+He7mw==", null, false, "56913064", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ec557f23-9292-4f6d-b1e9-f9f227bcacf3", "bd3820d1-1a0e-4e52-b98e-77d686fdc4c8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "49d07712-559d-4ad4-b025-c5969ac439d4", "8baaa558-2255-4543-a24e-339bc6504d46" });
        }
    }
}
