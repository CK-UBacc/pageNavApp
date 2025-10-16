using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pageNavApp.Model
{
    public class PageModel
    {
        public int CustomerCount { get; set; }
        public string ProductStatus { get; set; }
        public DateTime OrderDate { get; set; }//DateOnly
        public decimal TransactionValue { get; set; }
        public DateTime ShipmentDelivery { get; set; }//TimeOnly
        public bool LocationStatus { get; set; }
    }
}
