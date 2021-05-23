using _01_Framwork.Infrastructure;

namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository : IRepository<long, ArticleCategory>
    {
    }
}