using NextSI.Domain.Interfaces;
using NextSI.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using NextSI.Application.Services.Modules.Configuration;
using NextSI.Application.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Infra.Data.Repository.Modules.Configuration.Usuarios;
using NextSI.Domain.Interfaces.Modules.Configuration;
using NextSI.Infra.Data.Repository.Modules.Configuration;
using NextSI.Application.Interfaces.Modules.Configuration;

namespace NextSI.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // Context
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<NextSIContext>();

            // Application
            #region Modules
            #region Configuration
            services.AddScoped<IGrupoUsuariosAppService, GrupoUsuariosAppService>();
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
            services.AddScoped<IAreaAppService, AreaAppService>();
            services.AddScoped<ICalendarioTrabalhoAppService, CalendarioTrabalhoAppService>();
            services.AddScoped<IServidorLdapAppService, ServidorLdapAppService>();
            #endregion
            #endregion

            // Infra - Data
            #region Modules
            #region Configuration
            services.AddScoped<IGrupoUsuariosRepository, GrupoUsuariosRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<ICalendarioTrabalhoRepository, CalendarioTrabalhoRepository>();
            services.AddScoped<IServidorLdapRepository, ServidorLdapRepository>();
            #endregion
            #endregion
        }
    }
}