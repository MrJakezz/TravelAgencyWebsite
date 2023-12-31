﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                DestinationCity = command.DestinationCity,
                DestinationPrice = command.DestinationPrice,
                DestinationDayNight = command.DestinationDayNight,
                DestinationCapacity = command.DestinationCapacity,
                DestinationStatus = true
            });

            _context.SaveChanges();
        }
    }
}
