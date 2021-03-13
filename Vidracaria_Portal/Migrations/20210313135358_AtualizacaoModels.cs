using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class AtualizacaoModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb42e9e4-1c97-41e2-b746-f0bdadbe2d65", "1f48dc88-33e6-46e5-9914-8f4bbd27884e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13f0eea5-f883-4975-a780-709f0e994547", "f637586f-8624-4d4f-8714-9b81953b6606" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13f0eea5-f883-4975-a780-709f0e994547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb42e9e4-1c97-41e2-b746-f0bdadbe2d65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f48dc88-33e6-46e5-9914-8f4bbd27884e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f637586f-8624-4d4f-8714-9b81953b6606");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "PENDENTES");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PENDENTES");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "ORCAMENTOS");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ORCAMENTOS");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "CONCLUIDOS");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CONCLUIDOS");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "APROVADOS");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "APROVADOS");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "PENDENTES",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "ORCAMENTOS",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "CONCLUIDOS",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "APROVADOS",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69208b36-c62c-4219-b5da-b63c52a0b5eb", "bf8dff5b-6b4d-4779-b41a-7dc6b34488e7", "Administrador", "ADMINISTRADOR" },
                    { "0c42e19f-670e-49f6-90bd-6fbadd40ed3f", "f06f6d2c-319f-465e-865a-5754278a13f9", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "be44ecd7-88f2-4853-a763-c4d509f140c1", 0, "c028da9a-fcfb-4ed1-b1ff-317bb0d2bcfd", new DateTime(2021, 3, 13, 10, 53, 57, 480, DateTimeKind.Local).AddTicks(8767), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEMG4tqLKWfrYAeVN2teGb/9wOy5BzVL6yY64pUb4On4g8DRzIqFbbSJwzBCd0T1fXA==", null, false, "32922880", false, "admin@vidracariaportal.com.br" },
                    { "f7b972e8-8655-4e2b-bdfc-5a22ff959ba1", 0, "986f2a70-6be2-4a9f-a967-72b7155ab9c5", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAELOsb7AmFNNwVSoQm03eTFx/+xQ/rm5YAHx/P3lY4xNXiw0lv/VHkD9WMo1ryFGMDQ==", null, false, "27870469", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69208b36-c62c-4219-b5da-b63c52a0b5eb", "be44ecd7-88f2-4853-a763-c4d509f140c1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c42e19f-670e-49f6-90bd-6fbadd40ed3f", "f7b972e8-8655-4e2b-bdfc-5a22ff959ba1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69208b36-c62c-4219-b5da-b63c52a0b5eb", "be44ecd7-88f2-4853-a763-c4d509f140c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c42e19f-670e-49f6-90bd-6fbadd40ed3f", "f7b972e8-8655-4e2b-bdfc-5a22ff959ba1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c42e19f-670e-49f6-90bd-6fbadd40ed3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69208b36-c62c-4219-b5da-b63c52a0b5eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be44ecd7-88f2-4853-a763-c4d509f140c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7b972e8-8655-4e2b-bdfc-5a22ff959ba1");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "PENDENTES",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "PENDENTES",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PENDENTES",
                type: "text",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "ORCAMENTOS",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "ORCAMENTOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ORCAMENTOS",
                type: "text",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "CONCLUIDOS",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "CONCLUIDOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CONCLUIDOS",
                type: "text",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "APROVADOS",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "APROVADOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "APROVADOS",
                type: "text",
                nullable: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13f0eea5-f883-4975-a780-709f0e994547", "14f34493-9f53-484c-849c-1f9c5f95a73b", "Administrador", "ADMINISTRADOR" },
                    { "cb42e9e4-1c97-41e2-b746-f0bdadbe2d65", "702f0189-ce16-40aa-a3b5-96dc763a218f", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f637586f-8624-4d4f-8714-9b81953b6606", 0, "80a6f1e6-ee6c-40be-98bc-73a74b6591e3", new DateTime(2021, 3, 12, 23, 43, 36, 59, DateTimeKind.Local).AddTicks(500), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEJbhZ4XC4+xpTdxVM2xgnQIScKe6DM8yKClPHMbIP82Asu8azwexKQMiFMbBB4KpRg==", null, false, "32922880", false, "admin@vidracariaportal.com.br" },
                    { "1f48dc88-33e6-46e5-9914-8f4bbd27884e", 0, "02aefb4e-20b3-43bb-9980-9635edef8f2c", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAENio8+isGDQ4XOK+bJHxhrmypAcXs3bk389q1aexIOOzgQywh023ROr8RXM06IcYSA==", null, false, "27870469", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "13f0eea5-f883-4975-a780-709f0e994547", "f637586f-8624-4d4f-8714-9b81953b6606" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cb42e9e4-1c97-41e2-b746-f0bdadbe2d65", "1f48dc88-33e6-46e5-9914-8f4bbd27884e" });
        }
    }
}
