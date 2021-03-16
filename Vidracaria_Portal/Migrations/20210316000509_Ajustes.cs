using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class Ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "280d58e4-ca74-4d08-a6ca-54df120fef76", "45513363-adc7-412e-a768-fb72457c8c53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b06ecb3-fad7-4316-b563-b3423af23ce7", "83c92e85-8ee2-49a7-988b-d53496add641" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "280d58e4-ca74-4d08-a6ca-54df120fef76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b06ecb3-fad7-4316-b563-b3423af23ce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45513363-adc7-412e-a768-fb72457c8c53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83c92e85-8ee2-49a7-988b-d53496add641");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoVenda",
                table: "VIDROS_TEMPERADOS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoFabrica",
                table: "VIDROS_TEMPERADOS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoVenda",
                table: "VIDROS_COMUNS",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoFabrica",
                table: "VIDROS_COMUNS",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoVenda",
                table: "PRODUTOS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoFabrica",
                table: "PRODUTOS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoVenda",
                table: "FERRAGENS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoFabrica",
                table: "FERRAGENS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoVenda",
                table: "ALUMINIOS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecoFabrica",
                table: "ALUMINIOS",
                type: "text",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoVenda",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoFabrica",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "PrecoVenda",
                table: "VIDROS_COMUNS",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "PrecoFabrica",
                table: "VIDROS_COMUNS",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoVenda",
                table: "PRODUTOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoFabrica",
                table: "PRODUTOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoVenda",
                table: "FERRAGENS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoFabrica",
                table: "FERRAGENS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoVenda",
                table: "ALUMINIOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoFabrica",
                table: "ALUMINIOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "280d58e4-ca74-4d08-a6ca-54df120fef76", "abcfde5d-4b5e-4840-8023-4a09f4572ffe", "Administrador", "ADMINISTRADOR" },
                    { "2b06ecb3-fad7-4316-b563-b3423af23ce7", "f2eb90ca-999d-4581-b25b-b7a8371e0d80", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "45513363-adc7-412e-a768-fb72457c8c53", 0, "1650e872-2a36-4d48-bf42-4b27133bb52b", new DateTime(2021, 3, 14, 22, 28, 22, 982, DateTimeKind.Local).AddTicks(6186), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEHZ2naVI7UADWwoq8uBmFelPLrtnWqGePQ5W6V6A5MOe3E4Iw5VIBsKQTezXqg5jVA==", null, false, "63261412", false, "admin@vidracariaportal.com.br" },
                    { "83c92e85-8ee2-49a7-988b-d53496add641", 0, "2728c3fb-ffb8-4973-af53-c23277d12551", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEL6ix0qy4ieZFJ7Nu21o4tracfCdXaImiaD2jZDfwgKvBcoH9T8Eh/Fx0xmTGViPdg==", null, false, "32481801", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "280d58e4-ca74-4d08-a6ca-54df120fef76", "45513363-adc7-412e-a768-fb72457c8c53" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b06ecb3-fad7-4316-b563-b3423af23ce7", "83c92e85-8ee2-49a7-988b-d53496add641" });
        }
    }
}
