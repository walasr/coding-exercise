using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.HotelsOffers.Models.API
{
    public class ApiResult
    {
        public OfferInfo OfferInfo { get; set; }
        public UserInfo UserInfo { get; set; }
        public Offers Offers { get; set; }
    }
}
