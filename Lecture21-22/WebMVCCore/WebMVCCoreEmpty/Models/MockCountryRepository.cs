using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCCoreEmpty.Models
{
    public class MockCountryRepository : ICountryRepository
    {
        private List<Country> _countryList;

        public MockCountryRepository()
        {
            _countryList = new List<Country>()
            {
                new Country() { ID = 1, Name = "Pakistan" },
                new Country() { ID = 2, Name = "Iran" },
                new Country() { ID = 3, Name = "Afghanistan" }
            };
        }

        public Country GetCountry(int id)
        {
            return _countryList.FirstOrDefault(c => c.ID == id);
        }
    }
}
