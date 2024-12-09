using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIshnat_Yossef.Service.Service
{
    public class ProductService : IProductService
    {
        readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> repository)
        {
            _productRepository = repository;
        }
        public bool Add(Product product)
        {
           if (product == null) { return false; }
           return _productRepository.Add(product);
        }

        public bool Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public Product Get(int id)
        {
           return _productRepository.Get(id);
        }

        public List<Product> GetAll()
        {
           return _productRepository.GetAll();
        }

        public bool Update(int id, Product product)
        {
           return _productRepository.Update(id, product);
        }
    }
}
