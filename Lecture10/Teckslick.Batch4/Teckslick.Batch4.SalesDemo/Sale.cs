using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teckslick.Batch4.SalesDemo
{
    public class Sale
    {
        public int SaleID { get; set; }
        public DateTime SaleDateTime { get; set; }
        public List<SaleLineItem> SaleLineItems { get; set; }
    }
}
