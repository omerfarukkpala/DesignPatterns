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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}
