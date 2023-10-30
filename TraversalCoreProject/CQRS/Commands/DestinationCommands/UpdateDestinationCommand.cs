namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int DestinationID { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationDayNight { get; set; }
        public double DestinationPrice { get; set; }
    }
}
