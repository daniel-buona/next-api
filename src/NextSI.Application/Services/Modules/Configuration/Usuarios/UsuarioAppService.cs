using AutoMapper;
using AutoMapper.QueryableExtensions;
using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using NextSI.Application.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Interfaces;
using NextSI.Domain.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Models.Modules.Configuration;
using System.Linq;

namespace NextSI.Application.Services.Modules.Configuration
{
    public class UsuarioAppService :  IUsuarioAppService
    {
        private IMapper _mapper;
        private IUsuarioRepository _usuariosRepository;
        private IUnitOfWork _wow;

        public UsuarioAppService(IUnitOfWork wow,
                                 IMapper mapper,
                                 IUsuarioRepository usuariosRepository)
        {
            _mapper = mapper;
            _usuariosRepository = usuariosRepository;
            _wow = wow;
        }
        public IQueryable<UsuarioDto> GetAll()
        {
            var model = _usuariosRepository.GetAll();
            var data = model.ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider);

            return data;
        }

        public UsuarioDto GetById(int Id)
        {
            var model = _usuariosRepository.GetById(Id);
            return _mapper.Map<UsuarioDto>(model);
        }


        public UsuarioDto Update(UsuarioDto Model)
        {
            _wow.BeginTransaction();
            try
            {
                var usuario = _mapper.Map<Usuario>(Model);
                _usuariosRepository.Update(usuario);
                _wow.Commit();

                return _mapper.Map<UsuarioDto>(usuario);
            }
            catch
            {
                _wow.Rollback();
                throw;
            }
            
        }
    }
}
