using GraphQLInvestigation.Data;
using GraphQLInvestigation.Models;

namespace GraphQLInvestigation.Query
{
    public class Query
    {
        

        public List<Product> GetProducts([Service(ServiceKind.Synchronized)] MembershipDbContext context)
        {
            List<Product> products = context.Products.ToList<Product>();

            return products;
        }

        public Product GetProduct(int id, [Service(ServiceKind.Synchronized)] MembershipDbContext context)
        {

            var product = context.Products.SingleOrDefault<Product>(p => p.Id == id);

            return product;
        }
    }
}
