using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCCoreEmpty.Models
{
    public interface ICountryRepository
    {
        Country GetCountry(int id);
    }
}
