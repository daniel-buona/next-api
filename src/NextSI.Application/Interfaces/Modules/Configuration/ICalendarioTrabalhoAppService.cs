using NextSI.Application.Dto.Models.Modules.Configuration;
using System.Collections.Generic;

namespace NextSI.Application.Interfaces.Modules.Configuration
{
    public interface ICalendarioTrabalhoAppService
    {
        List<CalendarioTrabalhoDto> GetAll();
        CalendarioTrabalhoDto GetById(int Id);
    }
}
