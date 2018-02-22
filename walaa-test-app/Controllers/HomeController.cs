using Expedia.HotelsOffers.Integration;
using Expedia.HotelsOffers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Expedia.HotelsOffers.Controllers
{
    public class HomeController : Controller
    {
        #region Private Members
            private IHotelService hotelServiceIntegrator;
        #endregion

        #region Constructors
        public HomeController(IHotelService hotelServiceIntegrator)
        {
            this.hotelServiceIntegrator = hotelServiceIntegrator;
        }
        #endregion

        #region Action Methods
        /// <summary>
        /// Home Get Action view empty search criteria
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(new Search());
        }
        /// <summary>
        /// Conduct search and return result
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(Search search)
        {
           search.Hotels= hotelServiceIntegrator.SearchDeals(search.Criteria)?.Result?.Offers?.Hotel;
            return View(search);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
