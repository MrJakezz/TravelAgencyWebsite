using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comments
{
    public class _CommentListVC : ViewComponent
    {
        private readonly ICommentService _commentService;
        public _CommentListVC (ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetDestinationById(id);

            return View(values);
        }
    }
}
