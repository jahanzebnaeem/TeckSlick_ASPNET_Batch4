using System.Collections.Generic;

namespace Teckslick.Batch4.Common
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}