﻿using NextSI.Domain.Interfaces.Modules.Configuration;
using NextSI.Domain.Models.Modules.Configuration;
using NextSI.Infra.Data.Context;

namespace NextSI.Infra.Data.Repository.Modules.Configuration
{
    public class CalendarioTrabalhoRepository : Repository<CalendarioTrabalho>, ICalendarioTrabalhoRepository
    {
        public CalendarioTrabalhoRepository(NextSIContext context)
            : base(context)
        {

        }
    }
}
