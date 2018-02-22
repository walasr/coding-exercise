using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.HotelsOffers.Models.API
{
    public class OfferInfo
    {
        public int SiteID { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string UserSelectedCurrency { get; set; }
    }
}
