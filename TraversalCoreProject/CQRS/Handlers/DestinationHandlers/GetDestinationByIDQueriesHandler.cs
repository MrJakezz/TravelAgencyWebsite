using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueriesHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueriesHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueriesResult Handle(GetDestinationByIDQueries query)
        {
            var values = _context.Destinations.Find(query.id);

            return new GetDestinationByIDQueriesResult
            {
                DestinationID = values.DestinationID,
                DestinationCity = values.DestinationCity,
                DestinationDayNight = values.DestinationDayNight,
                DestinationPrice = values.DestinationPrice
            };
        }
    }
}
