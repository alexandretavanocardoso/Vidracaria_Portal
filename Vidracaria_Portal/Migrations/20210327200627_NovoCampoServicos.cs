using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class NovoCampoServicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc3d0d2b-90d7-4c22-bc5c-56dedaeed1d4", "652f9f95-0e34-44f7-a29a-18014d433dc1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1699acd-2b42-4198-965d-0a0f52fad33b", "b05e4aba-b563-4d27-8636-a362d3eb5f81" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3d0d2b-90d7-4c22-bc5c-56dedaeed1d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1699acd-2b42-4198-965d-0a0f52fad33b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "652f9f95-0e34-44f7-a29a-18014d433dc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05e4aba-b563-4d27-8636-a362d3eb5f81");

            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "ORCAMENTOS",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "CONCLUIDOS",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "APROVADOS",
                type: "text",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "ORCAMENTOS");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "CONCLUIDOS");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "APROVADOS");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d1699acd-2b42-4198-965d-0a0f52fad33b", "16201e96-d7a9-4131-8c48-1fa912af7401", "Administrador", "ADMINISTRADOR" },
                    { "bc3d0d2b-90d7-4c22-bc5c-56dedaeed1d4", "9676424d-4f15-41e1-92c7-21ca26415f20", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b05e4aba-b563-4d27-8636-a362d3eb5f81", 0, "c3e8b902-ef6d-47aa-b4fe-a21926f690c8", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEJ4nWy1Q1HfdK4VgQmGZmWoSawwJN8Y2IAj+CBQwZEhVPWqZ2YBJxjqH02anH/bQvw==", null, false, "30131813", false, "admin@vidracariaportal.com.br" },
                    { "652f9f95-0e34-44f7-a29a-18014d433dc1", 0, "8249c7e1-4d11-4dea-8e10-62e5a6a24d32", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEIHDsz7L4WhUOhF0I0nxqHitOz+fFFIhrsIxMoY0YTNWOc0K0DJvFvCJosuupTt7yA==", null, false, "2750866", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d1699acd-2b42-4198-965d-0a0f52fad33b", "b05e4aba-b563-4d27-8636-a362d3eb5f81" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bc3d0d2b-90d7-4c22-bc5c-56dedaeed1d4", "652f9f95-0e34-44f7-a29a-18014d433dc1" });
        }
    }
}
