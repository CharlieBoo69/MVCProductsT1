namespace MVCProductsT1.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200, Quantity = 10 },
            new Product { Id = 2, Name = "Telefono", Price = 800, Quantity = 15 }
        };

        public static IEnumerable<Product> GetAllProducts() => _products;

        public static Product GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public static void AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        public static void UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
