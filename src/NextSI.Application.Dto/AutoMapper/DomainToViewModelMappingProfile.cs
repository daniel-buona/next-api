using AutoMapper;
using NextSI.Application.Dto.Models.Modules.Configuration;
using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Application.Dto.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            #region Configuration
            #region Usuarios
            CreateMap<GrupoUsuarios, GrupoUsuariosDto>()
                    .ForMember(s => s.Usuarios, c => c.MapFrom(m => m.Usuarios));
            CreateMap<Usuario, UsuarioDto>()
                    .ForMember(s => s.Grupos, c => c.MapFrom(m => m.Grupos))
                    .ForMember(s => s.Area, c => c.MapFrom(m => m.Area))
                    .ForMember(s => s.CalendarioTrabalho, c => c.MapFrom(m => m.CalendarioTrabalho))
                    .ForMember(s => s.ServidorLdap, c => c.MapFrom(m => m.ServidorLdap));
            CreateMap<UsuarioGrupoUsuarios, UsuarioGrupoUsuariosDto>();

            #endregion
            CreateMap<AreaDto, AreaDto>();
            CreateMap<CalendarioTrabalho, CalendarioTrabalhoDto>();
            CreateMap<ServidorLdap, ServidorLdapDto>();
            #endregion
        }
    }
}
