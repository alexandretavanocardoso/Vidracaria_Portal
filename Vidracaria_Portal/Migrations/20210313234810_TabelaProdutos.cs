using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class TabelaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    Codigo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Cor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    EstoqueMaximo = table.Column<int>(type: "int", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoFabrica = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f2d15357-3c5e-4919-bbce-de26a9d2d356", "011a1722-a151-40fb-9f8a-55191ca0c6db", "Administrador", "ADMINISTRADOR" },
                    { "0797cc07-6a1b-4034-a5f6-450fafe2bcdc", "9cd9a149-c3e0-4921-9062-3b6d0a2aa490", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f6955dd-ca59-48e3-963f-2b36a554dec0", 0, "7c8a2ad6-4aaf-4e90-bc0a-6cd1149c8a4b", new DateTime(2021, 3, 13, 20, 48, 9, 577, DateTimeKind.Local).AddTicks(5643), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEH9ZJ4dop8IVwZ1JJiREKgl11kt/Er1g4raYDE95ZclG0OnNgzjfG/fzy3tCEdTgnA==", null, false, "47176343", false, "admin@vidracariaportal.com.br" },
                    { "49639d2c-4698-43e1-859b-8825217a0be5", 0, "91463216-d900-4230-8bf6-29aa79e5d762", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAECdlC1RGoR835BJlhFaFxL11grOdTY5ajLkMBvbENMBIHEbn0Nyvt/YtwJwDY47jeA==", null, false, "21933905", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f2d15357-3c5e-4919-bbce-de26a9d2d356", "1f6955dd-ca59-48e3-963f-2b36a554dec0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0797cc07-6a1b-4034-a5f6-450fafe2bcdc", "49639d2c-4698-43e1-859b-8825217a0be5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2d15357-3c5e-4919-bbce-de26a9d2d356", "1f6955dd-ca59-48e3-963f-2b36a554dec0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0797cc07-6a1b-4034-a5f6-450fafe2bcdc", "49639d2c-4698-43e1-859b-8825217a0be5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0797cc07-6a1b-4034-a5f6-450fafe2bcdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2d15357-3c5e-4919-bbce-de26a9d2d356");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6955dd-ca59-48e3-963f-2b36a554dec0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49639d2c-4698-43e1-859b-8825217a0be5");

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
    }
}
