using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidracaria_Portal.Migrations
{
    public partial class TabelasDeCores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_CorCodigoCor",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_CorCodigoCor",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59c2b6f9-fe2b-430b-9ee9-59a32b81d673", "52eb822d-c634-4168-be4c-4cf1345c2e6b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c5a60f4-956e-486b-b3c3-02d24ea355ca", "d4d1147c-a878-4b0e-901d-a9581ef3db39" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c5a60f4-956e-486b-b3c3-02d24ea355ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59c2b6f9-fe2b-430b-9ee9-59a32b81d673");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52eb822d-c634-4168-be4c-4cf1345c2e6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4d1147c-a878-4b0e-901d-a9581ef3db39");

            migrationBuilder.CreateTable(
                name: "CORES_VIDROS_COMUNS",
                columns: table => new
                {
                    CodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
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
                    CodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
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

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorCodigoCor",
                table: "VIDROS_COMUNS",
                column: "CorCodigoCor",
                principalTable: "CORES_VIDROS_COMUNS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorCodigoCor",
                table: "VIDROS_TEMPERADOS",
                column: "CorCodigoCor",
                principalTable: "CORES_VIDROS_TEMPERADOS",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_VIDROS_COMUNS_CorCodigoCor",
                table: "VIDROS_COMUNS");

            migrationBuilder.DropForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_VIDROS_TEMPERADOS_CorCodigoCor",
                table: "VIDROS_TEMPERADOS");

            migrationBuilder.DropTable(
                name: "CORES_VIDROS_COMUNS");

            migrationBuilder.DropTable(
                name: "CORES_VIDROS_TEMPERADOS");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59c2b6f9-fe2b-430b-9ee9-59a32b81d673", "ad7b3ba9-27ec-487f-a16e-9632c3a79429", "Administrador", "ADMINISTRADOR" },
                    { "4c5a60f4-956e-486b-b3c3-02d24ea355ca", "a1261867-26af-477b-9d73-2a4da8e4a0bb", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52eb822d-c634-4168-be4c-4cf1345c2e6b", 0, "2147eb2b-b72b-4b4e-a349-3f3e51b21eff", new DateTime(2021, 3, 14, 21, 49, 21, 132, DateTimeKind.Local).AddTicks(2099), "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEFqou4++h981b/GG3h0/7KvSvqBgtbrI+m0JOrUKOkyQ7rX9Em+bPuJzYCalQLgkqA==", null, false, "45174131", false, "admin@vidracariaportal.com.br" },
                    { "d4d1147c-a878-4b0e-901d-a9581ef3db39", 0, "8c3b93ed-bc67-4905-b8d6-79a2ef1505de", new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tavanoalexandre@outlook.com", true, false, null, "Alexandre Tavano Cardoso", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEMlkgZW7PXsAqerYqiSafirjSEKho+hw87kPNLDKmMSbcSIgzSEbd6zW3z9YRo8SBw==", null, false, "3913996", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "59c2b6f9-fe2b-430b-9ee9-59a32b81d673", "52eb822d-c634-4168-be4c-4cf1345c2e6b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4c5a60f4-956e-486b-b3c3-02d24ea355ca", "d4d1147c-a878-4b0e-901d-a9581ef3db39" });

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_COMUNS_CORES_CorCodigoCor",
                table: "VIDROS_COMUNS",
                column: "CorCodigoCor",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VIDROS_TEMPERADOS_CORES_CorCodigoCor",
                table: "VIDROS_TEMPERADOS",
                column: "CorCodigoCor",
                principalTable: "CORES",
                principalColumn: "CodigoCor",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
