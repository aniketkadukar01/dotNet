using ProductsOnline.Models;
using ProductsOnline.Repositories;

namespace ProductsOnline.Services
{
    public class ProductService : IProductService
    {
        public void DeleteProduct(int id)
        {
            using (var context = new EStoreCollectionContext())
            {
                var product = context.products.Find(id);
                if (product != null)
                {
                    context.products.Remove(product);
                    context.SaveChanges();
                }
                
            }
        }

        public Product GetProductById(int id)
        {
            using (var context = new EStoreCollectionContext())
            {
                var product = context.products.Find(id);
                if (product != null)
                {
                    return product;
                }
                throw new NotImplementedException();
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new EStoreCollectionContext())
            {
                var products = from p in context.products select p;
                return products.ToList<Product>();
            }
        }

        public void InsertProduct(Product product)
        {
            using (var context = new EStoreCollectionContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using(var context = new EStoreCollectionContext())
            {
                var findProduct = context.products.Find(product.Id);
                findProduct.Description= product.Description;
                findProduct.Title= product.Title;
                findProduct.UnitPrice= product.UnitPrice;
                findProduct.Quantity= product.Quantity;
                findProduct.ImageUrl= product.ImageUrl;
                context.SaveChanges();
            }
        }
    }
}
