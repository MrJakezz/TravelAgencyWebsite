using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProject.CQRS.Queries.GuideQueries;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueriesHandler : IRequestHandler<GetAllGuideQueries, List<GetAllGuideQueriesResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueriesHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueriesResult>> Handle(GetAllGuideQueries request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueriesResult
            {
                GuideID = x.GuideID,
                GuideName = x.GuideName,
                GuideDescription = x.GuideDescription,
                GuideImage = x.GuideImage,
            }).AsNoTracking().ToListAsync();
        }
    }
}
