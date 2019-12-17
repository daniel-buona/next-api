using AutoMapper;
using AutoMapper.QueryableExtensions;
using NextSI.Application.Dto.Models.Modules.Configuration;
using NextSI.Application.Interfaces.Modules.Configuration;
using NextSI.Domain.Interfaces;
using NextSI.Domain.Interfaces.Modules.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextSI.Application.Services.Modules.Configuration
{
    public class ServidorLdapAppService: IServidorLdapAppService
    {
        private readonly IMapper _mapper;
        private readonly IServidorLdapRepository _servidorLdapRepository;
        private readonly IUnitOfWork _wow;

        public ServidorLdapAppService(IUnitOfWork wow,
                                  IMapper mapper,
                                  IServidorLdapRepository servidorLdapRepository)
        {
            _mapper = mapper;
            _servidorLdapRepository = servidorLdapRepository;
            _wow = wow;
        }

        public List<ServidorLdapDto> GetAll()
        {
            var data = _servidorLdapRepository.GetAll().ProjectTo<ServidorLdapDto>(_mapper.ConfigurationProvider).ToList();
            return data;
        }


        public ServidorLdapDto GetById(int Id)
        {
            return _mapper.Map<ServidorLdapDto>(_servidorLdapRepository.GetById(Id));
        }
    }
}
