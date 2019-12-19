using NextSI.Application.Dto.Models.Modules.Configuration;
using NextSI.Application.Interfaces.Modules.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextSI.Application.Services.Modules.Configuration
{
    public class TipoEntidadeAppService : ITipoEntidadeAppService
    {
        public List<TipoEntidadeDto> Get()
        {
            var model = new List<TipoEntidadeDto>
            {
                new TipoEntidadeDto { Id = 0, Nome = "Nenhum" },
                new TipoEntidadeDto { Id = 1, Nome = "Colaborador" },
                new TipoEntidadeDto { Id = 2, Nome = "Cliente" },
                new TipoEntidadeDto { Id = 3, Nome = "Fornecedor" },
                new TipoEntidadeDto { Id = 4, Nome = "Organização" }
            };


            return model;
        }

        public TipoEntidadeDto Get(int Id)
        {
            return Get().Where(p => p.Id == Id).FirstOrDefault();
        }
    }
}
