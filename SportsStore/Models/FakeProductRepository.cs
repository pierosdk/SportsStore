namespace SportsStore.Models
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="FakeProductRepository" />
    /// </summary>
    public class FakeProductRepository : IProductRepository
    {
        /// <summary>
        /// Gets the Products
        /// </summary>
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Surf board", Price = 179 },
            new Product { Name = "Running shoes", Price = 95 }
         }.AsQueryable<Product>();
    }
}
