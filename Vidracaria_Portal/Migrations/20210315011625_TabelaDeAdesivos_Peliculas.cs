using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class TabelaDeAdesivos_Peliculas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2febe6b-73cf-48e5-becf-f0143349da5f", "42ab97c4-0cbe-4535-958f-350fa587f38d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66760d1a-7cbd-4365-85a1-7bff1c5cc89e", "f0ac269f-3b42-4a65-be1d-bd2588269def" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66760d1a-7cbd-4365-85a1-7bff1c5cc89e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2febe6b-73cf-48e5-becf-f0143349da5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42ab97c4-0cbe-4535-958f-350fa587f38d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ac269f-3b42-4a65-be1d-bd2588269def");

            migrationBuilder.AddColumn<decimal>(
                name: "AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdesivoId",
                table: "VIDROS_TEMPERADOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "VIDROS_TEMPERADOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdesivoId",
                table: "VIDROS_COMUNS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "VIDROS_COMUNS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ADESIVOS",
                columns: table => new
                {
                    CodigoAdesivo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADESIVOS", x => x.CodigoAdesivo);
                });

            migrationBuilder.CreateTable(
                name: "PELICULAS",
                columns: table => new
                {
                    CodigoPelicula = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PELICULAS", x => x.CodigoPelicula);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a37b9a18-f0c2-4039-8ac7-f9b5d86d2524", "b688f1a3-8685-45a8-b87c-a8642844ceb3", "Administrador", "ADMINISTRADOR" },
                    { "e9cf507f-0c34-449f-a5fc-60da2cc5fa02", "2a2d84ed-c981-4f99-9a94-ab62ba131d7c", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8078f2a8-2913-4fb7-8881-64d75cb03a89", 0, "0b5c1878-2928-4fb7-852c-0057b6ec31be", new DateTime(2021, 3, 14, 22, 16, 24, 210, DateTimeKind.Local).AddTicks(5702), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAENrz1aX0o9XYFyhtoMAp4T1TCOo7keGx8vdXPD916K2karkBM5OHVfjBAzR5RrHV/w==", null, false, "63261412", false, "admin@vidracariaportal.com.br" },
                    { "4ee90492-104e-466b-8125-b87eff1b3fd7", 0, "0ceac0a5-63fb-4a2f-bfe7-17b5da626430", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEH3szZIe/G9FAY7+dBDPQohoUARG+GJtuzsnYYAtKWF1EtQ8Dzt/WcUHucQ0KiaH1Q==", null, false, "32481801", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a37b9a18-f0c2-4039-8ac7-f9b5d86d2524", "8078f2a8-2913-4fb7-8881-64d75cb03a89" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9cf507f-0c34-449f-a5fc-60da2cc5fa02", "4ee90492-104e-466b-8125-b87eff1b3fd7" });

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS",
                column: "AdesivoCodigoAdesivo");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS",
                column: "PeliculaCodigoPelicula");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS",
                column: "AdesivoCodigoAdesivo");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS",
                column: "PeliculaCodigoPelicula");

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_ADESIVOS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS",
                column: "AdesivoCodigoAdesivo",
                principalTable: "ADESIVOS",
                principalColumn: "CodigoAdesivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_PELICULAS_PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS",
                column: "PeliculaCodigoPelicula",
                principalTable: "PELICULAS",
                principalColumn: "CodigoPelicula",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_ADESIVOS_AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS",
                column: "AdesivoCodigoAdesivo",
                principalTable: "ADESIVOS",
                principalColumn: "CodigoAdesivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS",
                column: "PeliculaCodigoPelicula",
                principalTable: "PELICULAS",
                principalColumn: "CodigoPelicula",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_ADESIVOS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_PELICULAS_PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_ADESIVOS_AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropTable(
                name: "ADESIVOS");

            migrationBuilder.DropTable(
                name: "PELICULAS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9cf507f-0c34-449f-a5fc-60da2cc5fa02", "4ee90492-104e-466b-8125-b87eff1b3fd7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a37b9a18-f0c2-4039-8ac7-f9b5d86d2524", "8078f2a8-2913-4fb7-8881-64d75cb03a89" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a37b9a18-f0c2-4039-8ac7-f9b5d86d2524");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9cf507f-0c34-449f-a5fc-60da2cc5fa02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ee90492-104e-466b-8125-b87eff1b3fd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8078f2a8-2913-4fb7-8881-64d75cb03a89");

            migrationBuilder.DropColumn(
                name: "AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "AdesivoId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "AdesivoId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "VIDROS_COMUNS");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a2febe6b-73cf-48e5-becf-f0143349da5f", "34b76e39-5c61-4f14-b09e-8becb5d35c51", "Administrador", "ADMINISTRADOR" },
                    { "66760d1a-7cbd-4365-85a1-7bff1c5cc89e", "5f9c6b4b-0c3f-4dfe-bf55-9b879756babc", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "42ab97c4-0cbe-4535-958f-350fa587f38d", 0, "2783c467-54cb-4e99-a608-1ee3dcec4a35", new DateTime(2021, 3, 14, 22, 1, 25, 133, DateTimeKind.Local).AddTicks(8367), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEMD3ZNrzuQykZu1BU6M+aQwvQ3zYfEMlv9RD79WWZcoqkTOFdGvCq11qxoc7sekYlg==", null, false, "64665535", false, "admin@vidracariaportal.com.br" },
                    { "f0ac269f-3b42-4a65-be1d-bd2588269def", 0, "09f4f0af-7d49-458d-acd5-88be99f3c153", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEJ/h5sA2vgOxA9gvHC91FBoPylQHJWXxdlSXJd7Qp1P+UR9EnAoPVIF4q6YSDB8CYA==", null, false, "45118907", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a2febe6b-73cf-48e5-becf-f0143349da5f", "42ab97c4-0cbe-4535-958f-350fa587f38d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "66760d1a-7cbd-4365-85a1-7bff1c5cc89e", "f0ac269f-3b42-4a65-be1d-bd2588269def" });
        }
    }
}
