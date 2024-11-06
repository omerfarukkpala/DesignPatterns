using RepositoryBusinessLayer.Abstract;
using RepositoryDataAccessLayer.Abstract;
using RepositoryEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryBusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public List<Product> TProductListWithCategory()
        {
            return _productDal.ProductListWithCategory();
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
