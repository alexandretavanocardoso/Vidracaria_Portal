using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Ajustes_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ALUMINIOS_EXPESSURA_ExpessuraId",
                table: "ALUMINIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropTable(
                name: "CORES_VIDROS_COMUNS");

            migrationBuilder.DropTable(
                name: "CORES_VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_ALUMINIOS_ExpessuraId",
                table: "ALUMINIOS");

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

            migrationBuilder.DropColumn(
                name: "CorId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "CorId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "ExpessuraId",
                table: "ALUMINIOS");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CLIENTES",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75be7923-5a88-48df-89b7-0022ef6dcbb1", "70a1cb2e-8792-489d-899d-bdddce41b7e5", "Administrador", "ADMINISTRADOR" },
                    { "4f588c5a-baed-4c79-9281-02c8e5ac4042", "2d4127d2-067c-4360-b6af-36fbffdf1efc", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d0e7e79f-bcee-4dd4-bc13-4b2a1c7adbd9", 0, "c35b9b94-eb1e-40f7-9bb5-83310e0f9a5b", new DateTime(2021, 3, 15, 22, 45, 34, 669, DateTimeKind.Local).AddTicks(2424), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAENv/8zmdM+NqculNnlyISQmvAWn52l9K7EWaQytA77bTt5JMu4yitM3x8/bEgmDnqQ==", null, false, "45118907", false, "admin@vidracariaportal.com.br" },
                    { "5fb6db65-8bed-49cd-8f30-d906cb91a9b2", 0, "687f8f0d-8b2c-4e83-8a62-43c855be703d", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEAMumMkN3tnD3xjrlEiJDCecOg0zXxu8T32fPV9N+zYez/Uv5qYMpeK6X31vH8x9jQ==", null, false, "3416986", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "75be7923-5a88-48df-89b7-0022ef6dcbb1", "d0e7e79f-bcee-4dd4-bc13-4b2a1c7adbd9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4f588c5a-baed-4c79-9281-02c8e5ac4042", "5fb6db65-8bed-49cd-8f30-d906cb91a9b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f588c5a-baed-4c79-9281-02c8e5ac4042", "5fb6db65-8bed-49cd-8f30-d906cb91a9b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75be7923-5a88-48df-89b7-0022ef6dcbb1", "d0e7e79f-bcee-4dd4-bc13-4b2a1c7adbd9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f588c5a-baed-4c79-9281-02c8e5ac4042");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75be7923-5a88-48df-89b7-0022ef6dcbb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fb6db65-8bed-49cd-8f30-d906cb91a9b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0e7e79f-bcee-4dd4-bc13-4b2a1c7adbd9");

            migrationBuilder.AddColumn<int>(
                name: "CorId",
                table: "VIDROS_TEMPERADOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CorId",
                table: "VIDROS_COMUNS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CLIENTES",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "CLIENTES",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ExpessuraId",
                table: "ALUMINIOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CORES_VIDROS_COMUNS",
                columns: table => new
                {
                    CodigoCor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeCor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CORES_VIDROS_COMUNS", x => x.CodigoCor);
                });

            migrationBuilder.CreateTable(
                name: "CORES_VIDROS_TEMPERADOS",
                columns: table => new
                {
                    CodigoCor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeCor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CORES_VIDROS_TEMPERADOS", x => x.CodigoCor);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_ExpessuraId",
                table: "ALUMINIOS",
                column: "ExpessuraId");

            migrationBuilder.AddForeignKey(
                name: "FK_ALUMINIOS_EXPESSURA_ExpessuraId",
                table: "ALUMINIOS",
                column: "ExpessuraId",
                principalTable: "EXPESSURA",
                principalColumn: "CodigoExpessura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS",
                column: "CorId",
                principalTable: "CORES_VIDROS_COMUNS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS",
                column: "CorId",
                principalTable: "CORES_VIDROS_TEMPERADOS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
