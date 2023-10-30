using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueriesHandler _getDestinationQueriesHandler;
        private readonly GetDestinationByIDQueriesHandler _getDestinationByIDQueriesHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly DeleteDestinationCommandHandler _deleteDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;

        public DestinationCQRSController(GetAllDestinationQueriesHandler getDestinationQueriesHandler, GetDestinationByIDQueriesHandler getDestinationByIDQueriesHandler, CreateDestinationCommandHandler createDestinationCommandHandler, DeleteDestinationCommandHandler deleteDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _getDestinationQueriesHandler = getDestinationQueriesHandler;
            _getDestinationByIDQueriesHandler = getDestinationByIDQueriesHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _deleteDestinationCommandHandler = deleteDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getDestinationQueriesHandler.Handle();

            return View(values);
        }

        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIDQueriesHandler.Handle(new GetDestinationByIDQueries(id));

            return View(values);
        }

        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            _deleteDestinationCommandHandler.Handle(new DeleteDestinationCommand(id));

            return RedirectToAction("Index");
        }
    }
}
