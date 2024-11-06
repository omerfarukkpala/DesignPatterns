using DesignPatternDataAccessLayer.Abstract;
using DesignPatternDataAccessLayer.Concrete;
using DesignPatternDataAccessLayer.Repositories;
using DesigPatternEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDataAccessLayer.EntityFramework
{
    public class EfProcessDal :GenericRepository<Process> ,IProcessDal
    {
        public EfProcessDal(Context context):base(context)
        {
             
        }
    }
}
