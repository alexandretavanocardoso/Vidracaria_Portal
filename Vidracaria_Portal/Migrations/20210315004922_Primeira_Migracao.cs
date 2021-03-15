using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Primeira_Migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APROVADOS",
                columns: table => new
                {
                    CodigoAprovado = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APROVADOS", x => x.CodigoAprovado);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    CodigoCliente = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NomeCliente = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CidadeCliente = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    EstadoCliente = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Documento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.CodigoCliente);
                });

            migrationBuilder.CreateTable(
                name: "CONCLUIDOS",
                columns: table => new
                {
                    CodigoConcluido = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONCLUIDOS", x => x.CodigoConcluido);
                });

            migrationBuilder.CreateTable(
                name: "CONTATOS",
                columns: table => new
                {
                    CodigoContato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Assunto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Mensagem = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Retorno = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    DataContato = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataRetorno = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTATOS", x => x.CodigoContato);
                });

            migrationBuilder.CreateTable(
                name: "CORES",
                columns: table => new
                {
                    CodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NomeCor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CORES", x => x.CodigoCor);
                });

            migrationBuilder.CreateTable(
                name: "EXPESSURA",
                columns: table => new
                {
                    CodigoExpessura = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Expessura = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXPESSURA", x => x.CodigoExpessura);
                });

            migrationBuilder.CreateTable(
                name: "ORCAMENTOS",
                columns: table => new
                {
                    CodigoOrcamento = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORCAMENTOS", x => x.CodigoOrcamento);
                });

            migrationBuilder.CreateTable(
                name: "PENDENTES",
                columns: table => new
                {
                    CodigoPendentes = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PENDENTES", x => x.CodigoPendentes);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 85, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 85, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    RoleId = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    Name = table.Column<string>(type: "varchar(85)", maxLength: 85, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FERRAGENS",
                columns: table => new
                {
                    CodigoFerragem = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NomeFerragem = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
                    CorCodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Marca = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    EstoqueMaximo = table.Column<int>(type: "int", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoFabrica = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FERRAGENS", x => x.CodigoFerragem);
                    table.ForeignKey(
                        name: "FK_FERRAGENS_CORES_CorCodigoCor",
                        column: x => x.CorCodigoCor,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    Codigo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
                    CorCodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    EstoqueMaximo = table.Column<int>(type: "int", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoFabrica = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_PRODUTOS_CORES_CorCodigoCor",
                        column: x => x.CorCodigoCor,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ALUMINIOS",
                columns: table => new
                {
                    CodigoAluminio = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NomeAluminio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
                    CorCodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ExpessuraId = table.Column<int>(type: "int", nullable: false),
                    ExpessuraCodigoExpessura = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    EstoqueMaximo = table.Column<int>(type: "int", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoFabrica = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALUMINIOS", x => x.CodigoAluminio);
                    table.ForeignKey(
                        name: "FK_ALUMINIOS_CORES_CorCodigoCor",
                        column: x => x.CorCodigoCor,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ALUMINIOS_EXPESSURA_ExpessuraCodigoExpessura",
                        column: x => x.ExpessuraCodigoExpessura,
                        principalTable: "EXPESSURA",
                        principalColumn: "CodigoExpessura",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VIDROS_COMUNS",
                columns: table => new
                {
                    CodigoVidro = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NomeVidro = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
                    CorCodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ExpessuraId = table.Column<int>(type: "int", nullable: false),
                    ExpessuraCodigoExpessura = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Marca = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    EstoqueMaximo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    EstoqueMinimo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoVenda = table.Column<int>(type: "int", nullable: false),
                    PrecoFabrica = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIDROS_COMUNS", x => x.CodigoVidro);
                    table.ForeignKey(
                        name: "FK_VIDROS_COMUNS_CORES_CorCodigoCor",
                        column: x => x.CorCodigoCor,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VIDROS_COMUNS_EXPESSURA_ExpessuraCodigoExpessura",
                        column: x => x.ExpessuraCodigoExpessura,
                        principalTable: "EXPESSURA",
                        principalColumn: "CodigoExpessura",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VIDROS_TEMPERADOS",
                columns: table => new
                {
                    CodigoVidro = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NomeVidro = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
                    CorCodigoCor = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ExpessuraId = table.Column<int>(type: "int", nullable: false),
                    ExpessuraCodigoExpessura = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Marca = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    EstoqueMaximo = table.Column<int>(type: "int", nullable: false),
                    EstoqueMinimo = table.Column<int>(type: "int", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoFabrica = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIDROS_TEMPERADOS", x => x.CodigoVidro);
                    table.ForeignKey(
                        name: "FK_VIDROS_TEMPERADOS_CORES_CorCodigoCor",
                        column: x => x.CorCodigoCor,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VIDROS_TEMPERADOS_EXPESSURA_ExpessuraCodigoExpessura",
                        column: x => x.ExpessuraCodigoExpessura,
                        principalTable: "EXPESSURA",
                        principalColumn: "CodigoExpessura",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_CorCodigoCor",
                table: "ALUMINIOS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_ExpessuraCodigoExpessura",
                table: "ALUMINIOS",
                column: "ExpessuraCodigoExpessura");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FERRAGENS_CorCodigoCor",
                table: "FERRAGENS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CorCodigoCor",
                table: "PRODUTOS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_CorCodigoCor",
                table: "VIDROS_COMUNS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_ExpessuraCodigoExpessura",
                table: "VIDROS_COMUNS",
                column: "ExpessuraCodigoExpessura");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_CorCodigoCor",
                table: "VIDROS_TEMPERADOS",
                column: "CorCodigoCor");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_ExpessuraCodigoExpessura",
                table: "VIDROS_TEMPERADOS",
                column: "ExpessuraCodigoExpessura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALUMINIOS");

            migrationBuilder.DropTable(
                name: "APROVADOS");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "CONCLUIDOS");

            migrationBuilder.DropTable(
                name: "CONTATOS");

            migrationBuilder.DropTable(
                name: "FERRAGENS");

            migrationBuilder.DropTable(
                name: "ORCAMENTOS");

            migrationBuilder.DropTable(
                name: "PENDENTES");

            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DropTable(
                name: "VIDROS_COMUNS");

            migrationBuilder.DropTable(
                name: "VIDROS_TEMPERADOS");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CORES");

            migrationBuilder.DropTable(
                name: "EXPESSURA");
        }
    }
}
