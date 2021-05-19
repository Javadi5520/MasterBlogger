using MB.Application.Contract.Article;
using System.Collections.Generic;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
    }
}