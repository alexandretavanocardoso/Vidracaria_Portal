using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vidracaria_Portal.Migrations
{
    public partial class Ajuste_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADESIVOS",
                columns: table => new
                {
                    CodigoAdesivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADESIVOS", x => x.CodigoAdesivo);
                });

            migrationBuilder.CreateTable(
                name: "AGENDA",
                columns: table => new
                {
                    CodigoAgenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Texto = table.Column<string>(type: "text", nullable: false),
                    Assunto = table.Column<string>(type: "text", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataLimite = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENDA", x => x.CodigoAgenda);
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
                    CodigoCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CidadeCliente = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    EstadoCliente = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Documento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.CodigoCliente);
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
                    CodigoCor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
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
                    CodigoExpessura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Expessura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXPESSURA", x => x.CodigoExpessura);
                });

            migrationBuilder.CreateTable(
                name: "GALERIA",
                columns: table => new
                {
                    CodigoGaleria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Imagem = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GALERIA", x => x.CodigoGaleria);
                });

            migrationBuilder.CreateTable(
                name: "NOSSO_TIME",
                columns: table => new
                {
                    CodigoTIme = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeTime = table.Column<string>(type: "text", nullable: true),
                    Cargo = table.Column<string>(type: "text", nullable: true),
                    Imagem = table.Column<string>(type: "text", nullable: true),
                    LinkFacebook = table.Column<string>(type: "text", nullable: true),
                    LinkImagem = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOSSO_TIME", x => x.CodigoTIme);
                });

            migrationBuilder.CreateTable(
                name: "PELICULAS",
                columns: table => new
                {
                    CodigoPelicula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PELICULAS", x => x.CodigoPelicula);
                });

            migrationBuilder.CreateTable(
                name: "SERVICOS",
                columns: table => new
                {
                    CodigoServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeServico = table.Column<string>(type: "text", nullable: true),
                    Imagem = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVICOS", x => x.CodigoServico);
                });

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
                name: "ALUMINIOS",
                columns: table => new
                {
                    CodigoAluminio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeAluminio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_ALUMINIOS_CORES_CorId",
                        column: x => x.CorId,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FERRAGENS",
                columns: table => new
                {
                    CodigoFerragem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeFerragem = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    CorId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_FERRAGENS_CORES_CorId",
                        column: x => x.CorId,
                        principalTable: "CORES",
                        principalColumn: "CodigoCor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VIDROS_COMUNS",
                columns: table => new
                {
                    CodigoVidro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeVidro = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    AdesivoId = table.Column<int>(type: "int", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    ExpessuraId = table.Column<int>(type: "int", nullable: false),
                    Marca = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    EstoqueMaximo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    EstoqueMinimo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PrecoFabrica = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIDROS_COMUNS", x => x.CodigoVidro);
                    table.ForeignKey(
                        name: "FK_VIDROS_COMUNS_ADESIVOS_AdesivoId",
                        column: x => x.AdesivoId,
                        principalTable: "ADESIVOS",
                        principalColumn: "CodigoAdesivo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VIDROS_COMUNS_EXPESSURA_ExpessuraId",
                        column: x => x.ExpessuraId,
                        principalTable: "EXPESSURA",
                        principalColumn: "CodigoExpessura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VIDROS_COMUNS_PELICULAS_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "PELICULAS",
                        principalColumn: "CodigoPelicula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VIDROS_TEMPERADOS",
                columns: table => new
                {
                    CodigoVidro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomeVidro = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false),
                    AdesivoId = table.Column<int>(type: "int", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    ExpessuraId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_VIDROS_TEMPERADOS_ADESIVOS_AdesivoId",
                        column: x => x.AdesivoId,
                        principalTable: "ADESIVOS",
                        principalColumn: "CodigoAdesivo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VIDROS_TEMPERADOS_EXPESSURA_ExpessuraId",
                        column: x => x.ExpessuraId,
                        principalTable: "EXPESSURA",
                        principalColumn: "CodigoExpessura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "PELICULAS",
                        principalColumn: "CodigoPelicula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "APROVADOS",
                columns: table => new
                {
                    CodigoAprovado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodigoOrcamento = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    Rua = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    TipoServicoCodigoTipo = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Imagem = table.Column<string>(type: "text", nullable: true),
                    Valor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APROVADOS", x => x.CodigoAprovado);
                    table.ForeignKey(
                        name: "FK_APROVADOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo",
                        column: x => x.TipoServicoCodigoTipo,
                        principalTable: "TIPOS_DE_SERVICOS",
                        principalColumn: "CodigoTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CONCLUIDOS",
                columns: table => new
                {
                    CodigoConcluido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodigoAprovados = table.Column<int>(type: "int", nullable: false),
                    CodigoOrcamento = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    Rua = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    TipoServicoCodigoTipo = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Imagem = table.Column<string>(type: "text", nullable: true),
                    Valor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONCLUIDOS", x => x.CodigoConcluido);
                    table.ForeignKey(
                        name: "FK_CONCLUIDOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo",
                        column: x => x.TipoServicoCodigoTipo,
                        principalTable: "TIPOS_DE_SERVICOS",
                        principalColumn: "CodigoTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORCAMENTOS",
                columns: table => new
                {
                    CodigoOrcamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    Rua = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    NumeroCasa = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Estado = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    TipoServicoCodigoTipo = table.Column<int>(type: "int", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    Imagem = table.Column<string>(type: "text", nullable: true),
                    Valor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORCAMENTOS", x => x.CodigoOrcamento);
                    table.ForeignKey(
                        name: "FK_ORCAMENTOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo",
                        column: x => x.TipoServicoCodigoTipo,
                        principalTable: "TIPOS_DE_SERVICOS",
                        principalColumn: "CodigoTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9941e63f-5232-4c39-8948-bfc427ededaf", "8baddff7-a11b-49da-a6ae-6a7db6239490", "Administrador", "ADMINISTRADOR" },
                    { "e1843365-3298-400b-997a-903affd186b3", "ed6f2e82-f6e8-4396-a998-01a143c941c8", "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d01db3aa-64eb-4260-8d25-8cb505b9d444", 0, "f26f467d-cbc6-47d8-b8c2-ae3c90450e16", "admin@vidracariaportal.com.br", true, false, null, "Admin", "ADMIN@VIDRACARIAPORTAL.COM.BR", "ADMIN@VIDRACARIAPORTAL.COM.BR", "AQAAAAEAACcQAAAAEKOmu0twm788QVAMLfpIFZv85qcVY8xlYU1UDrAsxduuWnPt1208UbjTXJwcFco+aw==", null, false, "48957711", false, "admin@vidracariaportal.com.br" },
                    { "83ceea67-d002-4804-98f5-742a37e5c332", 0, "5934fc21-0f95-4591-b546-71aa42c9248e", "tavanoalexandre@outlook.com", true, false, null, "Alexandre", "TAVANOALEXANDRE@OUTLOOK.COM", "TAVANOALEXANDRE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEBwZF5WRd0L6kHfaKHaObysm3ltIGenEtKfGNfKv7feQQiUz3C7/ro/uaMpwkwQxLQ==", null, false, "37966223", false, "tavanoalexandre@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9941e63f-5232-4c39-8948-bfc427ededaf", "d01db3aa-64eb-4260-8d25-8cb505b9d444" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e1843365-3298-400b-997a-903affd186b3", "83ceea67-d002-4804-98f5-742a37e5c332" });

            migrationBuilder.CreateIndex(
                name: "IX_ALUMINIOS_CorId",
                table: "ALUMINIOS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_APROVADOS_TipoServicoCodigoTipo",
                table: "APROVADOS",
                column: "TipoServicoCodigoTipo");

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
                name: "IX_CONCLUIDOS_TipoServicoCodigoTipo",
                table: "CONCLUIDOS",
                column: "TipoServicoCodigoTipo");

            migrationBuilder.CreateIndex(
                name: "IX_FERRAGENS_CorId",
                table: "FERRAGENS",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_ORCAMENTOS_TipoServicoCodigoTipo",
                table: "ORCAMENTOS",
                column: "TipoServicoCodigoTipo");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_AdesivoId",
                table: "VIDROS_COMUNS",
                column: "AdesivoId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_ExpessuraId",
                table: "VIDROS_COMUNS",
                column: "ExpessuraId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_COMUNS_PeliculaId",
                table: "VIDROS_COMUNS",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_AdesivoId",
                table: "VIDROS_TEMPERADOS",
                column: "AdesivoId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_ExpessuraId",
                table: "VIDROS_TEMPERADOS",
                column: "ExpessuraId");

            migrationBuilder.CreateIndex(
                name: "IX_VIDROS_TEMPERADOS_PeliculaId",
                table: "VIDROS_TEMPERADOS",
                column: "PeliculaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGENDA");

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
                name: "GALERIA");

            migrationBuilder.DropTable(
                name: "NOSSO_TIME");

            migrationBuilder.DropTable(
                name: "ORCAMENTOS");

            migrationBuilder.DropTable(
                name: "SERVICOS");

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
                name: "TIPOS_DE_SERVICOS");

            migrationBuilder.DropTable(
                name: "ADESIVOS");

            migrationBuilder.DropTable(
                name: "EXPESSURA");

            migrationBuilder.DropTable(
                name: "PELICULAS");
        }
    }
}
