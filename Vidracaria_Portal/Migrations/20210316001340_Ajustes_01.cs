using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class Ajustes_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd4a8f6f-ec82-4a73-9c79-45b659907960", "3d19c697-d663-4bd1-b0c0-c9e69a4510f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6854664-b5bf-4c32-b27e-98bf78bc481a", "d6503d99-f20b-453c-87d8-4407554805ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd4a8f6f-ec82-4a73-9c79-45b659907960");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6854664-b5bf-4c32-b27e-98bf78bc481a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d19c697-d663-4bd1-b0c0-c9e69a4510f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6503d99-f20b-453c-87d8-4407554805ec");

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "CLIENTES",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b01e77c-f311-40ba-a0c7-6627dda95023", "41485ec8-76ca-417c-b0f7-50d3c9c72091", "Administrador", "ADMINISTRADOR" },
                    { "d4bd9be2-8365-4382-aee2-bc42d96818c8", "95961633-7d1e-4d01-9432-6ed29e705892", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "762dc07c-3f03-4313-9311-8227b17aa377", 0, "088e7ccf-c53a-4ba1-be7d-1afa0ccc8ee2", new DateTime(2021, 3, 15, 21, 13, 39, 282, DateTimeKind.Local).AddTicks(6785), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEEw8XNsVK0OBpV8BSuD/ycq0d7vR3b4HDfieHRX8+5OZWRdsJZ3CWdTI0eFR432x4g==", null, false, "63261412", false, "admin@vidracariaportal.com.br" },
                    { "a388d371-d61e-4607-833e-42af0435ae08", 0, "ee00cbdb-ebf4-48ef-80ec-982f260fd31d", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAECI82wPwdGS+LVgq3oRzTk9Mibp0lP9XdR43x+3y3qfhXtbRMyh3HIAgdzqHsNx8dg==", null, false, "32481801", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1b01e77c-f311-40ba-a0c7-6627dda95023", "762dc07c-3f03-4313-9311-8227b17aa377" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d4bd9be2-8365-4382-aee2-bc42d96818c8", "a388d371-d61e-4607-833e-42af0435ae08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b01e77c-f311-40ba-a0c7-6627dda95023", "762dc07c-3f03-4313-9311-8227b17aa377" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4bd9be2-8365-4382-aee2-bc42d96818c8", "a388d371-d61e-4607-833e-42af0435ae08" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b01e77c-f311-40ba-a0c7-6627dda95023");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4bd9be2-8365-4382-aee2-bc42d96818c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "762dc07c-3f03-4313-9311-8227b17aa377");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a388d371-d61e-4607-833e-42af0435ae08");

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "CLIENTES",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cd4a8f6f-ec82-4a73-9c79-45b659907960", "7e2af3a6-71f6-4046-a3cd-6539a33733e4", "Administrador", "ADMINISTRADOR" },
                    { "f6854664-b5bf-4c32-b27e-98bf78bc481a", "9c188eb0-b295-4f6a-8520-bfbf2c961e89", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d19c697-d663-4bd1-b0c0-c9e69a4510f2", 0, "90fc63ab-ccc3-4e3c-8975-8beaf005f274", new DateTime(2021, 3, 15, 21, 5, 8, 630, DateTimeKind.Local).AddTicks(8168), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEE5VXXK5kp+3MtZNN4UKB3NN0ohJn8f4pGrWRqxM+j+bw4Vry4aNk5ZLqj3I1s21/Q==", null, false, "63261412", false, "admin@vidracariaportal.com.br" },
                    { "d6503d99-f20b-453c-87d8-4407554805ec", 0, "713f21de-a3f6-4ff2-bbae-8b7fe76ca9d3", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEG1wx0MVdyouMvtDJrzIToBk0Tg+PwJZtzYdVINvQ5GUMGkiyziFU0JJkwQ+eKkMpA==", null, false, "32481801", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cd4a8f6f-ec82-4a73-9c79-45b659907960", "3d19c697-d663-4bd1-b0c0-c9e69a4510f2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f6854664-b5bf-4c32-b27e-98bf78bc481a", "d6503d99-f20b-453c-87d8-4407554805ec" });
        }
    }
}
