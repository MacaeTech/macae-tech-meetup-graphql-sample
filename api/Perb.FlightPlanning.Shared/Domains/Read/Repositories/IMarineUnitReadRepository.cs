using System;
using System.Linq;
using Perb.FlightPlanning.Shared.Domains.Read.Models;

namespace Perb.FlightPlanning.Shared.Domains.Read.Repositories
{
    public interface IMarineUnitReadRepository
    {
        MarineUnitModel GetById(Guid id);
        IQueryable<MarineUnitModel> GetQuery();
    }
}