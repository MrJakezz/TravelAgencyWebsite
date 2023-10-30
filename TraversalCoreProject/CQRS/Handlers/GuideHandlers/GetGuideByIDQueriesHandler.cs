using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreProject.CQRS.Queries.GuideQueries;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueriesHandler : IRequestHandler<GetGuideByIDQueries, GetGuideByIDQueriesResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueriesHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueriesResult> Handle(GetGuideByIDQueries request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.id);

            return new GetGuideByIDQueriesResult
            {
                GuideID = values.GuideID,
                GuideDescription = values.GuideDescription,
                GuideName = values.GuideName
            };
        }
    }
}
