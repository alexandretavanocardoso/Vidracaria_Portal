using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Servicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "238ffeba-daff-4697-9ece-c40a38e5a9a4", "1dffcb94-583b-4ff5-a24e-67d92f0129d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9c42ad2-f1bc-42af-81db-b54979e2d94a", "5422b264-c428-4307-9fc0-dd314e44c607" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "238ffeba-daff-4697-9ece-c40a38e5a9a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9c42ad2-f1bc-42af-81db-b54979e2d94a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dffcb94-583b-4ff5-a24e-67d92f0129d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5422b264-c428-4307-9fc0-dd314e44c607");

            migrationBuilder.CreateTable(
                name: "SERVICOS",
                columns: table => new
                {
                    CodigoServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeServico = table.Column<string>(type: "text", nullable: true),
                    Imagem = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVICOS", x => x.CodigoServico);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SERVICOS");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c9c42ad2-f1bc-42af-81db-b54979e2d94a", "60060245-a0b4-40d7-b483-64773e41864b", "Administrador", "ADMINISTRADOR" },
                    { "238ffeba-daff-4697-9ece-c40a38e5a9a4", "f7e7584e-deff-4c55-8f9d-26a5bd091f7b", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5422b264-c428-4307-9fc0-dd314e44c607", 0, "4fa953f1-8551-4a7f-9295-06a390fe2318", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEMlCC2cqQVr/SbQYPSXFqJB1O8MpelN3qwzGNZWUJrTlMXbtVtD2U6s/2tehi7bYtA==", null, false, "2750866", false, "admin@vidracariaportal.com.br" },
                    { "1dffcb94-583b-4ff5-a24e-67d92f0129d3", 0, "4da08388-94af-4a31-8f8a-7c3e5d515119", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEJrkfkkI0jao5vT+f2n6r5yC9lPziEUUgxT37/Thvf1xvbvPZyFe5pKOj1hbYD4RKg==", null, false, "24757801", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c9c42ad2-f1bc-42af-81db-b54979e2d94a", "5422b264-c428-4307-9fc0-dd314e44c607" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "238ffeba-daff-4697-9ece-c40a38e5a9a4", "1dffcb94-583b-4ff5-a24e-67d92f0129d3" });
        }
    }
}
