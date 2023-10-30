using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueriesHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueriesHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueriesResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueriesResult
            {
                DestinationID = x.DestinationID,
                DestinationCapacity = x.DestinationCapacity,
                DestinationCity = x.DestinationCity,
                DestinationDayNight = x.DestinationDayNight,
                DestinationPrice = x.DestinationPrice

            }).AsNoTracking().ToList();
            //AsNoTracking: Sadece oku. Herhangi bir değişikliğe izin verme.

            return values;
        }
    }
}
