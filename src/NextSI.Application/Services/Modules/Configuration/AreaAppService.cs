

using AutoMapper;
using AutoMapper.QueryableExtensions;
using NextSI.Application.Dto.Models.Modules.Configuration;
using NextSI.Application.Interfaces.Modules.Configuration;
using NextSI.Domain.Interfaces;
using NextSI.Domain.Interfaces.Modules.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace NextSI.Application.Services.Modules.Configuration
{
    public class AreaAppService: IAreaAppService
    {
        private readonly IMapper _mapper;
        private readonly IAreaRepository _areaRepository;
        private readonly IUnitOfWork _wow;

        public AreaAppService(IUnitOfWork wow,
                                  IMapper mapper,
                                  IAreaRepository areaRepository)
        {
            _mapper = mapper;
            _areaRepository = areaRepository;
            _wow = wow;
        }

        public List<AreaDto> GetAll()
        {
            var data = _areaRepository.GetAll()
                                      .ProjectTo<AreaDto>(_mapper.ConfigurationProvider)
                                      .ToList();
            return data;
        }

        public AreaDto GetById(int Id)
        {
            return _mapper.Map<AreaDto>(_areaRepository.GetById(Id));
        }
    }
}
