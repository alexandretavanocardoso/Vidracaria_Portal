using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Vidracaria_Portal.Models;
using Vidracaria_Portal.Models.Administrador.Cadastros;
using Vidracaria_Portal.Models.Administrador.Servicos;
using Vidracaria_Portal.Models.Cliente;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Data.Context
{
    public class VidracariaContext : IdentityDbContext<UsuarioModel> {
        public VidracariaContext(DbContextOptions<VidracariaContext> options)
            : base(options)
        {
        }

        #region [DbSet<>]
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<GaleriaModel> GaleriaModels { get; set; }
        public DbSet<AluminiosModel> Aluminios { get; set; }
        public DbSet<ClientesModel> Clientes { get; set; }
        public DbSet<FerragensModel> Ferragens { get; set; }
        public DbSet<VidrosComunsModel> VidrosComuns { get; set; }
        public DbSet<VidrosTemperadosModel> VidrosTemperados { get; set; }
        public DbSet<AprovadosModel> Aprovados { get; set; }
        public DbSet<OrcamentosModel> Orcamentos { get; set; }
        public DbSet<TipoDeServicosModel> TipoDeServicos { get; set; }
        public DbSet<ConcluidosModel> Concluidos { get; set; }
        public DbSet<CoresModel> Cores { get; set; }
        public DbSet<ExpessurasModel> Expessura { get; set; }
        public DbSet<PeliculasModel> Peliculas { get; set; }
        public DbSet<AdesivoModel> Adesivos { get; set; }
        public DbSet<AgendaModel> AgendaModels { get; set; }
        public DbSet<ServicosModel> ServicosModels { get; set; }
        public DbSet<TimeModel> TimesModels { get; set; }
        #endregion [DbSet<>]

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UsuarioModel>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<UsuarioModel>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            builder.Entity<UsuarioModel>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));

            builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));

            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));

            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(85));

            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));

            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            // IDS dos perfis
            string ROLE_ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_CLIENTE_ID = Guid.NewGuid().ToString();

            // IDS dos usuarios
            string ADMIN_ID = Guid.NewGuid().ToString();
            string CLIENTE_ID = Guid.NewGuid().ToString();

            // Permiti cadastrar um perfil
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ADMIN_ID, // Chave primaria
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"// Regra - fica tudo em maiusculo
                },
                new IdentityRole
                {
                    Id = ROLE_CLIENTE_ID, // Chave primaria
                    Name = "Cliente",
                    NormalizedName = "CLIENTE"// Regra - fica tudo em maiusculo
                }
                );

            // Criptografia da senha
            var hash1 = new PasswordHasher<UsuarioModel>();
            var hash2 = new PasswordHasher<UsuarioModel>();

            builder.Entity<UsuarioModel>().HasData(
                new UsuarioModel
                {
                    Id = ADMIN_ID,
                    Nome = "Admin",
                    UserName = "admin@vidracariaportal.com.br",
                    NormalizedUserName = "ADMIN@VIDRACARIAPORTAL.COM.BR",
                    Email = "admin@vidracariaportal.com.br",
                    NormalizedEmail = "ADMIN@VIDRACARIAPORTAL.COM.BR",
                    EmailConfirmed = true,
                    PasswordHash = hash1.HashPassword(null, "Q]HU7;],$("), // Nulo e senha que vai ser criptografada
                    SecurityStamp = hash1.GetHashCode().ToString() // Necessario para discriptografa
                },
                 new UsuarioModel
                 {
                     Id = CLIENTE_ID,
                     Nome = "Alexandre",
                     UserName = "tavanoalexandre@outlook.com",
                     NormalizedUserName = "TAVANOALEXANDRE@OUTLOOK.COM",
                     Email = "tavanoalexandre@outlook.com",
                     NormalizedEmail = "TAVANOALEXANDRE@OUTLOOK.COM",
                     EmailConfirmed = true,
                     PasswordHash = hash2.HashPassword(null, "Q]HU7;],$(Q]HU7;],$(Q]HU7;],$(Q]HU7;],$(Q]HU7;],$(Q]HU7;],$(Q]HU7;],$("), // Nulo e senha que vai ser criptografada
                     SecurityStamp = hash2.GetHashCode().ToString() // Necessario para discriptografa
                 }
                );


            // Determina qual user é de qual categoria
            builder.Entity<IdentityUserRole<string>>().HasData(

                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ADMIN_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_CLIENTE_ID,
                    UserId = CLIENTE_ID
                }
                );
        }
        public DbSet<Vidracaria_Portal.Models.Administrador.Cadastros.AgendaModel> AgendaModel { get; set; }
    }
}
