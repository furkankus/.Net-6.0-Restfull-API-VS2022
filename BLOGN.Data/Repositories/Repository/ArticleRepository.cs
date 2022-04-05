using BLOGN.Data.Repositories.IRepositories;
using BLOGN.Models;

namespace BLOGN.Data.Repositories.Repository
{
    public class ArticleRepository:Repository<Article>, IArticleRepository
    {
        private ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
