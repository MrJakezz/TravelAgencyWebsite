using MediatR;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQueries : IRequest<List<GetAllGuideQueriesResult>>
    {

    }
}
