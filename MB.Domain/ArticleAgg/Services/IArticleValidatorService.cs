namespace MB.Domain.ArticleAgg.Services
{
    public interface IArticleValidatorService
    {
        void CheckThatThisRecordAlreadyExists(string title);
     }

    public class ArticleValidatorService : IArticleValidatorService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleValidatorService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CheckThatThisRecordAlreadyExists(string title)
        {
            throw new System.NotImplementedException();
        }
    }
}