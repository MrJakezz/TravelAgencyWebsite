using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationID);

            values.DestinationCity = command.DestinationCity;
            values.DestinationDayNight = command.DestinationDayNight;
            values.DestinationPrice = command.DestinationPrice;

            _context.SaveChanges();
        }
    }
}
