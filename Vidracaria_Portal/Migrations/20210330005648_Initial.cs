using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1843365-3298-400b-997a-903affd186b3", "83ceea67-d002-4804-98f5-742a37e5c332" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9941e63f-5232-4c39-8948-bfc427ededaf", "d01db3aa-64eb-4260-8d25-8cb505b9d444" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9941e63f-5232-4c39-8948-bfc427ededaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1843365-3298-400b-997a-903affd186b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83ceea67-d002-4804-98f5-742a37e5c332");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d01db3aa-64eb-4260-8d25-8cb505b9d444");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5327a433-2ea0-46bf-9aae-c771f98c577d", "90f71724-5474-4591-973f-aa0a5a5a41c7", "Administrador", "ADMINISTRADOR" },
                    { "691f9138-81b5-4b90-bfa3-38a97d7a1aea", "4cc65901-4d12-498d-a250-b06e92d86436", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ec9ee7ae-f1c3-45dd-9ee6-ddc161afa53d", 0, "85f6c8ad-f2b1-4218-a228-169f248d6791", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEN01F8pOHjTE7msmiVuwhXEqC9N5rQvI5aE1amviPHfzFj+dM06Puuh3Uqm3HT7f8w==", null, false, "37966223", false, "admin@vidracariaportal.com.br" },
                    { "74f6179f-cc12-4ed0-ad7f-5007160434dd", 0, "17539e7b-9eee-47ce-9296-eea102db125a", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEBkuQMj+TetzM6ijyHrJy3bT92YfKHzT5lzeMnpo49Mf/Jl5iF13lCKnlneBob7b2w==", null, false, "6151694", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5327a433-2ea0-46bf-9aae-c771f98c577d", "ec9ee7ae-f1c3-45dd-9ee6-ddc161afa53d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "691f9138-81b5-4b90-bfa3-38a97d7a1aea", "74f6179f-cc12-4ed0-ad7f-5007160434dd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "691f9138-81b5-4b90-bfa3-38a97d7a1aea", "74f6179f-cc12-4ed0-ad7f-5007160434dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5327a433-2ea0-46bf-9aae-c771f98c577d", "ec9ee7ae-f1c3-45dd-9ee6-ddc161afa53d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5327a433-2ea0-46bf-9aae-c771f98c577d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "691f9138-81b5-4b90-bfa3-38a97d7a1aea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74f6179f-cc12-4ed0-ad7f-5007160434dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec9ee7ae-f1c3-45dd-9ee6-ddc161afa53d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9941e63f-5232-4c39-8948-bfc427ededaf", "8baddff7-a11b-49da-a6ae-6a7db6239490", "Administrador", "ADMINISTRADOR" },
                    { "e1843365-3298-400b-997a-903affd186b3", "ed6f2e82-f6e8-4396-a998-01a143c941c8", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d01db3aa-64eb-4260-8d25-8cb505b9d444", 0, "f26f467d-cbc6-47d8-b8c2-ae3c90450e16", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEKOmu0twm788QVAMLfpIFZv85qcVY8xlYU1UDrAsxduuWnPt1208UbjTXJwcFco+aw==", null, false, "48957711", false, "admin@vidracariaportal.com.br" },
                    { "83ceea67-d002-4804-98f5-742a37e5c332", 0, "5934fc21-0f95-4591-b546-71aa42c9248e", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEBwZF5WRd0L6kHfaKHaObysm3ltIGenEtKfGNfKv7feQQiUz3C7/ro/uaMpwkwQxLQ==", null, false, "37966223", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9941e63f-5232-4c39-8948-bfc427ededaf", "d01db3aa-64eb-4260-8d25-8cb505b9d444" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e1843365-3298-400b-997a-903affd186b3", "83ceea67-d002-4804-98f5-742a37e5c332" });
        }
    }
}
