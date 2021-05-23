using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg.Exceptions;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleCategoryValidatorService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }


        public void CheckThatThisRecordAlreadyExists(string title)
        {
            if (_articleRepository.Exists(x => x.Title == title))
                throw new DuplicatedRecordException();
        }
    }
}