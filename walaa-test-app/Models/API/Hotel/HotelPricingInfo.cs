using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.HotelsOffers.Models.API
{
    public class HotelPricingInfo
    {
        public float AveragePriceValue { get; set; }
        public float TotalPriceValue { get; set; }
        public float CrossOutPriceValue { get; set; }
        public float OriginalPricePerNight { get; set; }
        public string Currency { get; set; }
        public float PercentSavings { get; set; }
        public bool Drr { get; set; }
    }
}
