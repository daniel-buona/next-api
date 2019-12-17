

using NextSI.Application.Dto.Models.Modules.Configuration;
using System.Collections.Generic;

namespace NextSI.Application.Interfaces.Modules.Configuration
{
    public interface IAreaAppService
    {
        List<AreaDto> GetAll();
        AreaDto GetById(int Id);
    }
}
