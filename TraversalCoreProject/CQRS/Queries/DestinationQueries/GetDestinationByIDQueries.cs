namespace TraversalCoreProject.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIDQueries
    {
        public GetDestinationByIDQueries(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
