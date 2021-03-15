using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Arrumando_Tipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ALUMINIOS_CORES_CorCodigoCor",
                table: "ALUMINIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_ALUMINIOS_EXPESSURA_ExpessuraCodigoExpessura",
                table: "ALUMINIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FERRAGENS_CORES_CorCodigoCor",
                table: "FERRAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUTOS_CORES_CorCodigoCor",
                table: "PRODUTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_ADESIVOS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorCodigoCor",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_EXPESSURA_ExpessuraCodigoExpessura",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_PELICULAS_PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_ADESIVOS_AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorCodigoCor",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_EXPESSURA_ExpessuraCodigoExpessura",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_CorCodigoCor",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_ExpessuraCodigoExpessura",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_CorCodigoCor",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_ExpessuraCodigoExpessura",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUTOS_CorCodigoCor",
                table: "PRODUTOS");

            migrationBuilder.DropIndex(
                name: "IX_FERRAGENS_CorCodigoCor",
                table: "FERRAGENS");

            migrationBuilder.DropIndex(
                name: "IX_ALUMINIOS_CorCodigoCor",
                table: "ALUMINIOS");

            migrationBuilder.DropIndex(
                name: "IX_ALUMINIOS_ExpessuraCodigoExpessura",
                table: "ALUMINIOS");

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
                name: "CorCodigoCor",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "ExpessuraCodigoExpessura",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropColumn(
                name: "AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "CorCodigoCor",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "ExpessuraCodigoExpessura",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropColumn(
                name: "CorCodigoCor",
                table: "PRODUTOS");

            migrationBuilder.DropColumn(
                name: "CorCodigoCor",
                table: "FERRAGENS");

            migrationBuilder.DropColumn(
                name: "CorCodigoCor",
                table: "ALUMINIOS");

            migrationBuilder.DropColumn(
                name: "ExpessuraCodigoExpessura",
                table: "ALUMINIOS");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoPelicula",
                table: "PELICULAS",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Expessura",
                table: "EXPESSURA",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoExpessura",
                table: "EXPESSURA",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCor",
                table: "CORES_VIDROS_TEMPERADOS",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCor",
                table: "CORES_VIDROS_COMUNS",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoCor",
                table: "CORES",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoAdesivo",
                table: "ADESIVOS",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

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

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_AdesivoId",
                table: "VIDROS_TEMPERADOS",
                column: "AdesivoId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_ExpessuraId",
                table: "VIDROS_TEMPERADOS",
                column: "ExpessuraId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_PeliculaId",
                table: "VIDROS_TEMPERADOS",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_AdesivoId",
                table: "VIDROS_COMUNS",
                column: "AdesivoId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_ExpessuraId",
                table: "VIDROS_COMUNS",
                column: "ExpessuraId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_PeliculaId",
                table: "VIDROS_COMUNS",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CorId",
                table: "PRODUTOS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_FERRAGENS_CorId",
                table: "FERRAGENS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_CorId",
                table: "ALUMINIOS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_ExpessuraId",
                table: "ALUMINIOS",
                column: "ExpessuraId");

            migrationBuilder.AddForeignKey(
                name: "FK_ALUMINIOS_CORES_CorId",
                table: "ALUMINIOS",
                column: "CorId",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ALUMINIOS_EXPESSURA_ExpessuraId",
                table: "ALUMINIOS",
                column: "ExpessuraId",
                principalTable: "EXPESSURA",
                principalColumn: "CodigoExpessura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FERRAGENS_CORES_CorId",
                table: "FERRAGENS",
                column: "CorId",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUTOS_CORES_CorId",
                table: "PRODUTOS",
                column: "CorId",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_ADESIVOS_AdesivoId",
                table: "VIDROS_COMUNS",
                column: "AdesivoId",
                principalTable: "ADESIVOS",
                principalColumn: "CodigoAdesivo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS",
                column: "CorId",
                principalTable: "CORES_VIDROS_COMUNS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_EXPESSURA_ExpessuraId",
                table: "VIDROS_COMUNS",
                column: "ExpessuraId",
                principalTable: "EXPESSURA",
                principalColumn: "CodigoExpessura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_PELICULAS_PeliculaId",
                table: "VIDROS_COMUNS",
                column: "PeliculaId",
                principalTable: "PELICULAS",
                principalColumn: "CodigoPelicula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_ADESIVOS_AdesivoId",
                table: "VIDROS_TEMPERADOS",
                column: "AdesivoId",
                principalTable: "ADESIVOS",
                principalColumn: "CodigoAdesivo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS",
                column: "CorId",
                principalTable: "CORES_VIDROS_TEMPERADOS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_EXPESSURA_ExpessuraId",
                table: "VIDROS_TEMPERADOS",
                column: "ExpessuraId",
                principalTable: "EXPESSURA",
                principalColumn: "CodigoExpessura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaId",
                table: "VIDROS_TEMPERADOS",
                column: "PeliculaId",
                principalTable: "PELICULAS",
                principalColumn: "CodigoPelicula",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ALUMINIOS_CORES_CorId",
                table: "ALUMINIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_ALUMINIOS_EXPESSURA_ExpessuraId",
                table: "ALUMINIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FERRAGENS_CORES_CorId",
                table: "FERRAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_PRODUTOS_CORES_CorId",
                table: "PRODUTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_ADESIVOS_AdesivoId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_EXPESSURA_ExpessuraId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_PELICULAS_PeliculaId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_ADESIVOS_AdesivoId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_EXPESSURA_ExpessuraId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_AdesivoId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_CorId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_ExpessuraId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_TEMPERADOS_PeliculaId",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_AdesivoId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_CorId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_ExpessuraId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_VIDROS_COMUNS_PeliculaId",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUTOS_CorId",
                table: "PRODUTOS");

            migrationBuilder.DropIndex(
                name: "IX_FERRAGENS_CorId",
                table: "FERRAGENS");

            migrationBuilder.DropIndex(
                name: "IX_ALUMINIOS_CorId",
                table: "ALUMINIOS");

            migrationBuilder.DropIndex(
                name: "IX_ALUMINIOS_ExpessuraId",
                table: "ALUMINIOS");

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

            migrationBuilder.AddColumn<decimal>(
                name: "AdesivoCodigoAdesivo",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CorCodigoCor",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpessuraCodigoExpessura",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CorCodigoCor",
                table: "VIDROS_COMUNS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpessuraCodigoExpessura",
                table: "VIDROS_COMUNS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CorCodigoCor",
                table: "PRODUTOS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoPelicula",
                table: "PELICULAS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<decimal>(
                name: "CorCodigoCor",
                table: "FERRAGENS",
                type: "decimal(18, 2)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Expessura",
                table: "EXPESSURA",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoExpessura",
                table: "EXPESSURA",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoCor",
                table: "CORES_VIDROS_TEMPERADOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoCor",
                table: "CORES_VIDROS_COMUNS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoCor",
                table: "CORES",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<decimal>(
                name: "CorCodigoCor",
                table: "ALUMINIOS",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpessuraCodigoExpessura",
                table: "ALUMINIOS",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<decimal>(
                name: "CodigoAdesivo",
                table: "ADESIVOS",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

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
                name: "IX_VIDROS_TEMPERADOS_CorCodigoCor",
                table: "VIDROS_TEMPERADOS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_ExpessuraCodigoExpessura",
                table: "VIDROS_TEMPERADOS",
                column: "ExpessuraCodigoExpessura");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS",
                column: "PeliculaCodigoPelicula");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS",
                column: "AdesivoCodigoAdesivo");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_CorCodigoCor",
                table: "VIDROS_COMUNS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_ExpessuraCodigoExpessura",
                table: "VIDROS_COMUNS",
                column: "ExpessuraCodigoExpessura");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_PeliculaCodigoPelicula",
                table: "VIDROS_COMUNS",
                column: "PeliculaCodigoPelicula");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CorCodigoCor",
                table: "PRODUTOS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_FERRAGENS_CorCodigoCor",
                table: "FERRAGENS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_CorCodigoCor",
                table: "ALUMINIOS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_ExpessuraCodigoExpessura",
                table: "ALUMINIOS",
                column: "ExpessuraCodigoExpessura");

            migrationBuilder.AddForeignKey(
                name: "FK_ALUMINIOS_CORES_CorCodigoCor",
                table: "ALUMINIOS",
                column: "CorCodigoCor",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ALUMINIOS_EXPESSURA_ExpessuraCodigoExpessura",
                table: "ALUMINIOS",
                column: "ExpessuraCodigoExpessura",
                principalTable: "EXPESSURA",
                principalColumn: "CodigoExpessura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FERRAGENS_CORES_CorCodigoCor",
                table: "FERRAGENS",
                column: "CorCodigoCor",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUTOS_CORES_CorCodigoCor",
                table: "PRODUTOS",
                column: "CorCodigoCor",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_ADESIVOS_AdesivoCodigoAdesivo",
                table: "VIDROS_COMUNS",
                column: "AdesivoCodigoAdesivo",
                principalTable: "ADESIVOS",
                principalColumn: "CodigoAdesivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorCodigoCor",
                table: "VIDROS_COMUNS",
                column: "CorCodigoCor",
                principalTable: "CORES_VIDROS_COMUNS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_EXPESSURA_ExpessuraCodigoExpessura",
                table: "VIDROS_COMUNS",
                column: "ExpessuraCodigoExpessura",
                principalTable: "EXPESSURA",
                principalColumn: "CodigoExpessura",
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
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorCodigoCor",
                table: "VIDROS_TEMPERADOS",
                column: "CorCodigoCor",
                principalTable: "CORES_VIDROS_TEMPERADOS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_EXPESSURA_ExpessuraCodigoExpessura",
                table: "VIDROS_TEMPERADOS",
                column: "ExpessuraCodigoExpessura",
                principalTable: "EXPESSURA",
                principalColumn: "CodigoExpessura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaCodigoPelicula",
                table: "VIDROS_TEMPERADOS",
                column: "PeliculaCodigoPelicula",
                principalTable: "PELICULAS",
                principalColumn: "CodigoPelicula",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
