using MediatR;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQueries : IRequest<GetGuideByIDQueriesResult>
    {
        public GetGuideByIDQueries(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
