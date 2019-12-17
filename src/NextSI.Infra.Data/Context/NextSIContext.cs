using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NextSI.Infra.Data.Mappings.Modules.Configuration;
using NextSI.Domain.Models.Modules.Configuration;
using NextSI.Infra.Data.Mappings.Modules.Configuration.Clientes;
using NextSI.Infra.Data.Mappings.Modules.Configuration.Empresas;
using NextSI.Infra.Data.Mappings.Modules.Configuration.Fornecedores;
using NextSI.Infra.Data.Mappings.Modules.Configuration.Usuarios;

namespace NextSI.Infra.Data.Context
{
    public class NextSIContext : DbContext
    {
        private readonly IHostEnvironment _env;

        public NextSIContext(IHostEnvironment env)
        {
            _env = env;
        }

        public DbSet<GrupoUsuarios> GrupoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioGrupoUsuarios> UsuarioGrupoUsuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EmpresaFilial> EmpresaFiliais { get; set; }
        public DbSet<EmpresaGrupo> EmpresaGrupos { get; set; }
        public DbSet<EmpresaMatriz> EmpresaMatrizes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<UsuarioEmpresa> UsuarioEmpresas { get; set; }
        public DbSet<UsuarioFornecedor> UsuarioFornecedors {get;set;}
        public DbSet<UsuarioProspect> UsuarioProspects { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<CalendarioTrabalho> CalendarioTrabalhos { get; set; }
        public DbSet<Prospect> Prospects { get; set; }
        public DbSet<ServidorLdap> ServidoresLdap { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Modules

            #region Configuration
            #region Clientes
            modelBuilder.ApplyConfiguration(new ClienteMap());
            #endregion

            #region Empresas
            modelBuilder.ApplyConfiguration(new EmpresaFilialMap());
            modelBuilder.ApplyConfiguration(new EmpresaGrupoMap());
            modelBuilder.ApplyConfiguration(new EmpresaMatrizMap());
            #endregion

            #region Fornecedores
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            #endregion

            #region Usuarios
            modelBuilder.ApplyConfiguration(new GrupoUsuariosMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new UsuarioClienteMap());
            modelBuilder.ApplyConfiguration(new UsuarioEmpresaMap());
            modelBuilder.ApplyConfiguration(new UsuarioFornecedorMap());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoUsuariosMap());
            modelBuilder.ApplyConfiguration(new UsuarioProspectMap());
            #endregion

            #region Geral
            modelBuilder.ApplyConfiguration(new AreaMap());
            modelBuilder.ApplyConfiguration(new CalendarioTrabalhoMap());
            modelBuilder.ApplyConfiguration(new ProspectMap());
            modelBuilder.ApplyConfiguration(new ServidorLdapMap());
            #endregion
            #endregion

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

                // define the database to use
                optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));

                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
