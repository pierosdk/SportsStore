namespace SportsStore.Models
{
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="EFProductRepository" />
    /// </summary>
    public class EFProductRepository : IProductRepository
    {
  
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
