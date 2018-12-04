using CustomerApp.Core.DomainService;
using CustomerApp.Core.Entity;

namespace CustomerApp.Core.ApplicationService.Services
{
    public class ProductService: IProductService
    {
        readonly IProductRepository _productRepo;
        
        public ProductService(IProductRepository _productRepo)
        {
            this._productRepo = _productRepo;
        }
        
        public Product Create(Product product)
        {
            return _productRepo.Create(product);
        }

        public Product FindById(int id)
        {
            return _productRepo.ReadyById(id);
        }

        public PagedList<Product> GetAll()
        {
            return _productRepo.ReadAll();
        }

        public PagedList<Product> GetAllFiltered(Filter filter)
        {
            return _productRepo.ReadAll(filter);
        }

        public Product Update(Product productUpdate)
        {
            return _productRepo.Update(productUpdate);
        }

        public Product Delete(int id)
        {
            return _productRepo.Delete(id);
        }
    }
}