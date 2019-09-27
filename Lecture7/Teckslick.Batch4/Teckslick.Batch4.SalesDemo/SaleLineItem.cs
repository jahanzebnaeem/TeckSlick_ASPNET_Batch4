using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teckslick.Batch4.SalesDemo.Items;

namespace Teckslick.Batch4.SalesDemo
{
    public class SaleLineItem
    {
        public int SaleLineItemID { get; set; }
        public List<Item> Items { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
