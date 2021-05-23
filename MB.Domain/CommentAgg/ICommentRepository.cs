using System.Collections.Generic;
using _01_Framwork.Infrastructure;
using MB.Application.Contracts.Comment;
using Nest;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository : IRepository<long,Comment>
    {
        List<CommentViewModel> GetList();
    }
}