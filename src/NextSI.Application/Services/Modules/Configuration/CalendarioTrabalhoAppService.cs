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
    public class CalendarioTrabalhoAppService: ICalendarioTrabalhoAppService
    {
        private readonly IMapper _mapper;
        private readonly ICalendarioTrabalhoRepository _calendarioTrabalhoRepository;
        private readonly IUnitOfWork _wow;

        public CalendarioTrabalhoAppService(IUnitOfWork wow,
                                  IMapper mapper,
                                  ICalendarioTrabalhoRepository calendarioTrabalhoRepository)
        {
            _mapper = mapper;
            _calendarioTrabalhoRepository = calendarioTrabalhoRepository;
            _wow = wow;
        }

        public List<CalendarioTrabalhoDto> GetAll()
        {
            var data = _calendarioTrabalhoRepository.GetAll().ProjectTo<CalendarioTrabalhoDto>(_mapper.ConfigurationProvider).ToList();
            return data;
        }


        public CalendarioTrabalhoDto GetById(int Id)
        {
            return _mapper.Map<CalendarioTrabalhoDto>(_calendarioTrabalhoRepository.GetById(Id));
        }
    }
}
