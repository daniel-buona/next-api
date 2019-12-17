using AutoMapper;
using NextSI.Application.Dto.Models.Modules.Configuration;
using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Application.Dto.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            #region Configuration
            #region Usuarios
            CreateMap<GrupoUsuariosDto, GrupoUsuarios>()
                    .ForMember(s => s.Usuarios, c => c.MapFrom(m => m.Usuarios));
            CreateMap<UsuarioDto, Usuario>()
                    .ForMember(s => s.Grupos, c => c.MapFrom(m => m.Grupos));
            CreateMap<UsuarioGrupoUsuariosDto, UsuarioGrupoUsuarios>()
                .ForMember(s => s.UsuarioId, c => c.MapFrom(m => m.UsuarioId))
                .ForMember(s => s.GrupoUsuariosId, c => c.MapFrom(m => m.GrupoUsuariosId));
            #endregion
            CreateMap<AreaDto, AreaDto>();
            CreateMap<CalendarioTrabalhoDto, CalendarioTrabalho>();
            CreateMap<ServidorLdapDto, ServidorLdap>();
            #endregion

        }
    }
}
