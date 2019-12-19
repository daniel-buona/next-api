using NextSI.Application.Dto.Models.Modules.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace NextSI.Application.Interfaces.Modules.Configuration
{
    public interface ITipoEntidadeAppService
    {
        List<TipoEntidadeDto> Get();
        TipoEntidadeDto Get(int Id);
    }
}
