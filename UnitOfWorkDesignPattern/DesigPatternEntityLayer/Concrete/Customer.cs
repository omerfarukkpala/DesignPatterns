using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigPatternEntityLayer.Concrete
{
    public class Customer
    {
        public  int CustomerID { get; set; }
        public  string CustomerName { get; set; }
        public  decimal CustomerBalance { get; set; }   
    }
}
