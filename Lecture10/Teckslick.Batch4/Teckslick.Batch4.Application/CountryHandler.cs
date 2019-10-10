using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teckslick.Batch4.Common;
using Teckslick.Batch4.DAL;

namespace Teckslick.Batch4.Application
{
    public class CountryHandler
    {
        public List<Country> Countries { get; set; }

        public CountryHandler() { }

        public List<Country> GetCountries()
        {
            return new CountryDAL().GetCountries();
        }
    }
}
