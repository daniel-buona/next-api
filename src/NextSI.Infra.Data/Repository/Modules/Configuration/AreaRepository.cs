using NextSI.Domain.Interfaces.Modules.Configuration;
using NextSI.Domain.Models.Modules.Configuration;
using NextSI.Infra.Data.Context;

namespace NextSI.Infra.Data.Repository.Modules.Configuration
{
    public class AreaRepository : Repository<Area>, IAreaRepository
    {
        public AreaRepository(NextSIContext context)
            : base(context)
        {

        }
    }
}
