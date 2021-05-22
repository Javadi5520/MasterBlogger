using MB.Application.Contract.Comment;

namespace MB.Application
{
    public class CommentApplcation : ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplcation(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
    }
}