using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVCCoreEmpty.Models;

// For more information on enabling MVC for empty projects, visit https: //go.microsoft.com/fwlink/?LinkID=397860

namespace WebMVCCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        public HomeController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        // GET: /<controller>/
        public string Index()
        {
            //return Json(new { ID = 1, Name = "Jahanzeb" });
            return _countryRepository.GetCountry(1).Name;
        }
    }
}
