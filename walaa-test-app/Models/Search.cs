using Expedia.HotelsOffers.Models.API;
using System.Collections.Generic;


namespace Expedia.HotelsOffers.Models
{
    public class Search
    {
        public Search()
        {
            Criteria = new Criteria();
            Hotels = new List<Hotel>();
        }
        public Criteria Criteria { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
