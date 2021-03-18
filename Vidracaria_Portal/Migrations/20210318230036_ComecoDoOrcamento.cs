using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class ComecoDoOrcamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "ORCAMENTOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "ORCAMENTOS",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "ORCAMENTOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "ORCAMENTOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoServicoCodigoTipo",
                table: "ORCAMENTOS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "AGENDA",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TIPOS_DE_SERVICOS",
                columns: table => new
                {
                    CodigoTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_DE_SERVICOS", x => x.CodigoTipo);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e7374925-183c-4db5-b647-d1af81809e86", "fdb32e7d-0dd4-4ab0-82cf-055957c4c621", "Administrador", "ADMINISTRADOR" },
                    { "08042425-4bcd-48b6-8142-32c0e6e314f3", "e5bc7e1f-0eaa-4a28-8211-0103c79e9923", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8806c5f6-3ccd-4ecb-99f5-f4a4e56363b9", 0, "195ff4d6-a495-46d8-809e-34fce47dc8f4", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEIArsl4GO9g1JLYUwN+KZAhSyT5YN9HVMB4VxkixdBir1qicfYGngVk09/xKOZjb9g==", null, false, "32481801", false, "admin@vidracariaportal.com.br" },
                    { "de140698-8ba5-4a37-8f97-cff2d5797357", 0, "3bb72190-f62f-4942-bce5-ba1d571819ac", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEDCAM7tt7GNyZ+tl8KoAM5mYC6+mZuY1H3Pvsg9z9c063cqsHwr2ExpBpVNFypTtoQ==", null, false, "23900756", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e7374925-183c-4db5-b647-d1af81809e86", "8806c5f6-3ccd-4ecb-99f5-f4a4e56363b9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "08042425-4bcd-48b6-8142-32c0e6e314f3", "de140698-8ba5-4a37-8f97-cff2d5797357" });

            migrationBuilder.CreateIndex(
                name: "IX_ORCAMENTOS_TipoServicoCodigoTipo",
                table: "ORCAMENTOS",
                column: "TipoServicoCodigoTipo");

            migrationBuilder.AddForeignKey(
                name: "FK_ORCAMENTOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo",
                table: "ORCAMENTOS",
                column: "TipoServicoCodigoTipo",
                principalTable: "TIPOS_DE_SERVICOS",
                principalColumn: "CodigoTipo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORCAMENTOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo",
                table: "ORCAMENTOS");

            migrationBuilder.DropTable(
                name: "TIPOS_DE_SERVICOS");

            migrationBuilder.DropIndex(
                name: "IX_ORCAMENTOS_TipoServicoCodigoTipo",
                table: "ORCAMENTOS");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e7374925-183c-4db5-b647-d1af81809e86", "8806c5f6-3ccd-4ecb-99f5-f4a4e56363b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08042425-4bcd-48b6-8142-32c0e6e314f3", "de140698-8ba5-4a37-8f97-cff2d5797357" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08042425-4bcd-48b6-8142-32c0e6e314f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7374925-183c-4db5-b647-d1af81809e86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8806c5f6-3ccd-4ecb-99f5-f4a4e56363b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de140698-8ba5-4a37-8f97-cff2d5797357");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "ORCAMENTOS");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "ORCAMENTOS");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "ORCAMENTOS");

            migrationBuilder.DropColumn(
                name: "TipoServicoCodigoTipo",
                table: "ORCAMENTOS");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "ORCAMENTOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "AGENDA",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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
    }
}
