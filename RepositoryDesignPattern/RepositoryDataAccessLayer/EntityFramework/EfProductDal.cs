using Microsoft.EntityFrameworkCore;
using RepositoryDataAccessLayer.Abstract;
using RepositoryDataAccessLayer.Concrete;
using RepositoryDataAccessLayer.Repositories;
using RepositoryEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;
        public EfProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            return _context.Products.Include(x => x.Category).ToList();
        }
    }
}
