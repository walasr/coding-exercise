using System.Collections.Generic;

namespace Expedia.HotelsOffers.Models.API
{
    public class OfferDateRange
    {
        public List<int> TravelStartDate { get; set; }
        public List<int> TravelEndDate { get; set; }
        public int LengthOfStay { get; set; }
    }
}
