using AutoMapper;
using NextSI.Domain.Interfaces;
using NextSI.Domain.Models.Modules.Configuration;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using NextSI.Application.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Domain.Interfaces.Modules.Configuration.Usuarios;
using NextSI.Application.Dto.Models.Modules.Configuration.Usuarios;
using NextSI.Infra.Data.Repository;

namespace NextSI.Application.Services.Modules.Configuration
{
    public class GrupoUsuariosAppService : IGrupoUsuariosAppService
    {
        private readonly IMapper _mapper;
        private readonly IGrupoUsuariosRepository _grupoUsuariosRepository;
        private readonly IUsuarioGrupoUsuariosRepository _usuarioGrupoUsuariosRepository;
        private readonly IUnitOfWork _wow;

        public GrupoUsuariosAppService(IUnitOfWork wow,
                                  IMapper mapper,
                                  IGrupoUsuariosRepository grupoUsuariosRepository,
                                  IUsuarioGrupoUsuariosRepository usuarioGrupoUsuariosRepository)
        {
            _mapper = mapper;
            _grupoUsuariosRepository = grupoUsuariosRepository;
            _usuarioGrupoUsuariosRepository = usuarioGrupoUsuariosRepository;
            _wow = wow;
        }

        public List<GrupoUsuariosDto> GetAll()
        {
            var data = _grupoUsuariosRepository.GetAll().ProjectTo<GrupoUsuariosDto>(_mapper.ConfigurationProvider).ToList();
            return data;
        }


        public GrupoUsuariosDto GetById(int Id)
        {
            return _mapper.Map<GrupoUsuariosDto>(_grupoUsuariosRepository.GetById(Id));
        }

        public GrupoUsuariosDto Register(GrupoUsuariosDto Model)
        {
            _wow.BeginTransaction();
            try
            {
                var customer = _mapper.Map<GrupoUsuarios>(Model);
                _grupoUsuariosRepository.Add(customer);
                _wow.Commit();
                return _mapper.Map<GrupoUsuariosDto>(customer);

            }
            catch
            {
                _wow.Rollback();
                throw;
            }
        }

        public void Remove(int Id)
        {
            _wow.BeginTransaction();
            try
            {
                _grupoUsuariosRepository.Remove(Id);
                _wow.Commit();
            }
            catch
            {
                _wow.Rollback();
                throw;
            }
            
        }

        public GrupoUsuariosDto Update(GrupoUsuariosDto Model)
        {
            _wow.BeginTransaction();
            try
            {
                var grupoUsuario = _grupoUsuariosRepository.GetById(Model.Id);
                var usuariosAntigos = grupoUsuario.Usuarios;
                
                var customer = _mapper.Map(Model, grupoUsuario);
                _grupoUsuariosRepository.Update(customer);
                
                var usuariosAtuais = customer.Usuarios;
                var usuariosRemovidos = usuariosAntigos.Where(usuarioAtual => !usuariosAtuais.Any(usuarioNovo => usuarioNovo.UsuarioId == usuarioAtual.UsuarioId)).ToList();
                var usuariosAdicionados = usuariosAtuais.Where(usuarioNovo => !usuariosAntigos.Any(usuarioAtual => usuarioAtual.UsuarioId == usuarioNovo.UsuarioId)).ToList();
                  
                foreach(var usuario in usuariosRemovidos)
                {
                    _usuarioGrupoUsuariosRepository.Remove(usuario);
                }

                foreach(var usuario in usuariosAdicionados)
                {
                    _usuarioGrupoUsuariosRepository.Add(usuario);
                }
                
                _wow.Commit();
                return _mapper.Map<GrupoUsuariosDto>(customer);
            }
            catch
            {
                _wow.Rollback();
                throw;
            }

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
