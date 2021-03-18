using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class AdicionandoAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36144dcd-6bc5-4980-9c7a-64a7f0d69f1c", "080905d3-a941-4100-b35a-cbdc8eda222b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "52bcfa46-1fd7-4509-8919-8e0d651afb79", "ea5bbba4-1e98-4c61-ac16-5008d4a90c4e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36144dcd-6bc5-4980-9c7a-64a7f0d69f1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52bcfa46-1fd7-4509-8919-8e0d651afb79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080905d3-a941-4100-b35a-cbdc8eda222b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea5bbba4-1e98-4c61-ac16-5008d4a90c4e");

            migrationBuilder.CreateTable(
                name: "AGENDA",
                columns: table => new
                {
                    CodigoAgenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Texto = table.Column<string>(type: "text", nullable: true),
                    Assunto = table.Column<string>(type: "text", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataLimite = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENDA", x => x.CodigoAgenda);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f935d751-2867-483f-b449-394843eb3166", "b14c8559-dd53-45e8-80b3-85cd068b67c3", "Administrador", "ADMINISTRADOR" },
                    { "25eb9a0b-ee5e-4cd0-8269-1dc6871d950d", "af9971f9-7c14-4a46-87e9-6a14f129ae28", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3db2c5b4-a8e3-4253-aa33-a2335348e1a5", 0, "8e460264-d6f0-4357-a4ce-2ddec6b7fdbf", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEHZIuCPAMFFeCCY6BgIYFiKiiAZ+7bu50dBVyVgQT3zX0sodXwoYnJ8JR+GURJy/4g==", null, false, "36771698", false, "admin@vidracariaportal.com.br" },
                    { "e3f64d5b-556c-4064-a059-3b9e194c9927", 0, "869b082b-9aaf-46a4-8f74-3724034f0074", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEFKZ6U5nIY2Dg+k9lxZGzW9KMLGmT/KMLzmIigRiRZlMC14FFc9OJDNbhYuavDroMg==", null, false, "62509834", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f935d751-2867-483f-b449-394843eb3166", "3db2c5b4-a8e3-4253-aa33-a2335348e1a5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "25eb9a0b-ee5e-4cd0-8269-1dc6871d950d", "e3f64d5b-556c-4064-a059-3b9e194c9927" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGENDA");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f935d751-2867-483f-b449-394843eb3166", "3db2c5b4-a8e3-4253-aa33-a2335348e1a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25eb9a0b-ee5e-4cd0-8269-1dc6871d950d", "e3f64d5b-556c-4064-a059-3b9e194c9927" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25eb9a0b-ee5e-4cd0-8269-1dc6871d950d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f935d751-2867-483f-b449-394843eb3166");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3db2c5b4-a8e3-4253-aa33-a2335348e1a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3f64d5b-556c-4064-a059-3b9e194c9927");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52bcfa46-1fd7-4509-8919-8e0d651afb79", "f334e7d9-e4bf-4e20-822c-7a4ad750896e", "Administrador", "ADMINISTRADOR" },
                    { "36144dcd-6bc5-4980-9c7a-64a7f0d69f1c", "3c2d51c6-c4fb-4ef9-afa2-7cf6ee2b2fb3", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ea5bbba4-1e98-4c61-ac16-5008d4a90c4e", 0, "5b2da004-4e90-4b59-b809-cc6395093146", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEJCAph0J+YlQhZDs6gJ2GGBcbcCBIvwYU+kxN4jErCsIYy+cm6ItamNUX4P7lem22A==", null, false, "64665535", false, "admin@vidracariaportal.com.br" },
                    { "080905d3-a941-4100-b35a-cbdc8eda222b", 0, "535201ff-0d54-4409-89b7-eb1df4b3902a", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEAAtl2NAYcqfYGzI1JaURqfyDW/XcCx5Zg/6S/32OH+2nI95aCoRAjHDHFEDt4McSA==", null, false, "45118907", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "52bcfa46-1fd7-4509-8919-8e0d651afb79", "ea5bbba4-1e98-4c61-ac16-5008d4a90c4e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "36144dcd-6bc5-4980-9c7a-64a7f0d69f1c", "080905d3-a941-4100-b35a-cbdc8eda222b" });
        }
    }
}
