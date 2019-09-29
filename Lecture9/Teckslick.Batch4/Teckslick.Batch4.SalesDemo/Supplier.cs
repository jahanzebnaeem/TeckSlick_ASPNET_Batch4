using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teckslick.Batch4.Common;

namespace Teckslick.Batch4.SalesDemo
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public List<ContactNumber> ContactNumbers { get; set; }
    }
}
