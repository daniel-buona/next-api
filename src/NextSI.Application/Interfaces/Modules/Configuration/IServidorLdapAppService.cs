using NextSI.Application.Dto.Models.Modules.Configuration;
using System.Collections.Generic;

namespace NextSI.Application.Interfaces.Modules.Configuration
{
    public interface IServidorLdapAppService
    {
        List<ServidorLdapDto> GetAll();
        ServidorLdapDto GetById(int Id);
    }
}
